using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbrosineNeuralNetwork.Network
{
	public unsafe class NeuronArray
	{
		public double this[int index]
		{
			get => _neurons[index];
			set => _neurons[index] = value;
		}

		public double[] Neurons
		{
			get => _neurons;
			set => _neurons = value;
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

		private double[] _neurons;
		private double[] _biases;
		private double[] _errors;
	}
}