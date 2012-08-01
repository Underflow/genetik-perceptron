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
			Console.WriteLine("Neural XOR - Test of neural network implementation and DNA translation");
			Console.WriteLine ("----------------------------------------------------------------------");
			Console.WriteLine ("DNA Content : [1,0,1,1,1,2,0,1,1,1,-2,1,1]");
			Console.WriteLine ();
			double[] dna_content = new double[] {1, 0, 1, 1, 1, 2, 0, 1, 1, 1, -2, 1, 1};
			DNA dna = new DNA(2, new int[] {3,1}, dna_content);
			NeuralNetwork nn = dna.Translate ();
			Console.WriteLine ("");
			Console.WriteLine("Please input the first digit:");
			int x = 0;
			int.TryParse(Console.ReadLine ().ToString (), out x);
			Console.WriteLine("Please input the second digit:");
			int y = 0;
			int.TryParse(Console.ReadLine().ToString (), out y);
			Console.WriteLine ("------");
			Console.WriteLine ("Result of network : {0} XOR {1} = {2}", x >= 1, y >= 1, nn.Process (new List<double>(new double[]{x,y}))[0]);

		}
	}
}
