using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CourseWork.Models;
using System.Globalization;

namespace CourseWork.Services
{
	public class CsvReader
	{
		public string FilePath { get; private set; }
		private const int fieldsCount = 6;
		private const int NuOfClusters = 3;
		private const int parameters = 5;
        public string CurrentUICulture { get; private set; }
	
		private string[] allLines;

		public InputDataModel model { get; private set; }

		public string[] Data { get; private set; }
		public CsvReader(string filePath, string currentCulture)
		{
			FilePath = filePath;
			model = new InputDataModel();
            CurrentUICulture = currentCulture;
		}

		public void ParseAll()
		{
			try
			{
				this.allLines = File.ReadAllLines(FilePath);
				model.TrainingPatterns = allLines.Count()-1;
			}
			catch (Exception ex)
			{
				throw ex;
			}

			double[][] inputs = new double[allLines.Length-1][];
			double[][] answers = new double[allLines.Length-1][];

			try
			{
                var firstLine = allLines[0].Split(new char[] { ',', ';' });
                if(firstLine.Length != fieldsCount)
                    throw new ArgumentException("fields count in file must be " + fieldsCount);
                if (!firstLine.All(str =>
                {
                    if (str.Equals("c") || str.Equals("h") || str.Equals("o")
                    || str.Equals("n") || str.Equals("s") || str.Equals("type"))
                        return true;
                    else return false;
                })) throw new ArgumentException("errors in header file");
              
                for (int i = 1; i < allLines.Length; i++)
				{
					string[] fields = allLines[i].Split(new char[] { ',', ';' });
					if (fields.Length != fieldsCount)
						throw new ArgumentException("fields count in file must be " + fieldsCount);
					inputs[i-1] = new double[fieldsCount - 1];
					answers[i-1] = new double[1];

					inputs[i-1] = ParseKerogen(fields, out answers[i-1][0]);

				}
			}
			catch(Exception ex)
			{
				throw ex;
			}

			model.NumOfClusters = NuOfClusters;
			model.Inputs = inputs;
            model.Answers = answers;
			model.BpnAnswers = TransformAnswers(answers);
			model.Parameters = parameters;
		}

		private double[] ParseKerogen(string[] kerogen, out double answer)
		{
			double[] input = new double[kerogen.Length-1];

			for (int i = 0; i < (kerogen.Count() - 1); i++)
			{
				var field = kerogen[i].Trim();
				bool res = Double.TryParse(field, NumberStyles.Any, CultureInfo.InvariantCulture, out input[i]);
				if (res == false)
					throw new ArgumentException("invalid double parsing");
			}

			bool res2 = Double.TryParse(kerogen[kerogen.Length-1], NumberStyles.Any, CultureInfo.InvariantCulture, out answer);
			if(res2 == false)
				throw new ArgumentException("invalid double parsing");

			return input;
		}

        private double[][] TransformAnswers(double[][] answers)
        {
            double[][] update = new double[answers.GetUpperBound(0)+1][];

            for(int i = 0; i < answers.GetUpperBound(0) + 1; i++)
            {
                update[i] = new double[NuOfClusters];

                for(int j = 0; j < update[i].Length; j++)
                {
                    update[i][j] = 0.0;
                }

                update[i][(int)answers[i][0] - 1] = 1; 

            }

            return update;
        }


	}

}
