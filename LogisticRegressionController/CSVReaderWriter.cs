using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogisticRegressionController
{
    public static class CSVReaderWriter
    {
        static public Dataset ReadCSV(string path, bool includedOutput, bool header=true)
        {
            Dataset output = new Dataset();
            using (StreamReader reader = new StreamReader(path))
            {
                if(header)
                {
                    string line = reader.ReadLine();
                    string[] headerElements = line.Split(',');
                    output.Header = headerElements;
                }
                while(!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] data = line.Split(',');
                    output.DataStrings.Add(data);
                    double[] dataValues;
                    if (includedOutput)
                    {
                        dataValues = new double[data.Length - 1];
                        string y = data[data.Length - 1];
                        output.YData.Add(double.Parse(y));
                    }
                    else
                        dataValues = new double[data.Length];
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (includedOutput && i == data.Length - 1)
                            continue;
                        string processedString = data[i];
                        if (processedString != "")
                        {
                            dataValues[i] = double.Parse(processedString);
                        }
                        else
                        {
                            dataValues[i] = 0.0;
                        }
                    }
                    output.AddXLine(dataValues);
                }
            }
            return output;
        }
        static public void WriteCSV(string path, Dataset outputData)
        {

        }
    }
}
