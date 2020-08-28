using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbrosineNeuralNetwork.NetworkTypes
{
	public class ReluActivation : INeuralActivationType
	{
		public double Calculate(double val) =>
			val < 0 ? 0 : val;

		public double Derivative(double val) =>
			val < 0 ? 0 : 1;

		public INeuralActivationType Instantiate() =>
			new ReluActivation();
	}
}