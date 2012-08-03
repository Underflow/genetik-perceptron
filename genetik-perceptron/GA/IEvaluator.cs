using System;
using System.Collections.Generic;

namespace genetikperceptron
{
	public interface IEvaluator
	{
		void Evaluate(List<DNA> population);
	}
}

