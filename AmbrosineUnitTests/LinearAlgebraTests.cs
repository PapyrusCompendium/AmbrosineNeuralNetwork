using System;
using AmbrosineNeuralNetwork.Network;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmbrosineUnitTests
{
	[TestClass]
	public class LinearAlgebraTests
	{
		[TestMethod]
		public void MatrixMulTest()
		{
			Matrix matrixA = new Matrix(new double[2, 3]
			{
				{ 1, 2, 3 },
				{ 4, 5, 6 }
			});

			Matrix matrixB = new Matrix(new double[3, 2]
			{
				{ 7, 8 },
				{ 9, 10 },
				{ 11, 12 }
			});

			Matrix expected = new Matrix(new double[2, 2]
			{
				{ 58, 64 },
				{ 139, 154 }
			});

			Assert.AreEqual(expected, matrixA * matrixB);
		}
	}
}