using System;
using genetikperceptron.NN;
using System.Collections.Generic;

namespace genetikperceptron.GA
{
	public interface IEvaluator
	{
		void Evaluate(List<DNA> population);
	}
}

