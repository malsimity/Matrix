using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixClasses
{
    public class Calculator 
    {
        public double[,] Sum(double [,] arrA, double [,] arrB)
        {
            int nA = arrA.GetLength(0);
            int mA = arrA.GetLength(1);
            int nB = arrB.GetLength(0);
            int mB = arrB.GetLength(1);
            if ((nA != nB) || (mA != mB))
            {
                Exception ex = new ArgumentException("Размерности матриц А и В не совпадают");
                throw ex;
            }
            double[,] arrC = new double[nA, mA];
            for (int i = 0; i < nA; i++)
                for (int j = 0; j < mA; j++)
                    arrC[i, j] = arrA[i, j] + arrB[i, j];
            return arrC;
        }
        public double[,] Composition(double[,] arrA, double[,] arrB)
        {
            int nA = arrA.GetLength(0);
            int mA = arrA.GetLength(1);
            int nB = arrB.GetLength(0);
            int mB = arrB.GetLength(1);
            if ((nA != mB) || (mA != nB))
            {
                Exception ex = new ArgumentException("Кол-во стоблцов матрицы А не совпадает с кол-вом строк матрицы В");
                throw ex;
            }
            double[,] arrC = new double[nB, mA];
            for (int i = 0; i < nA; i++)
                for (int j = 0; j < mB; j++)
                    for (int k = 0; k < mA; k++)
                     arrC[i, j] += arrA[i, k] * arrB[k, j];
            return arrC;
        }
        public void Generation(int nA, int mA, int nB, int mB, Func<int, int, double> f)
        {

        }
    }
}
