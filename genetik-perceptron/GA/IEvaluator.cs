using System;
using genetikperceptron.NN;

namespace genetikperceptron.GA
{
	public interface IEvaluator
	{
		double FitnessFunction(NeuralNetwork neural_network);
	}
}

