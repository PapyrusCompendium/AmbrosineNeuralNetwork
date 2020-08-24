using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbrosineNeuralNetwork.NetworkTypes
{
	public interface INeuralActivationType
	{
		double Calculate(double val);
		double Derivative(double val);
	}
}