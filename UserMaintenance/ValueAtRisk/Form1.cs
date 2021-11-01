using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueAtRisk.Data;
using ValueAtRisk.Entities;

namespace ValueAtRisk
{
    public partial class Form1 : Form
    {
        PortfolioEntities context = new PortfolioEntities();
        List<Tick> Ticks;
        List<PortfolioItem> Portfolio = new List<PortfolioItem>();

        public Form1()
        {
            InitializeComponent();
            Ticks = context.Ticks.ToList();
            dgv_Ticks.DataSource = Ticks;

            CreatePortfolio();
            CalculateProfit();
        }

        private void CreatePortfolio()
        {
            Portfolio.Add(new PortfolioItem() { Index = "OTP", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ZWACK", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ELMU", Volume = 10 });

            dgv_Portfolio.DataSource = Portfolio;
        }

        private decimal GetPortfolioValue(DateTime date)
        {
            decimal value = 0;
            foreach (var item in Portfolio)
            {
                var last = (from x in Ticks
                            where item.Index == x.Index.Trim() && date <= x.TradingDay
                            select x).First();
                value += (decimal)last.Price * item.Volume;
            }

            return value;
        }

        private void CalculateProfit()
        {
            List<decimal> Profit = new List<decimal>();
            int interval = 30;
            DateTime StartDate = (from x in Ticks select x.TradingDay).Min();
            DateTime EndDate = new DateTime(2016, 12, 30);
            TimeSpan z = EndDate - StartDate;

            for (int i = 0; i < z.Days - interval; i++)
            {
                decimal p = GetPortfolioValue(StartDate.AddDays(i + interval)) - GetPortfolioValue(StartDate.AddDays(i));
                Profit.Add(p);
                Console.WriteLine(i + " " + p);
            }

            var ProfitOrdered = (from x in Profit orderby x select x).ToList();
            MessageBox.Show(ProfitOrdered[ProfitOrdered.Count() / 5].ToString(), "Profit", MessageBoxButtons.OK);
        }

    }
}
