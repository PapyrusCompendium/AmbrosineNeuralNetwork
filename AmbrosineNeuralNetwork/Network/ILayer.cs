using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbrosineNeuralNetwork.Network
{
	public interface ILayer
	{
		ILayer Parent { get; }
		void Propagate();
		void AddError();
	}
}
