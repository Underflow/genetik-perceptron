using System;
using System.Collections.Generic;

namespace genetikperceptron
{
	public class NeuralNetwork
	{
		private List<NeuronLayer> layers = new List<NeuronLayer>();
		
		public NeuralNetwork ()
		{
		
		}
		
		public void AddNeuron(Neuron neuron, int layer)
		{
			if(layer > layers.Count - 1)
				throw new Exception("This layer doesn't exist");
		}
	}
}

