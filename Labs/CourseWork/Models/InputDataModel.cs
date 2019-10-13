using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
	public class InputDataModel
	{
		public int Id { get; set; }
		public int TrainingPatterns { get; set; }
		public int NumOfClusters { get; set; }

		public int Parameters { get; set; }
		public double[][] Inputs { get; set; }
		public double[][] Answers { get; set; }
	}
}
