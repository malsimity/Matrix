using MatrixClasses;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _cbOp.SelectedIndex = 0;
            _tbMA.Text = "5";
            _tbMB.Text = "5";
            _tbNA.Text = "5";
            _tbNB.Text = "5";
            _tbMC.Text = "5";
            _tbNC.Text = "5";
            _dgvA.RowCount = 5;
            _dgvA.ColumnCount = 5;
            _dgvB.RowCount = 5;
            _dgvB.ColumnCount = 5;
            _dgvC.RowCount = 5;
            _dgvC.ColumnCount = 5;
            for (int i = 0; i < 5; i++)
                for(int j = 0; j < 5; j++)
                {
                    _dgvA.Rows[i].Cells[j].Value = 0;
                    _dgvB.Rows[i].Cells[j].Value = 0;
                    _dgvC.Rows[i].Cells[j].Value = 0;
                }
            _butRandom.Enabled = true;
            _butCalc.Enabled = true;
        }

        public void Extract(Calculator<double> a, Calculator<double> b)
        {
            int nA = _dgvA.RowCount;
            int mA = _dgvA.ColumnCount;
            for (int i = 0; i < nA; i++)
                for (int j = 0; j < mA; j++)
                {
                    a[i,j] = Convert.ToDouble(_dgvA.Rows[i].Cells[j].Value);
                }
            int nB = _dgvB.RowCount;
            int mB = _dgvB.ColumnCount;
            for (int i = 0; i < nB; i++)
                for (int j = 0; j < mB; j++)
                {
                    b[i, j] = Convert.ToDouble(_dgvB.Rows[i].Cells[j].Value);
                }
        }

        private void Block()
        {
            _butRandom.Enabled = false;
            _butCalc.Enabled = false;
        }

        private void _cbOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cbOp.SelectedIndex == 0)
                _labOp.Text = "+";
            else
                _labOp.Text = "x";
        }

        private void _butConf_Click(object sender, EventArgs e)
        {
            int mA = Convert.ToInt32(_tbMA.Text);
            int mB = Convert.ToInt32(_tbMB.Text);
            int nA = Convert.ToInt32(_tbNA.Text);
            int nB = Convert.ToInt32(_tbNB.Text);
            _dgvA.RowCount = nA;
            _dgvA.ColumnCount = mA;
            _dgvB.RowCount = nB;
            _dgvB.ColumnCount = mB;
            for (int i = 0; i < nA; i++)
                for (int j = 0; j < mA; j++)
                    _dgvA.Rows[i].Cells[j].Value = 0;
            for (int i = 0; i < nB; i++)
                for (int j = 0; j < mB; j++)
                    _dgvB.Rows[i].Cells[j].Value = 0;
            _butRandom.Enabled = true;
            _butCalc.Enabled = true;
        }

        private void _butRandom_Click(object sender, EventArgs e)
        {
            int nA = _dgvA.RowCount;
            int mA = _dgvA.ColumnCount;
            int nB = _dgvB.RowCount;
            int mB = _dgvB.ColumnCount;
            Calculator<double> a = new Calculator<double>(nA, mA);
            Calculator<double> b = new Calculator<double>(nB, mB);
            Random ran = new Random();
            a.Generation((x, y) => (x * (y - 2) + 14)*ran.Next(-10,10));
            b.Generation((x, y) => (2 * x * (2*y + 7) + 14) * ran.Next(-10,10));
            for (int i = 0; i < nA; i++)
                for (int j = 0; j < mA; j++)
                    _dgvA.Rows[i].Cells[j].Value = a[i, j];
            for (int i = 0; i < nB; i++)
                for (int j = 0; j < mB; j++)
                    _dgvB.Rows[i].Cells[j].Value = b[i, j];
        }

        private void saveC_Click(object sender, EventArgs e)
        {
            string way = Directory.GetCurrentDirectory() + "\\Matrix_C.csv";
            StreamWriter sw = new StreamWriter(way);
            int nC = Convert.ToInt32(_tbNC.Text);
            int mC = Convert.ToInt32(_tbMC.Text);
            for (int i = 0; i < nC; i++)
            {
                sw.Write("\t");
                for (int j = 0; j < mC; j++)
                {
                    sw.Write(Convert.ToString(_dgvC.Rows[i].Cells[j].Value) + ";");
                    sw.Write("\t");
                }
                sw.WriteLine();
            }
            sw.Close();
            MessageBox.Show("Матрица сохранена по пути " + way);
        }

        private void _butCalc_Click(object sender, EventArgs e)
        {
            Stopwatch time = new Stopwatch();
            TimeSpan resulttime;
            if (_cbOp.SelectedIndex == 0)
            {
                int nA = _dgvA.RowCount;
                int mA = _dgvA.ColumnCount;
                int nB = _dgvB.RowCount;
                int mB = _dgvB.ColumnCount;
                if ((nA != nB) || (mA != mB))
                {
                    Exception ex = new ArgumentException("Размерности матриц А и В не совпадают");
                    throw ex;
                }
                _dgvC.RowCount = _dgvA.RowCount;
                _dgvC.ColumnCount = _dgvA.ColumnCount;
                _tbNC.Text = Convert.ToString(nB);
                _tbMC.Text = Convert.ToString(mB);
                Calculator<double> a = new Calculator<double>(nA, mA);
                Calculator<double> b = new Calculator<double>(nA, mA);
                Calculator<double> c = new Calculator<double>(mA, nA);
                Extract(a, b);
                time.Restart();
                c = a * b;
                time.Stop();
                for (int i = 0; i < nB; i++)
                    for (int j = 0; j < mB; j++)
                    {
                        _dgvC.Rows[i].Cells[j].Value = c[i, j];
                    }
            }
            else
            {
                int nA = _dgvA.RowCount;
                int mA = _dgvA.ColumnCount;
                int nB = _dgvB.RowCount;
                int mB = _dgvB.ColumnCount;
                if ((mA != nB))
                {
                    Exception ex = new ArgumentException("Кол-во стоблцов матрицы А не совпадает с кол-вом строк матрицы В");
                    throw ex;
                }
                _dgvC.RowCount = _dgvA.RowCount;
                _dgvC.ColumnCount = _dgvB.ColumnCount;
                _tbNC.Text = Convert.ToString(nA);
                _tbMC.Text = Convert.ToString(mB);
                Calculator<double> a = new Calculator<double>(nA, mA);
                Calculator<double> b = new Calculator<double>(nB, mB);
                Calculator<double> c = new Calculator<double>(nA, mB);
                Extract(a, b);
                time.Restart();
                c = a * b;
                time.Stop();
                for (int i = 0; i < nA; i++)
                    for (int j = 0; j < mB; j++)
                    {
                        _dgvC.Rows[i].Cells[j].Value = c[i, j];
                    }
            }
            resulttime = time.Elapsed;
            _tbTimeC.Text = Convert.ToString(resulttime.TotalMilliseconds);
        }

        private void _tbNA_TextChanged(object sender, EventArgs e)
        {
            Block();
        }

        private void _tbMA_TextChanged(object sender, EventArgs e)
        {
            Block();
        }

        private void _tbNB_TextChanged(object sender, EventArgs e)
        {
            Block();
        }

        private void _tbMB_TextChanged(object sender, EventArgs e)
        {
            Block();
        }
    }
}
