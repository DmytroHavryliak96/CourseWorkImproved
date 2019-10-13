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
		private const int NuOfClusters = 4;
		private const int parameters = 5;
	
		private string[] allLines;

		public InputDataModel model { get; private set; }

		public string[] Data { get; private set; }
		public CsvReader(string filePath)
		{
			FilePath = filePath;
			model = new InputDataModel();
		}

		public void ParseAll()
		{
			try
			{
				this.allLines = File.ReadAllLines(FilePath);
				model.TrainingPatterns = allLines.Count();
			}
			catch (Exception ex)
			{
				throw ex;
			}

			double[][] inputs = new double[allLines.Length][];
			double[][] answers = new double[allLines.Length][];

			try
			{
				for (int i = 0; i < allLines.Length; i++)
				{
					string[] fields = allLines[i].Split(',');
					if (fields.Length != fieldsCount)
						throw new ArgumentException("fields count in file must be " + fieldsCount);
					inputs[i] = new double[fieldsCount - 1];
					answers[i] = new double[1];

					inputs[i] = ParseKerogen(fields, out answers[i][0]);

				}
			}
			catch(Exception ex)
			{
				throw ex;
			}

			model.NumOfClusters = NuOfClusters;
			model.Inputs = inputs;
			model.Answers = answers;
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
	}
}
