using System;
using genetikperceptron.GA;
using System.Collections.Generic;

namespace genetikperceptron
{
	public class Simulation : IEvaluator
	{
		Random r;
		public Simulation ()
		{
			this.r = new Random();
		}
		
		public void Evaluate(List<DNA> population)
		{
			foreach(DNA dna in population)
			{
				dna.fitness = r.NextDouble() * 100;
			}
		}
	}
}

