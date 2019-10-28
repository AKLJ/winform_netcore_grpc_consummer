using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WNGC.Core;

namespace WNGC.Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateMvtsButton_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            StockCore.CreateStockMovements().Wait();
            stopwatch.Stop();
            MessageBox.Show($"Movements created in {stopwatch.Elapsed.TotalSeconds}s", "Creation done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ReadMvtsButton_Click(object sender, EventArgs e)
        {
            if (StockCore.StockMovements == null)
            {
                MessageBox.Show("No movements created. Please click on create button first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
