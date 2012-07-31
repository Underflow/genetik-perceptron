using System;

namespace genetikperceptron.GA.Training
{
	public interface IFitnessEvaluator<T>
	{
		double FitnessFunction(Dna<T> DNA);
	}
}

