using System;

namespace genetikperceptron.GA.Training
{
	public class GeneticTrainer<T>
	{
		private IFitnessEvaluator<T> fitness_evaluator;
		public GeneticTrainer (IFitnessEvaluator<T> fitness_evaluator)
		{
			this.fitness_evaluator = fitness_evaluator;
		}
	}
}

