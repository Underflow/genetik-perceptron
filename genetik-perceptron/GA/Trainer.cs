using System;
using System.Collections.Generic;

namespace genetikperceptron
{
	public class Trainer
	{
		public DNA best { get; private set; }
		private Random r = new Random();
		private List<DNA> population;
		private IEvaluator evaluator;
		
		public Trainer(int nb_inputs, int[] nb_neurons_layer, int population_size, IEvaluator evaluator)
		{
			this.population = new List<DNA>();
			for(int i = 0; i < population_size; i++)
			{
				this.population.Add (new DNA(nb_inputs, nb_neurons_layer));
			}
			this.evaluator = evaluator;
		}
		
		public Trainer (List<DNA> population, IEvaluator evaluator)
		{
			this.population = population;
			this.evaluator = evaluator;
		}
		
		public void Train()
		{
			evaluator.Evaluate(population);
			population.Sort ();
			best = population[0];
			this.GangBang();
			foreach(DNA dna in population)
				dna.Mutate (.10f);
		}
		
		private DNA PickGoodDNA()
		{
			foreach(DNA dna in population)
			{
				if(r.Next(100) < 50)
				{
					return dna;	
				}
			}
			return population[0];
		}
		
		private void GangBang()
		{
			List<DNA> new_population = new List<DNA>();
			for(int i = 0; i < population.Count; i++)
			{
				new_population.Add (PickGoodDNA().Crossover(this.PickGoodDNA()));
			}
			this.population = new_population;
		}
	}
}

