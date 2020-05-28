using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hydra;
namespace RNA
{
    public partial class Graphics : Plantilla
    {
        public Graphics()
        {
            InitializeComponent();
        }

        private void Graphics_Load(object sender, EventArgs e)
        {
            PointF[] pointer = Rna.PointResult;

            chart1.Series.Clear();
            chart1.Series.Add("RNA");
            chart1.Series["RNA"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
            for (int i = 0; i < pointer.Length; i++)
            {
                double x = (double)pointer[i].X;
                double y = (double)pointer[i].Y;

                chart1.Series["RNA"].Points.AddXY(x, y);
            }
            chart1.Series["RNA"].ChartArea = "ChartArea1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void typeofgraphics_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (typeofgraphics.Text) 
            {
                case "Pie":
                    {
                        chart1.Update();
                        PointF[] pointer = Rna.PointResult;
                        chart1.Series.Clear();
                        chart1.Series.Add("RNA");
                        chart1.Series["RNA"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                        for (int i = 0; i < pointer.Length; i++)
                        {
                            double x = (double)pointer[i].X;
                            double y = (double)pointer[i].Y;

                            chart1.Series["RNA"].Points.AddXY(x, y);
                        }
                        chart1.Series["RNA"].ChartArea = "ChartArea1";
                        break;
                    }
                case "Area":
                    {

                        chart1.Update();
                        PointF[] pointer = Rna.PointResult;
                        chart1.Series.Clear();
                        chart1.Series.Add("RNA");
                        chart1.Series["RNA"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                        for (int i = 0; i < pointer.Length; i++)
                        {
                            double x = (double)pointer[i].X;
                            double y = (double)pointer[i].Y;

                            chart1.Series["RNA"].Points.AddXY(x, y);
                        }
                        chart1.Series["RNA"].ChartArea = "ChartArea1";
                        break;
                    }
                case "Bar":
                    {

                        chart1.Update();
                        PointF[] pointer = Rna.PointResult;
                        chart1.Series.Clear();
                        chart1.Series.Add("RNA");
                        chart1.Series["RNA"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                        for (int i = 0; i < pointer.Length; i++)
                        {
                            double x = (double)pointer[i].X;
                            double y = (double)pointer[i].Y;

                            chart1.Series["RNA"].Points.AddXY(x, y);
                        }
                        chart1.Series["RNA"].ChartArea = "ChartArea1";
                        break;
                    }
                case "Buble":
                    {

                        chart1.Update();
                        PointF[] pointer = Rna.PointResult;
                        chart1.Series.Clear();
                        chart1.Series.Add("RNA");
                        chart1.Series["RNA"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
                        for (int i = 0; i < pointer.Length; i++)
                        {
                            double x = (double)pointer[i].X;
                            double y = (double)pointer[i].Y;

                            chart1.Series["RNA"].Points.AddXY(x, y);
                        }
                        chart1.Series["RNA"].ChartArea = "ChartArea1";
                        break;
                    }
                case "Candlestick":
                    {

                        chart1.Update();
                        PointF[] pointer = Rna.PointResult;
                        chart1.Series.Clear();
                        chart1.Series.Add("RNA");
                        chart1.Series["RNA"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
                        for (int i = 0; i < pointer.Length; i++)
                        {
                            double x = (double)pointer[i].X;
                            double y = (double)pointer[i].Y;

                            chart1.Series["RNA"].Points.AddXY(x, y);
                        }
                        chart1.Series["RNA"].ChartArea = "ChartArea1";
                        break;
                    }
                case "FastPoint":
                    {

                        chart1.Update();
                        PointF[] pointer = Rna.PointResult;
                        chart1.Series.Clear();
                        chart1.Series.Add("RNA");
                        chart1.Series["RNA"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
                        for (int i = 0; i < pointer.Length; i++)
                        {
                            double x = (double)pointer[i].X;
                            double y = (double)pointer[i].Y;

                            chart1.Series["RNA"].Points.AddXY(x, y);
                        }
                        chart1.Series["RNA"].ChartArea = "ChartArea1";
                        break;
                    }
                case "Line":
                    {

                        chart1.Update();
                        PointF[] pointer = Rna.PointResult;
                        chart1.Series.Clear();
                        chart1.Series.Add("RNA");
                        chart1.Series["RNA"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        for (int i = 0; i < pointer.Length; i++)
                        {
                            double x = (double)pointer[i].X;
                            double y = (double)pointer[i].Y;

                            chart1.Series["RNA"].Points.AddXY(x, y);
                        }
                        chart1.Series["RNA"].ChartArea = "ChartArea1";
                        break;
                    }
                case "Funnel":
                    {

                        chart1.Update();
                        PointF[] pointer = Rna.PointResult;
                        chart1.Series.Clear();
                        chart1.Series.Add("RNA");
                        chart1.Series["RNA"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel;
                        for (int i = 0; i < pointer.Length; i++)
                        {
                            double x = (double)pointer[i].X;
                            double y = (double)pointer[i].Y;

                            chart1.Series["RNA"].Points.AddXY(x, y);
                        }
                        chart1.Series["RNA"].ChartArea = "ChartArea1";
                        break;
                    }
                  
            }
        }
    }
}
