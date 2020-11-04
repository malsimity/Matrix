using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            _tbMC.Text = "0";
            _tbNC.Text = "0";
            _dgvA.RowCount = 5;
            _dgvA.ColumnCount = 5;
            _dgvB.RowCount = 5;
            _dgvB.ColumnCount = 5;
            for (int i = 0; i < 5; i++)
                for(int j = 0; j < 5; j++)
                {
                    _dgvA.Rows[i].Cells[j].Value = 0;
                    _dgvB.Rows[i].Cells[j].Value = 0;
                }
        }

        private void _cbOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            _labOp.Text = _cbOp.Text;
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
        }

    }
}
