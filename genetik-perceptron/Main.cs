using System;
using System.Collections.Generic;
using genetikperceptron.NN;
using genetikperceptron.GA.Training;
using genetikperceptron.GA.Genome;

namespace genetikperceptron
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<DNA> population = new List<DNA>();	
			DNA test = new DNA(1, new int[] {2,1});
			NeuralNetwork nn = test.Translate ();
			Trainer trainer = new Trainer(population);
			trainer.Train();
		}
		

		/*
		 * NEURAL NETWORK TEST
		public static void Main (string[] args)
		{
			Console.WriteLine("Neural XOR - Test of neural network implementation");
			Console.WriteLine("First digit");
			int x = 0;
			int.TryParse(Console.ReadLine ().ToString (), out x);
			Console.WriteLine("Second digit");
			int y = 0;
			int.TryParse(Console.ReadLine().ToString (), out y);
			List<Tuple<Neuron, int>> structure = new List<Tuple<Neuron, int>>();
			structure.Add (Tuple.Create (new Neuron(new List<double>(new double[]{1.0,0.0}), 1.0f), 1));
			structure.Add (Tuple.Create (new Neuron(new List<double>(new double[]{1.0,1.0}), 2.0f), 1));
			structure.Add (Tuple.Create (new Neuron(new List<double>(new double[]{0.0,1.0}), 1.0f), 1));
			structure.Add (Tuple.Create (new Neuron(new List<double>(new double[]{1.0,-2.0,1.0}), 1.0f), 2));
			NeuralNetwork nn = new NeuralNetwork(2, structure);
			Console.WriteLine ("------");
			Console.WriteLine ("Result of network : {0} XOR {1} = {2}", x >= 1, y >= 1, nn.Process (new List<double>(new double[]{x,y}))[0]);
		}
		*/
		
	}
}
