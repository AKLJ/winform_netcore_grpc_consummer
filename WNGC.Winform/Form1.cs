using Grpc.Core;
using Grpc.Net.Client;
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
using WNGC.Grpc;
using WNGC.Grpc.Services;

namespace WNGC.Winform
{
    public partial class Form1 : Form
    {
        private bool _isStockCreated = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateMvtsButton_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            StockService.CreateStockMovements();
            stopwatch.Stop();
            _isStockCreated = true;
            MessageBox.Show($"Movements created in {stopwatch.Elapsed.TotalSeconds}s", "Creation done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void ReadMvtsButton_Click(object sender, EventArgs e)
        {
            if (!_isStockCreated)
            {
                MessageBox.Show("No movements created. Please click on create button first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new StockMovementService.StockMovementServiceClient(channel);
            var movements = client.GetMovements(null);
            await foreach(var mvt in movements.ResponseStream.ReadAllAsync())
            {
                StockMovementsListView.Items.Add($"{mvt.MovementPurpose.ToString()} for {mvt.Count} {mvt.Article.Name} by {mvt.Article.Company.Name}");
            }
        }
    }
}
