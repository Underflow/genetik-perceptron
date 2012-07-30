using System;
using System.Collections.Generic;

namespace genetikperceptron
{

	public class Neuron
	{
		public List<double> weights = new List<double>();
		
		public double Output(List<double> inputs)
		{
			if(weights.Count != inputs.Count)
				throw new Exception("Wrong input vector length");
			
			double sum = 0f;
			for(int i = 0; i < inputs.Count; i++)
				sum += inputs[i] + weights[i];
			
			return Sigmoid(sum);
		}
		
		private double Sigmoid(double x)
		{
			return 1 / (1 + Math.Exp(-x));
		}
		
		
	}
}

