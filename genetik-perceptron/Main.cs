using System;
using System.Collections.Generic;
using genetikperceptron.NN;
using genetikperceptron.GA;
using System.Threading;

namespace genetikperceptron
{
	class MainClass
	{
		public static void Main (string[] args)
		{			
			Trainer trainer = new Trainer(2, new int[] {3, 3, 3, 1}, 20, new Simulation(""));
			do
			{
				trainer.Train ();
				Console.WriteLine ("Best fitness : {0}%", trainer.best.fitness);
			}  while(trainer.best.fitness < 99.5f);
		}
	}
}
