using System;
using genetikperceptron.GA;
using System.Collections.Generic;
using genetikperceptron.NN;

namespace genetikperceptron
{
	public class Simulation : IEvaluator
	{
		public Simulation (string path)
		{
		}
		
		public void Evaluate(List<DNA> population)
		{
			foreach(DNA dna in population)
			{
				dna.fitness = 0;
				NeuralNetwork nn = dna.Translate ();
				int n = 0;
				for(int i = -20; i < 20 ; i++)
				{
					for(int j = -20; j < 20; j++)
					{
						double nnresult = nn.Process(new List<double>(new double[] {i,j}))[0];
						dna.fitness += (nnresult > 0) == (i > 0) ^ (j > 0) ? 1 : 0;
						n++;
					}
				}
				dna.fitness = dna.fitness / n * 100;
			}
		}
	}
}

