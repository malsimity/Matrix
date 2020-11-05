using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixClasses
{
    public class Calculator <T>
    {
        static T Add<U>(U x, U y)
        {
            dynamic dx = x, dy = y;
            return dx + dy;
        }
        static T Mult<U>(U x, U y, U z)
        {
            dynamic dx = x, dy = y, dz = z;
            return dx * dy + dz;
        }
        public T[,] Sum(T [,] arrA, T [,] arrB)
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
            T [,] arrC = new T[nA, mA];
            for (int i = 0; i < nA; i++)
                for (int j = 0; j < mA; j++)
                    arrC[i, j] = Add<T>(arrA[i,j], arrB[i,j]);
            return arrC;
        }
        public T[,] Composition(T[,] arrA, T[,] arrB)
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
            T[,] arrC = new T[nB, mA];
            for (int i = 0; i < nA; i++)
                for (int j = 0; j < mB; j++)
                    for (int k = 0; k < mA; k++)
                        arrC[i, j] = Mult<T>(arrA[i, k], arrB[k, j], arrC[i, j]);
            return arrC;
        }
        public void Generation(T[,] arrA, T[,] arrB, Func<int, int, T> f)
        {
            int nA = arrA.GetLength(0);
            int mA = arrA.GetLength(1);
            int nB = arrB.GetLength(0);
            int mB = arrB.GetLength(1);
            Random ran = new Random();
            //dynamic dx;
            for (int i = 0; i < nA; i++)
                for (int j = 0; j < mA; j++)
                {
                    //dx = f;
                    arrA[i, j] = f(i,j);
                }
            for (int i = 0; i < nB; i++)
                for (int j = 0; j < mB; j++)
                {
                    //dx = f;
                    arrB[i, j] = f(i,j);
                }
        }
    }
}
