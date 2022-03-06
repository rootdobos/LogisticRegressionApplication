using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticRegressionController
{
    public class Evaluator
    {
        public int TruePositive;
        public int TrueNegative;
        public int FalsePositive;
        public int FalseNegative;

        public double Accuracy
        { get { return NANCheck(((double)TruePositive + TrueNegative) / Total()); } }
        public double Precision
        { get { return NANCheck((double)TruePositive / (TruePositive + FalsePositive)); } }
        public double TruePositiveRate
        { get { return Recall; } }
        public double FalsePositiveRate
        { get { return NANCheck((double)FalsePositive / (FalsePositive + TrueNegative)); } }
        public double Recall
        { get { return NANCheck((double)TruePositive / (TruePositive + FalseNegative)); } }
        public double Specificity
        { get { return NANCheck((double)TrueNegative / (FalsePositive + TrueNegative)); } }
        public double F1Score
        { get { return NANCheck((2.0 * TruePositive) / ((2.0 * TruePositive)+ FalsePositive + FalseNegative)); } }

        public Evaluator()
        {
            TruePositive = 0;
            TrueNegative = 0;
            FalseNegative = 0;
            FalsePositive = 0;
        }
        private double Total()
        {
            return (double)TruePositive + TrueNegative + FalsePositive + FalseNegative;
        }
        private double NANCheck(double input)
        {
            if (double.IsNaN(input))
                return 0;
            else
                return input;
        }
    }
}
