using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbrosineNeuralNetwork.Network
{
	public unsafe class NeuronArray
	{
		public int Length => Biases.Length;
		public double this[int index]
		{
			get => _biases[index];
			set => _biases[index] = value;
		}

		public double[] Biases
		{
			get => _biases;
			set => _biases = value;
		}

		public double[] Errors
		{
			get => _errors;
			set => _errors = value;
		}

		private double[] _biases;
		private double[] _errors;

		public void Stimulate(double[] values)
		{

		}
	}
}