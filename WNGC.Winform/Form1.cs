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
        public Form1()
        {
            InitializeComponent();
        }

        private async void ReadMvtsButton_Click(object sender, EventArgs e)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new StockMovementService.StockMovementServiceClient(channel);
            var movements = client.GetMovements(new Empty());
            await foreach(var mvt in movements.ResponseStream.ReadAllAsync())
            {
                StockMovementListBox.Items.Add($"{mvt.MovementPurpose.ToString()} for {mvt.Count} {mvt.Article.Name} by {mvt.Article.Company.Name}");
                StockMovementListBox.TopIndex = StockMovementListBox.Items.Count - 1;
                RevenueLabel.Text = mvt.MovementPurpose switch
                {
                    StockMovement.Types.Purpose.B2Breturn => (Convert.ToDouble(RevenueLabel.Text) - (mvt.Count * mvt.Article.Price)).ToString("0.00"),
                    StockMovement.Types.Purpose.B2Creturn => (Convert.ToDouble(RevenueLabel.Text) + (mvt.Count * mvt.Article.Price)).ToString("0.00"),
                    StockMovement.Types.Purpose.PurchaseOrder => (Convert.ToDouble(RevenueLabel.Text) - (mvt.Count * mvt.Article.Price)).ToString("0.00"),
                    StockMovement.Types.Purpose.Sales => (Convert.ToDouble(RevenueLabel.Text) + (mvt.Count * mvt.Article.Price)).ToString("0.00"),
                };
            }
        }
    }
}
