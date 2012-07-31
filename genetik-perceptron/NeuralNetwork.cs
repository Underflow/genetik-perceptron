using System;
using System.Collections.Generic;

namespace genetikperceptron
{
	public class NeuralNetwork
	{
		private List<List<Neuron>> layers = new List<List<Neuron>>();
		
		public NeuralNetwork (int nb_layers, List<Tuple<Neuron, int>> neurons)
		{
			for(int i = 0; i < nb_layers; i++)
				layers.Add (new List<Neuron>());
			
			foreach(Tuple<Neuron, int> neuron in neurons)
			{
				if(neuron.Item2 > 0 && neuron.Item2 < nb_layers)
					layers[neuron.Item2].Add(neuron.Item1);
				else
					throw new Exception("This layer isn't defined !");
			}
		}
			
		public void Process(List<double> input)
		{
			foreach(List<Neuron> layer in layers)
			{
				List<double> next_input = new List<double>();
				foreach(Neuron neuron in layer)
				{
					next_input.Add(neuron.Output(input));
				}
				input = next_input;
			}
		}
	}
}

