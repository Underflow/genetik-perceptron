using System;
using System.Collections.Generic;

namespace genetikperceptron.NN
{

	public class Neuron
	{
		public double last_output {get; private set;}
		private double treeshold;
		private List<double> input_weights;
		
		public Neuron(List<double> input_weights, double treeshold)
		{
			this.treeshold = treeshold;
			this.input_weights = input_weights;	
		}
		
		public double Output(List<double> inputs)
		{
			if(input_weights.Count != inputs.Count)
				throw new Exception("Wrong input vector length");
			
			double sum = 0f;
			for(int i = 0; i < inputs.Count; i++)
				sum += inputs[i] * input_weights[i];
			
			last_output = sum >= treeshold ? 1 : 0;
			return last_output;
		}
	}
}

