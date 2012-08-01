using System;
using System.Collections.Generic;
using genetikperceptron.NN;
using genetikperceptron.GA;

namespace genetikperceptron
{
	class MainClass
	{
		public static void Main (string[] args)
		{			
			Trainer trainer = new Trainer(2, new int[] {1,2}, 20, new Simulation());
			trainer.Train ();
		}
	}
}
