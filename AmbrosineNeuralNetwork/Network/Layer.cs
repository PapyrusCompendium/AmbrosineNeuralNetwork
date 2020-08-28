using AmbrosineNeuralNetwork.NetworkTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AmbrosineNeuralNetwork.Network
{
	public class Layer<T> : ILayer where T : INeuralActivationType
	{
		public ILayer Parent { get; }
		public ILayer Child { get; }

		public bool IsInput => Child == null;
		public bool IsOutput => Parent == null;

		private INeuralActivationType _neuralNetworkType;
		private NeuronArray _neurons;
		private Matrix _weights;

		public Layer(ILayer parentLayer = null, ILayer childLayer = null)
		{
			Parent = parentLayer;
			Child = childLayer;
			Instantiate();
		}

		public void Instantiate() =>
			_neuralNetworkType = (INeuralActivationType)Activator.CreateInstance(_neuralNetworkType.GetType());

		public double[] StimulateLayers(double[] inputs)
		{
			if (_neurons.Length != inputs.Length)
				throw new Exception("Stimulus size should be congruent to the layer size.");

			inputs = ApplyBiases(inputs);

			if (IsOutput)
				return inputs;

			inputs = ApplyWeights(inputs);

			return Child.StimulateLayers(inputs);
		}

		private double[] ApplyWeights(double[] stimulus)
		{

		}

		private double[] ApplyBiases(double[] stimulus)
		{

		}
	}
}