using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
	
	public class MinMax
	{
		Random rnd = new Random();

		public Dictionary<int, double> normalization;

		private Dictionary<int, double> Normalization
		{
			get
			{
				return normalization;
			}
			set
			{
				normalization = value;
			}
		}

		private List<int> dataset;
		public List<int> Dataset
		{
			get
			{
				return dataset;
			}
			set
			{
				dataset = value;
			}
		}
		private int _Min { get; set; }
		private int _Max { get; set; }

		public List<int> ProduceValue(int Min,int Max)
		{
			if(dataset == null)
			{
				dataset = new List<int>();
			}
			_Min = Min;
			_Max = Max;
			
			for (int i = 0; i <= 500; i++)
			{
				int random = rnd.Next(_Min, _Max);
				if (dataset.Contains(random))
				{
					continue;
				}
				dataset.Add(random);			
			}
			return dataset;
		}

		public void Calculate()
		{
			normalization = new Dictionary<int, double>();
			double ort;
			foreach (var item in dataset)
			{
				double share = item - _Min;
				double denominator = _Max - _Min;
				ort = share / denominator;
				normalization.Add(item, ort);
			}	
		}
	}
}
