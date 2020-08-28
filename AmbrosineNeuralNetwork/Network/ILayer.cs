using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbrosineNeuralNetwork.Network
{
	public interface ILayer
	{
		bool IsInput { get; }
		bool IsOutput { get; }
		ILayer Child { get; }
		ILayer Parent { get; }
		double[] StimulateLayers(double[] inputs);
	}
}