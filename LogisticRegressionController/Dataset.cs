using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticRegressionController
{
    public class Dataset
    {
        public List<double[]> XData
        {
            get { return _XData; }
        }
        public List<double> YData
        {
            get { return _YData; }
        }
        public string[] Header
        {
            get { return _Header; }
            set { _Header = value; }
        }
        public List<string[]> DataStrings
        {
            get { return _RawLines; }
        }
        public double[] Maximums
        {
            get { return _Maximums; }
            set { _Maximums = value; }
        }
        public Dataset()
        {
            _XData = new List<double[]>();
            _YData = new List<double>();
            _RawLines = new List<string[]>();
            _Maximums = null;
            _Normalized = false;
        }
        public void AddXLine(double[] dataValues)
        {
            _XData.Add(dataValues);
            if (_Maximums==null)
            {
                _Maximums = new double[dataValues.Length];
                for(int i = 0;i < _Maximums.Length;i++)
                    _Maximums[i] = 0.0;
            }
            for (int i = 0; i < _Maximums.Length; i++)
            {
                if (_Maximums[i] < dataValues[i])
                    _Maximums[i] = dataValues[i];
            }
        }
        public void Normalize()
        {
            if(!_Normalized)
            {
                for(int i=0;i<_XData.Count;i++)
                {
                    for (int j = 0; j < _XData[i].Length; j++)
                        _XData[i][j] /= _Maximums[j];
                }
                _Normalized = true;
            }
        }
        public void Denormalize()
        {
            if (_Normalized)
            {
                for (int i = 0; i < _XData.Count; i++)
                {
                    for (int j = 0; j < _XData[i].Length; j++)
                        _XData[i][j] *= _Maximums[j];
                }
                _Normalized = false;
            }
        }
        public static Dataset[] KFoldBuckets(Dataset datasetInput, int folds)
        {
            Dataset dataset = ShuffleDataset(DataDeepCopy(datasetInput));
            Dataset[] buckets = new Dataset[folds];
            for(int i=0;i< folds;i++)
                buckets[i] = new Dataset();
            int elementNb = (int)Math.Ceiling((double)dataset.XData.Count / folds);
            for(int i=0;i< dataset.XData.Count;i++)
            {
                buckets[i / elementNb].XData.Add(dataset.XData[i]);
                buckets[i / elementNb].YData.Add(dataset.YData[i]);
                buckets[i / elementNb]._RawLines.Add(dataset._RawLines[i]);
            }
            return buckets;
        }
        public static Dataset ShuffleDataset(Dataset dataset)
        {
            Dataset shuffled = new Dataset();
            shuffled._Header = dataset._Header;
            shuffled._Maximums = dataset._Maximums;
            shuffled._XData = new List<double[]>();
            shuffled._YData = new List<double>();
            shuffled._RawLines = new List<string[]>();
            var rand = new Random();
            while(dataset.XData.Count>0)
            {
                int nextIndex = rand.Next(dataset.XData.Count);
                shuffled.XData.Add(dataset.XData[nextIndex]);
                shuffled.YData.Add(dataset.YData[nextIndex]);
                shuffled._RawLines.Add(dataset._RawLines[nextIndex]);

                dataset.XData.RemoveAt(nextIndex);
                dataset.YData.RemoveAt(nextIndex);
                dataset._RawLines.RemoveAt(nextIndex);
            }
            return shuffled;
        }
        public static string[] ConvertDoubleArrayToStringArray(double[] input)
        {
            string[] output = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
                output[i] = input[i].ToString();
            return output;
        }
        public static double[] NormalizeArray(double[] input, double[] normalizer)
        {
            double[] output =new double[input.Length];
            for (int j = 0; j < input.Length; j++)
                output[j] = input[j]/ normalizer[j];
            return output;
        }
        public static Dataset DataDeepCopy(Dataset dataset)
        {
            Dataset output = new Dataset();
            output._Header = dataset._Header;
            output._Maximums = dataset._Maximums;
            for (int i = 0; i < dataset.XData.Count;i++)
            {
                double[] copy = new double[dataset.XData[i].Length];
                for (int j = 0; j < dataset.XData[i].Length; j++)
                    copy[j] = dataset.XData[i][j];
                output.XData.Add(copy);
                output.YData.Add(dataset.YData[i]);
                string[] stringCopy = new string[dataset._RawLines[i].Length];
                for (int j = 0; j < dataset._RawLines[i].Length; j++)
                    stringCopy[j] = dataset._RawLines[i][j];
                output._RawLines.Add(stringCopy);
            }
            return output;
        }

        List<double[]> _XData;
        List<double> _YData;
        List<string[]> _RawLines;
        string[] _Header;
        double[] _Maximums;
        bool _Normalized;
    }
}
