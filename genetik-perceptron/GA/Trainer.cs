using System;
using genetikperceptron.GA;
using System.Collections.Generic;

namespace genetikperceptron.GA
{
	public class Trainer
	{
		private List<DNA> population;
		private IEvaluator evaluator;
		
		public Trainer (List<DNA> population, IEvaluator evaluator)
		{
			this.population = population;
			this.evaluator = evaluator;
		}
		
		public void Train()
		{
			
		}
	}
}

