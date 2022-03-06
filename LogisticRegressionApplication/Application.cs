using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LogisticRegressionController;
using System.Threading;

namespace LogisticRegressionApplication
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }

        private void tb_InputPath_TextChanged(object sender, EventArgs e)
        {
            if(File.Exists(tb_InputPath.Text))
            {
                dgv_VisualizedData.Rows.Clear();
                _trainData = CSVReaderWriter.ReadCSV(tb_InputPath.Text, true);
                dgv_VisualizedData.ColumnCount = _trainData.Header.Length;
                dgv_VisualizedData.ColumnHeadersVisible = true;
                for (int i = 0; i < _trainData.Header.Length; i++)
                    dgv_VisualizedData.Columns[i].Name = _trainData.Header[i];

                foreach(string[] values in _trainData.DataStrings)
                {
                    dgv_VisualizedData.Rows.Add(values);
                }
            }
        }
        private void bt_train_Click(object sender, EventArgs e)
        {
            _Model = new LogisticRegressionModel(_trainData.XData[0].Length);
            double normalizedLearningRate = double.Parse(tb_LearningRate.Text) / Math.Pow(10, 3);
            _ChartDatas = new LiveCharts.ChartValues<LiveCharts.Defaults.ObservableValue>[1];
            _ChartDatas[0] = new LiveCharts.ChartValues<LiveCharts.Defaults.ObservableValue>();
            var chartSeries = new LiveCharts.Wpf.LineSeries()
            {
                Title = "Loss",
                Values = _ChartDatas[0]
            };
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();
            cartesianChart1.Update();
            cartesianChart1.Series.Add(chartSeries);

            _Model.UpdateLossEvent += UpdateLossChart;
            _Model.Fit(_trainData,normalizedLearningRate , int.Parse(tb_Iterations.Text));
            _Model.UpdateLossEvent -= UpdateLossChart;
            cartesianChart1.Zoom = LiveCharts.ZoomingOptions.Xy;
        }
        private void bt_KFold_Click(object sender, EventArgs e)
        {
            _FoldNumber = int.Parse(tb_Folds.Text);
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();
            _Model = new LogisticRegressionModel(_trainData.XData[0].Length);
            double normalizedLearningRate = double.Parse(tb_LearningRate.Text) / Math.Pow(10, 3);
            _ChartDatas = new LiveCharts.ChartValues<LiveCharts.Defaults.ObservableValue>[_FoldNumber+1];
            for (int i = 0; i < _FoldNumber; i++)
            {
                _ChartDatas[i] = new LiveCharts.ChartValues<LiveCharts.Defaults.ObservableValue>();
                var chartSeries = new LiveCharts.Wpf.LineSeries()
                {
                    Title = i.ToString()+ " Fold",
                    Values = _ChartDatas[i]
                };
                cartesianChart1.Series.Add(chartSeries);
            }
            _ChartDatas[_FoldNumber] = new LiveCharts.ChartValues<LiveCharts.Defaults.ObservableValue>();
            var chartSeriesAvg = new LiveCharts.Wpf.LineSeries()
            {
                Title ="Average",
                Values = _ChartDatas[_FoldNumber]
            };
            cartesianChart1.Series.Add(chartSeriesAvg);
            _Model.UpdateLossEvent += UpdateLossChart;
            _Model.CrossValidation(_trainData, normalizedLearningRate, int.Parse(tb_Iterations.Text), _FoldNumber);
            _Model.UpdateLossEvent -= UpdateLossChart;
            for(int i=0;i<_ChartDatas[0].Count;i++)
            {
                double avg = 0;
                for (int j = 0; j < _FoldNumber; j++)
                    avg += _ChartDatas[j][i].Value;
                LiveCharts.Defaults.ObservableValue dataPoint = new LiveCharts.Defaults.ObservableValue(avg/_FoldNumber);
                _ChartDatas[_FoldNumber].Add(dataPoint);
            }
            cartesianChart1.Zoom = LiveCharts.ZoomingOptions.Xy;
        }
        private void UpdateLossChart(object sender, LossEventArgs e)
        {
            LiveCharts.Defaults.ObservableValue dataPoint = new LiveCharts.Defaults.ObservableValue();
            if (e.Fold == -1)
                _ChartDatas[0].Add(dataPoint);
            else
            {
                _ChartDatas[e.Fold].Add(dataPoint);
            }
            dataPoint.Value = e.Loss;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(tb_testDataPath.Text))
            {
                _Evaluator = new Evaluator();
                _testData = CSVReaderWriter.ReadCSV(tb_testDataPath.Text,true);
                dgv_VisualizedData.Rows.Clear();
                dgv_VisualizedData.ColumnCount = _testData.Header.Length;
                dgv_VisualizedData.ColumnHeadersVisible = true;
                for (int i=0;i<_testData.Header.Length;i++)
                {
                    dgv_VisualizedData.Columns[i].Name = _testData.Header[i];
                }
                dgv_VisualizedData.Columns[_testData.Header.Length-1].Name = "Prediction";
                for(int i=0;i<_testData.XData.Count;i++)
                {
                    double result = _Model.Predict(_testData.XData[i]);
                    double[] inputAndPrediction = new double[_testData.XData[i].Length + 1];
                    for (int j = 0; j < _testData.XData[i].Length; j++)
                        inputAndPrediction[j] = _testData.XData[i][j];
                    inputAndPrediction[_testData.XData[i].Length] = result;
                    string[] stringResult = Dataset.ConvertDoubleArrayToStringArray(inputAndPrediction);
                    dgv_VisualizedData.Rows.Add(stringResult);
                    if(_testData.YData.Count>0)
                    {
                        double reference = _testData.YData[i];
                        if (reference == 1)
                        {
                            if (result > 0.5)
                            {
                                dgv_VisualizedData.Rows[dgv_VisualizedData.Rows.Count - 2].Cells[_testData.XData[i].Length].Style.BackColor = Color.Green;
                                _Evaluator.TruePositive++;
                            }
                            else
                            {
                                dgv_VisualizedData.Rows[dgv_VisualizedData.Rows.Count - 2].Cells[_testData.XData[i].Length].Style.BackColor = Color.Red;
                                _Evaluator.FalseNegative++;
                            }
                        }
                        if (reference == 0)
                        {
                            if (result < 0.5)
                            {
                                dgv_VisualizedData.Rows[dgv_VisualizedData.Rows.Count - 2].Cells[_testData.XData[i].Length].Style.BackColor = Color.Green;
                                _Evaluator.TrueNegative++;
                            }
                            else
                            {
                                dgv_VisualizedData.Rows[dgv_VisualizedData.Rows.Count - 2].Cells[_testData.XData[i].Length].Style.BackColor = Color.Red;
                                _Evaluator.FalsePositive++;
                            }
                        }
                    }
                }
                ShowMeasures();
            }
        }

        private void bt_ROCCURVE_Click(object sender, EventArgs e)
        {
            if (File.Exists(tb_testDataPath.Text))
            {         
                _testData = CSVReaderWriter.ReadCSV(tb_testDataPath.Text, true);
                double[] result= new double[_testData.XData.Count];
                for (int i = 0; i < _testData.XData.Count; i++)
                {
                    result[i] = _Model.Predict(_testData.XData[i]);
                }
                //var series = new LiveCharts.Wpf.ScatterSeries
                //{
                //    Title = "ROC",
                //    Values = new LiveCharts.ChartValues<LiveCharts.Defaults.ObservablePoint>(),
                //    PointGeometry = LiveCharts.Wpf.DefaultGeometries.Circle
                //};
                var series = new LiveCharts.Wpf.LineSeries()
                {
                    Title = "ROC Curve",
                    Values = new LiveCharts.ChartValues<LiveCharts.Defaults.ObservablePoint>()
                };
                cartesianChart1.Series.Clear();
                cartesianChart1.AxisX.Clear();
                if (_testData.YData.Count > 0)
                {
                    for (int k=0;k<100; k++)
                    {
                        Evaluator evaluator = new Evaluator();
                        for (int i = 0; i < _testData.XData.Count; i++)
                        {
                            double reference = _testData.YData[i];
                            if (reference == 1)
                            {
                                if (result[i] > 1.0/k)
                                {
                                    evaluator.TruePositive++;
                                }
                                else
                                {
                                    evaluator.FalseNegative++;
                                }
                            }
                            if (reference == 0)
                            {
                                if (result[i] < 1.0 / k)
                                {
                                    evaluator.TrueNegative++;
                                }
                                else
                                {
                                    evaluator.FalsePositive++;
                                }
                            }
                        }
                        series.Values.Add(new LiveCharts.Defaults.ObservablePoint(evaluator.FalsePositiveRate, evaluator.TruePositiveRate));
                    }
                    series.Values.Add(new LiveCharts.Defaults.ObservablePoint(1, 1));
                    cartesianChart1.Series.Add(series);
                    CalculateAUC((LiveCharts.ChartValues<LiveCharts.Defaults.ObservablePoint>)series.Values);
                }   
            }
        }

        private void ShowMeasures()
        {
            LiveCharts.Wpf.ColumnSeries columns = new LiveCharts.Wpf.ColumnSeries()
            {
                DataLabels = true,
                Values= new LiveCharts.ChartValues<double>(),
                LabelPoint=point => point.Y.ToString()
            };
            LiveCharts.Wpf.Axis ax = new LiveCharts.Wpf.Axis()
            {
                Separator = new LiveCharts.Wpf.Separator() { Step = 1, IsEnabled = false }
            };
            ax.Labels = new List<string>();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("True Positives: {0}", _Evaluator.TruePositive);
            Console.WriteLine("True Negatives: {0}", _Evaluator.TrueNegative);
            Console.WriteLine("False Positives: {0}", _Evaluator.FalsePositive);
            Console.WriteLine("False Negatives: {0}", _Evaluator.FalseNegative);
            Console.WriteLine("");
            columns.Values.Add(_Evaluator.Accuracy);
            ax.Labels.Add("Accuracy");
            Console.WriteLine("Accuracy: {0}", _Evaluator.Accuracy);
            columns.Values.Add(_Evaluator.Precision);
            ax.Labels.Add("Precision");
            Console.WriteLine("Precision: {0}", _Evaluator.Precision);
            columns.Values.Add(_Evaluator.Recall);
            ax.Labels.Add("Recall");
            Console.WriteLine("Recall: {0}", _Evaluator.Recall);
            columns.Values.Add(_Evaluator.Specificity);
            ax.Labels.Add("Specificity");
            Console.WriteLine("Specificity: {0}", _Evaluator.Specificity);
            columns.Values.Add(_Evaluator.F1Score);
            ax.Labels.Add("F1-Score");
            Console.WriteLine("F1-Score: {0}", _Evaluator.F1Score);
            Console.WriteLine("----------------------------------------------");
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();

            cartesianChart1.Series.Add(columns);
            cartesianChart1.AxisX.Add(ax);


        }
        private void CalculateAUC(LiveCharts.ChartValues<LiveCharts.Defaults.ObservablePoint> points)
        {
            double sumOfAreas = 0.0;
            for(int i=1;i<points.Count;i++)
            {
                double area = ((points[i - 1].Y + points[i].Y) / 2) * (points[i].X - points[i - 1].X);
                sumOfAreas += area;
            }
            Console.WriteLine("Area Under the ROC Curve: {0}", sumOfAreas);
        }
        LogisticRegressionController.Dataset _trainData;
        LogisticRegressionController.Dataset _testData;
        LogisticRegressionModel _Model;
        Evaluator _Evaluator;
        LiveCharts.ChartValues<LiveCharts.Defaults.ObservableValue>[] _ChartDatas;
        int _FoldNumber = 5;
        #region Unused
        private void Application_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        private void bt_Save_Click(object sender, EventArgs e)
        {
            _Model.Save(tb_SaveLoad.Text);
        }

        private void bt_Load_Click(object sender, EventArgs e)
        {
            _Model = LogisticRegressionModel.LoadFromFile(tb_SaveLoad.Text);
        }

        private void bt_learningDataPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                tb_InputPath.Text = openFileDialog1.FileName;
        }

        private void bt_TestPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                tb_testDataPath.Text = openFileDialog1.FileName;
        }

        private void bt_ModelPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                tb_SaveLoad.Text = openFileDialog1.FileName;
        }
    }
}
