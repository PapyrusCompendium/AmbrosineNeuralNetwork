using AmbrosineNeuralNetwork.NetworkTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbrosineNeuralNetwork.Network
{
	public class Layer<T> : ILayer where T : INeuralActivationType
	{
		public ILayer Parent => null;

		private INeuralActivationType _neuralNetworkType;
		private NeuronArray _neurons;
		private Matrix _weights;
		private Matrix _connectionWeights;

		public Layer()
		{
			_neuralNetworkType = (INeuralActivationType)Activator.CreateInstance(_neuralNetworkType.GetType());
		}

		public void Propagate()
		{
			 
		}

		public void AddError()
		{
			
		}
	}
}