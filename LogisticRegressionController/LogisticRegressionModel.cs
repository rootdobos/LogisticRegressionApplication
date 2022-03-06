using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace LogisticRegressionController
{
    public class LossEventArgs
    {
        public double Loss;
        public int Fold;
        public LossEventArgs(double loss, int fold)
        {
            Loss = loss;
            Fold = fold;
        }   
    }
    public class LogisticRegressionModel
    {
        public delegate void LossEventHandler(object sender, LossEventArgs e);
        public event LossEventHandler UpdateLossEvent;

        public LogisticRegressionModel(int numberOfFeatures)
        {
            _NumberOfFeatures = numberOfFeatures;
            WeightInitialization(numberOfFeatures);
        }
        public void CrossValidation(Dataset learningData, double learningRate,int iteration, int folds)
        {
            Dataset[] buckets = Dataset.KFoldBuckets(learningData, folds);
            double avgBias= 0;
            List<double> avgWeights= new List<double>();
            for (int i = 0; i < _NumberOfFeatures; i++)
            {
                avgWeights.Add(0.0);
            }
            for (int i = 0; i < folds; i++)
            {
                WeightInitialization(_NumberOfFeatures);
                Dataset trainData = new Dataset();
                Dataset testData = new Dataset();

                trainData.Maximums = learningData.Maximums;
                testData.Maximums = learningData.Maximums;
                trainData.Header = learningData.Header;
                testData.Header = learningData.Header;

                for(int j=0;j<folds;j++)
                {
                    if (j != i)
                    {
                        trainData.XData.AddRange(buckets[j].XData);
                        trainData.YData.AddRange(buckets[j].YData);
                        trainData.DataStrings.AddRange(buckets[j].DataStrings);
                    }
                    else
                    {
                        testData.XData.AddRange(buckets[j].XData);
                        testData.YData.AddRange(buckets[j].YData);
                        testData.DataStrings.AddRange(buckets[j].DataStrings);
                    }
                }
                Fit(trainData, testData, learningRate, iteration, i);
                avgBias += _Bias / folds;
                for (int k = 0; k < _NumberOfFeatures; k++)
                {
                    avgWeights[k] += _Weights[k] / folds;
                }
            }
            _Bias = avgBias;
            _Weights = avgWeights;
        }
        public void Fit(Dataset learningData, double learningRate, int iteration)
        {
            Dataset shuffledData=Dataset.ShuffleDataset(Dataset.DataDeepCopy(learningData));
            Fit(shuffledData, learningData, learningRate, iteration, -1);
        }
        public void Fit(Dataset learningData, Dataset testData, double learningRate, int iteration,int fold)
        {
            learningData.Normalize();
            testData.Normalize();
            Console.WriteLine("TRAINING STARTED");
            for(int i=0;i<iteration;i++)
            {
                //calculating training output
                double[] modelOutput = Result(learningData.XData);
                //learning
                double[] gradientsWeights = GradientOfWeights(modelOutput, learningData.XData, learningData.YData);
                double gradientBias = GradientOfBiases(modelOutput, learningData.YData);
                for (int j = 0; j < gradientsWeights.Length; j++)
                    _Weights[j] -= learningRate * gradientsWeights[j];
                _Bias -= learningRate * gradientBias;
                //calculating test output
                double[] testOutput = Result(testData.XData);
                double cost = Cost(testOutput, testData.YData);
                if (i % Math.Max((iteration / 100), 1) == 0)
                {
                    if(fold==-1)
                        Console.WriteLine("{0}% TRAINING COMPLETED; LOSS: {1}", i / (iteration / 100.0), cost);
                    else
                        Console.WriteLine("{0}-Fold {1}% TRAINING COMPLETED; LOSS: {2}",fold, i / (iteration / 100.0), cost);
                    UpdateLossEvent?.Invoke(this, new LossEventArgs(cost, fold));
                }
            }
            Console.WriteLine("TRAINING FINISHED");
            _NormalizerVector = learningData.Maximums;
            learningData.Denormalize();
            testData.Denormalize();
        }
        public double Predict(double[] inputData)
        {
            double[] normalizedInput = Dataset.NormalizeArray(inputData, _NormalizerVector);
            double result = SigmoidActivation(SumOfWeightedInputsAndBias(normalizedInput));
            return result;
        }
        public void Save(string path)
        {
            XMLReaderWritter.WriteModel(path, _NumberOfFeatures, _Weights, _Bias, _NormalizerVector);
        }
        public static LogisticRegressionModel LoadFromFile(string path)
        {
            LogisticRegressionModel output = new LogisticRegressionModel(1);
            XMLReaderWritter.ReadModel(path,ref output._NumberOfFeatures, ref output._Weights, ref output._Bias, ref output._NormalizerVector);
            return output;
        }
        private double[] Result(List<double[]> XData)
        {
            double[] result = new double[XData.Count];
            for(int i=0;i<XData.Count;i++)
            {
                result[i] = SigmoidActivation(SumOfWeightedInputsAndBias(XData[i]));
            }
            return result;
        }
        private void WeightInitialization(int numberOfFeatures)
        {
            _Weights = new List<double>();
            for (int i = 0; i < numberOfFeatures; i++)
            {
                _Weights.Add(0.0);
            }
            _Bias = 0;
        }
        private double SigmoidActivation(double value)
        {
            return 1.0/(1+ Math.Exp(-value));
        }
        private double SumOfWeightedInputsAndBias(double[] XData)
        {
            double sum = 0.0;
            for (int i = 0; i < XData.Length; i++)
                sum += _Weights[i] * XData[i];
            sum += _Bias;
            return sum;
        }
        private double[] GradientOfWeights(double[] results,List<double[]> xData, List<double> yData)
        {
            int numberOfWeights = xData[0].Length;
            int numberOfResults = results.Length;
            double[] gradients = new double[numberOfWeights];
            for(int i=0;i< numberOfWeights; i++)
            {
                gradients[i] = 0.0;
                for(int j=0;j<numberOfResults;j++)
                {
                    gradients[i] += (xData[j][i] * (results[j] - yData[j]))/numberOfResults;
                }
            }
            return gradients;
        }
        private double GradientOfBiases(double[] results, List<double> yData)
        {
            int numberOfResults = results.Length;
            double gradient = 0.0;
            for(int i=0;i<numberOfResults;i++)
            {
                gradient += (results[i]-yData[i]) / numberOfResults;
            }
            return gradient;
        }
        private double Cost(double[] result, List<double> yData)
        {
            double sum = 0.0;
            for (int i = 0; i < result.Length; i++)
            {
                sum +=( yData[i] * Math.Log(result[i])) + ((1 - yData[i]) * Math.Log(1 - result[i]));
            }
            double output = (-1 * sum )/ result.Length;
            return output;
        }
        private double _Bias;
        private List<double> _Weights;
        private int _NumberOfFeatures;
        private double[] _NormalizerVector;
    }
}
