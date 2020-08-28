using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbrosineNeuralNetwork.Network
{
	/// <summary>
	/// 
	/// </summary>
	public unsafe class Matrix
	{
		public Matrix() { }
		public Matrix(double[,] matrix) => _matrix = matrix;

		public double this[int x, int y]
		{
			get => _matrix[x, y];
			set => _matrix[x, y] = value;
		}

		private int? _width = null;
		public int Width
		{
			get
			{
				if (_width == null)
					_width = _matrix.GetLength(1);
				return _width ?? 0;
			}
		}

		private int? _height = null;
		public int Height
		{
			get
			{
				if (_height == null)
					_height = _matrix.GetLength(0);
				return _height ?? 0;
			}
		}

		private double[,] _matrix;

		public static double[] operator *(Matrix op1, double[] op2)
		{
			double[] matrixZ = new double[op1.Height];

			fixed (double* matrixZPtr = matrixZ)
				for (int x = 0; x < op2.Length; x++)
					DotProduct(op1, x, op2, x, matrixZPtr);

			return matrixZ;
		}

		private static void DotProduct(Matrix matrixA, int row, double[] matrixB, int y, double* matrixZ)
		{
			fixed (double* matrixAPtr = matrixA._matrix, matrixBPtr = matrixB)
				for (int x = 0; x < matrixA.Width; x++)
					matrixZ[x] += matrixAPtr[row * matrixA.Width + x] * matrixBPtr[y];
		}

		/// <summary>
		/// return the product of a Matrix multiplied by another multi-dimensional matrix.
		/// </summary>
		/// <param name="op1"></param>
		/// <param name="op2"></param>
		/// <returns></returns>
		public static Matrix operator *(Matrix op1, Matrix op2)
		{
			Matrix matrix = new Matrix(new double[op1.Height, op2.Width]);

			fixed (double* matrixPtr = matrix._matrix)
				for (int x = 0; x < op1.Height; x++)
					for (int y = 0; y < op2.Width; y++)
						DotProduct(op1, x, op2, y, matrixPtr);

			return matrix;
		}

		private static void DotProduct(Matrix matrixA, int row, Matrix matrixB, int column, double* MatrixZ)
		{
			fixed (double* matrixAPtr = matrixA._matrix, matrixBPtr = matrixB._matrix)
				for (int x = 0, y = 0; x < matrixA.Width; x++, y++)
					MatrixZ[row * matrixB.Width + column] += matrixAPtr[row * matrixA.Width + x] * matrixBPtr[y * matrixB.Width + column];
		}

		public override bool Equals(object obj) =>
			(obj is Matrix matrix) && CompareMatrix(matrix);

		private bool CompareMatrix(Matrix matrix)
		{
			fixed (double* matrixA = _matrix, matrixB = matrix._matrix)
				for (int x = 0; x < Width * Height; x++)
					if (matrixA[x] != matrixB[x])
						return false;
			return true;
		}
	}
}