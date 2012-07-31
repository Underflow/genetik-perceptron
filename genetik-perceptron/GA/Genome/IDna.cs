using System;
using genetikperceptron.NN;

namespace genetikperceptron.GA.Genome
{
	public interface IDna<T>
	{
		IDna<T> Crossover(IDna<T> other_dna);
		T Translate();
	}
}

