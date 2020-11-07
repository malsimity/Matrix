using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixClasses
{
    public class Calculator <T>
    {
        T[,] arr;

        public int n;
        public int m;

        public Calculator (int n, int m)
        {
            this.n = n;
            this.m = m;
            arr = new T[n, m];
        }

        public T this[int index1, int index2]
        {
            get
            {
                return arr[index1, index2];
            }

            set
            {
                arr[index1, index2] = value;
            }
        }
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

        public static Calculator<T> operator + (Calculator<T> arrA, Calculator<T> arrB)
        {
            int nA = arrA.n;
            int mA = arrA.m;
            int nB = arrB.n;
            int mB = arrB.m;
            if ((nA != nB) || (mA != mB))
            {
                Exception ex = new ArgumentException("Размерности матриц А и В не совпадают");
                throw ex;
            }
            Calculator<T> arrC = new Calculator<T>(nA, mA);
            for (int i = 0; i < nA; i++)
                for (int j = 0; j < mA; j++)
                    arrC[i, j] = Add<T>(arrA[i, j], arrB[i, j]);
            return arrC;
        }
        public static Calculator<T> operator * (Calculator<T> arrA, Calculator<T> arrB)
        {
            int nA = arrA.n;
            int mA = arrA.m;
            int nB = arrB.n;
            int mB = arrB.m;
            if ((mA != nB))
            {
                Exception ex = new ArgumentException("Кол-во стоблцов матрицы А не совпадает с кол-вом строк матрицы В");
                throw ex;
            }
            Calculator<T> arrC = new Calculator<T>(nA, mB);
            for (int i = 0; i < nA; i++)
                for (int j = 0; j < mB; j++)
                    for (int k = 0; k < mA; k++)
                        arrC[i, j] = Mult<T>(arrA[i, k], arrB[k, j], arrC[i, j]);
            return arrC;
        }
        public void Generation(Func<int, int, T> f)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    arr[i, j] = f(i, j);
        }
    }
}
