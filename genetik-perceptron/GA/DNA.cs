using System;
using System.Collections.Generic;

namespace genetikperceptron
{
	public class DNA : IComparable<DNA>
	{
		public double fitness { get; set; }
		
		private double[] content;
		private int[] nb_neurons_layer;
		private int nb_inputs;
		private int nb_layers;
		private static Random r = new Random();
		
		public int CompareTo(DNA other)
		{
			return other.fitness.CompareTo(this.fitness);	
		}
		
		public DNA(int nb_inputs, int[] nb_neurons_layer)
		{
			this.nb_neurons_layer = nb_neurons_layer;
			this.nb_inputs = nb_inputs;
			this.nb_layers = nb_neurons_layer.GetLength(0);
			Randomize();
		}
		
		public DNA(int nb_inputs, int[] nb_neurons_layer, double[] content)
		{
			this.nb_neurons_layer = nb_neurons_layer;
			this.nb_inputs = nb_inputs;
			this.nb_layers = nb_neurons_layer.GetLength(0);
			this.content = content;
		}
		
		public void Mutate(double probability)
		{
			for(int i = 0; i < content.GetLength(0); i++)
			{
				if(r.NextDouble() < probability)
				{
					content[i] = (r.NextDouble() - 0.5f) * 20;
				}
			}
		}
		
		public DNA Crossover(DNA parrent)
		{
			double[] child_content = new double[content.GetLength(0)];
			for(int i = 0; i < content.GetLength(0); i++)
			{
				child_content[i] = r.Next(2) == 0 ? this.content[i] : parrent.content[i];
			}
			return new DNA(nb_inputs, nb_neurons_layer, child_content);
		}
		
		public void Randomize()
		{
			List<double> weights = new List<double>();
			int nb_inputs = this.nb_inputs;
			for(int layer = 0; layer < nb_layers; layer++)
			{
				int next_nb_inputs = 0;
				for(int neuron = 0; neuron < nb_neurons_layer[layer]; neuron++)
				{
					for(int input = 0; input < nb_inputs; input++)
					{
						weights.Add ((r.NextDouble() - 0.5f) * 20);	
					}
					weights.Add ((r.NextDouble() - 0.5f) * 20);
					next_nb_inputs ++;
				}
				nb_inputs = next_nb_inputs;
			}
			content = weights.ToArray ();
		}
		
		public NeuralNetwork Translate()
		{
			List<Tuple<Neuron, int>> structure = new List<Tuple<Neuron, int>>();
			
			int n = 0;
			int nb_inputs = this.nb_inputs;
			for(int layer = 0; layer < nb_layers; layer++)
			{
				int next_nb_inputs = 0;
				for(int neuron = 0; neuron < nb_neurons_layer[layer]; neuron++)
				{
					List<double> inputs = new List<double>();
					for(int input = 0; input < nb_inputs; input++)
					{
						inputs.Add (this.content[n]);
						n++;
					}
					structure.Add (Tuple.Create (new Neuron(inputs, this.content[n]), layer));
					n++;
					next_nb_inputs++;
				}
				nb_inputs = next_nb_inputs;
			}
			return new NeuralNetwork(nb_layers,structure);
		}
	}
}

