using System;
using genetikperceptron.GA;
using System.Collections.Generic;
using genetikperceptron.NN;

namespace genetikperceptron
{
	public class Simulation : IEvaluator
	{
		private Random r = new Random();
		public Simulation (string path)
		{
		}
		
		public void Evaluate(List<DNA> population)
		{
			foreach(DNA dna in population)
			{
				dna.fitness = 0;
				NeuralNetwork nn = dna.Translate ();
				int n;
				for(n = 0; n < 1000; n++)
				{
						int i = this.r.Next (int.MinValue, int.MaxValue);
						int j = this.r.Next (int.MinValue, int.MaxValue);
						double nnresult = nn.Process(new List<double>(new double[] {i, j}))[0];
						dna.fitness += (nnresult > 0) == (i > 0) ^ (j > 0) ? 1 : 0;
				}
				dna.fitness = dna.fitness / n * 100;
			}
		}
	}
}

