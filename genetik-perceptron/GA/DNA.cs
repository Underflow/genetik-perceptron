using System;
using genetikperceptron.NN;
using System.Collections.Generic;

namespace genetikperceptron.GA.Genome
{
	public class DNA
	{
		private double[] content;
		private int[] layer_neurons;
		
		
		public DNA(int[] layer_neurons)
		{
			this.layer_neurons = layer_neurons;
			Randomize();
		}
		
		public void Randomize()
		{
			List<double> weights = new List<double>();
			//Randomize weights
			content = weights.ToArray ();
		}
		
		public NeuralNetwork Translate()
		{
			int nb_layers = layer_neurons.GetLength(0);
			List<Tuple<Neuron, int>> structure = new List<Tuple<Neuron, int>>();
			//Create structure from content[]
			return new NeuralNetwork(nb_layers,structure);
		}
	}
}

