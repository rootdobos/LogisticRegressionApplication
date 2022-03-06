using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LogisticRegressionController
{
    public static class XMLReaderWritter
    {
        public static void WriteModel(string path, int numberOfFeatures, List<double> weights, double bias, double[] normalizerVector)
        {
            XmlWriterSettings sts = new XmlWriterSettings();
            sts.Indent = true;

            using (XmlWriter writer = XmlWriter.Create(path, sts))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("model");

                writer.WriteStartElement("numberOfFeatures");
                writer.WriteString(numberOfFeatures.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("weights");
                for (int i = 0; i < weights.Count; i++)
                {
                    writer.WriteStartElement("w" + i.ToString());
                    writer.WriteString(weights[i].ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                writer.WriteStartElement("bias");
                writer.WriteString(bias.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("normalizer");
                for (int i = 0; i < normalizerVector.Length; i++)
                {
                    writer.WriteStartElement("n" + i.ToString());
                    writer.WriteString(normalizerVector[i].ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
        public static void ReadModel(string path, ref int numberOfFeatures, ref List<double> weights, ref double bias, ref double[] normalizerVector)
        {
            using (XmlReader reader = XmlReader.Create(path))
            {
                reader.MoveToContent();
                while (reader.Read())
                {
                    reader.MoveToContent();
                    switch (reader.Name)
                    {
                        case "numberOfFeatures":
                            numberOfFeatures = ReadNOF(reader);
                            break;
                        case "weights":
                            weights = ReadWeights(reader);
                            break;
                        case "bias":
                            bias = ReadBias(reader);
                            break;
                        case "normalizer":
                            normalizerVector = ReadNormalizer(reader, numberOfFeatures);
                            break;
                    }
                    reader.Read();
                }
            }
        }
        private static int ReadNOF(XmlReader reader)
        {
            reader.Read();
            return int.Parse(reader.Value);
        }
        private static List<double> ReadWeights(XmlReader reader)
        {
            List<double> output = new List<double>();
            while(reader.Read())
            {
                if (reader.Name == "weights" && !reader.IsStartElement())
                    break;
                if (reader.Name != "weights" && reader.IsStartElement())
                {
                    reader.Read();
                    output.Add(double.Parse(reader.Value));
                    reader.Read();
                }
                reader.Read();
            }
            return output;
        }
        private static double ReadBias(XmlReader reader)
        {
            reader.Read();
            return double.Parse(reader.Value);
        }
        private static double[] ReadNormalizer(XmlReader reader, int length)
        {
            double[] output = new double[length];
            int i = 0;
            while (reader.Read())
            {
                if (reader.Name == "normalizer" && !reader.IsStartElement())
                    break;
                if (reader.Name != "normalizer" && reader.IsStartElement())
                {
                    reader.Read();
                    output[i]=(double.Parse(reader.Value));
                    i++;
                    reader.Read();
                }
                reader.Read();
            }
            return output;
        }
    }
}
