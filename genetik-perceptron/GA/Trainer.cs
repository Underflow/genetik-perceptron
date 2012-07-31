using System;
using genetikperceptron.GA.Genome;
using System.Collections.Generic;

namespace genetikperceptron.GA.Training
{
	public class Trainer
	{
		private List<DNA> population;
		
		public Trainer (int population_size)
		{
			this.population = new List<DNA>();
			for(int i = 0; i < population_size; i++)
			{
				this.population.Add (new DNA());
			}
		}
	}
}

