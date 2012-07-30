using System;
using System.Collections.Generic;

namespace genetikperceptron
{
	public class NeuronLayer
	{
		public List<Neuron> neurons {get; private set;}
		
		public NeuronLayer()
		{
			neurons = new List<Neuron>();	
		}
		
		public void AddNeuron(Neuron neuron)
		{
			neurons.Add (neuron);
		}
		
	}
}

