using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixClasses;

namespace Matrix.Tests
{
    [TestClass]
    public class Matrix_Tests
    {
        [TestMethod]
        public void Index()
        {
            //arrange
            Calculator<int> a = new Calculator<int>(5, 5);
            a[1, 2] = 100;
            int expected = 100;

            //act
            int actual = a[1, 2];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Sum_Dimen_mis()
        {
            //arrange
            Calculator<double> a = new Calculator<double>(5, 5);
            Calculator<double> b = new Calculator<double>(4, 5);
            Calculator<double> c;

            //act
            c = a + b;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Mult_Dimen_mis()
        {
            //arrange
            Calculator<double> a = new Calculator<double>(5, 5);
            Calculator<double> b = new Calculator<double>(4, 5);
            Calculator<double> c;

            //act
            c = a * b;
        }

        [TestMethod]
        public void Sum_Matr_2_2()
        {
            //arrange
            Calculator<double> a = new Calculator<double>(2, 2);
            Calculator<double> b = new Calculator<double>(2, 2);
            Calculator<double> expected;
            Calculator<double> actual = new Calculator<double>(2, 2);

            //act
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    a[i, j] = 1;
                    b[i, j] = 1;
                    actual[i, j] = 2;
                }
            expected = a + b;

            //assert
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(expected[i,j], actual[i,j]);
                }
        }

        [TestMethod]
        public void Mult_Matr_2_2()
        {
            //arrange
            Calculator<double> a = new Calculator<double>(2, 2);
            Calculator<double> b = new Calculator<double>(2, 2);
            Calculator<double> expected;
            Calculator<double> actual = new Calculator<double>(2, 2);

            //act
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    a[i, j] = 1;
                    b[i, j] = 1;
                    actual[i, j] = 2;
                }
            expected = a * b;

            //assert
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
        }

        [TestMethod]
        public void Sum_Negative_Matr_2_2()
        {
            //arrange
            Calculator<double> a = new Calculator<double>(2, 2);
            Calculator<double> b = new Calculator<double>(2, 2);
            Calculator<double> expected;
            Calculator<double> actual = new Calculator<double>(2, 2);

            //act
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    a[i, j] = 1;
                    b[i, j] = 1;
                    actual[i, j] = 0;
                }
            expected = a + b;

            //assert
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    Assert.AreNotEqual(expected[i, j], actual[i, j]);
                }
        }

        [TestMethod]
        public void Mult_Negative_Matr_2_2()
        {
            //arrange
            Calculator<double> a = new Calculator<double>(2, 2);
            Calculator<double> b = new Calculator<double>(2, 2);
            Calculator<double> expected;
            Calculator<double> actual = new Calculator<double>(2, 2);

            //act
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    a[i, j] = 1;
                    b[i, j] = 1;
                    actual[i, j] = 0;
                }
            expected = a * b;

            //assert
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    Assert.AreNotEqual(expected[i, j], actual[i, j]);
                }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Negarive_mis()
        {
            Calculator<double> a = new Calculator<double>(-5, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_Type()
        {
            //arrange
            Calculator<string> a = new Calculator<string>(5, 5);
        }

        [TestMethod]
        public void Random_2_2()
        {
            //arrange
            Calculator<int> actual = new Calculator<int>(2, 2);
            Calculator<int> expected = new Calculator<int>(2, 2);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    expected[i, j] = i + j;

            //act
            actual.Generation((x, y) => x + y);

            //assert
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
        }

    }
}
