using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelGeneration.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace ExcelGeneration
{
    public partial class Form1 : Form
    {
        List<Flat> flats;
        RealEstateEntities context = new RealEstateEntities();

        Excel.Application xlApp;
        Excel.Workbook xlWb;
        Excel.Worksheet xlWs;

        string[] headers = new string[] {"Kód","Eladó","Oldal","Kerület","Lift","Szobák száma","Alapterület (m2)","Ár (mFt)","Négyzetméter ár (Ft/m2)"};
        public Form1()
        {
            InitializeComponent();
            LoadData();
            FormatLabel();
            FormatButtons();

            CreateExcel();

            btn_Close.Click += Btn_Close_Click;
            btn_CloseExcel.Click += Btn_CloseExcel_Click;
        }

        private void Btn_CloseExcel_Click(object sender, EventArgs e)
        {
            CloseExcelApp();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadData()
        {
            flats = context.Flat.ToList();
        }

        private void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                xlWb = xlApp.Workbooks.Add(Missing.Value);
                xlWs = xlWb.ActiveSheet;

                CreateTable();

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errorMessage = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errorMessage, "Error");

                CloseExcelApp();

            }
        }

        private void CreateTable()
        {
            

            object[,] values = new object[flats.Count, headers.Length];

            for (int i = 0; i < headers.Length; i++)
            {
                xlWs.Cells[1, i + 1] = headers[i];
            }

            int counter = 0;
            foreach (Flat f in flats)
            {
                values[counter, 0] = f.Code;
                values[counter, 1] = f.Vendor;
                values[counter, 2] = f.Side;
                values[counter, 3] = f.District;
                values[counter, 4] = f.Elevator == true ? "Van" : "Nincs";
                values[counter, 5] = f.NumberOfRooms;
                values[counter, 6] = f.FloorArea;
                values[counter, 7] = f.Price;
                values[counter, 8] = string.Format("={0}/{1}*1000000", GetCellInRange(counter + 2, 8), GetCellInRange(counter + 2, 7));
                counter++;
            }

            xlWs.get_Range(GetCellInRange(2,1), GetCellInRange(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;

            FormatTable();
        }

        private string GetCellInRange(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }

        private void FormatTable()
        {
            Excel.Range headerRange = xlWs.get_Range(GetCellInRange(1, 1), GetCellInRange(1, headers.Length));
            Excel.Range valuesRange = xlWs.get_Range(GetCellInRange(2, 1), GetCellInRange(flats.Count + 1, headers.Length));
            Excel.Range firstColumnRange = xlWs.get_Range(GetCellInRange(2, 1), GetCellInRange(flats.Count + 1, 1));
            Excel.Range lastColumnRange = xlWs.get_Range(GetCellInRange(2, headers.Length), GetCellInRange(flats.Count + 1, headers.Length));

            //Header format
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.EntireColumn.AutoFit();
            headerRange.RowHeight = 40;
            headerRange.Interior.Color = Color.LightBlue;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            //Values format
            valuesRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            //First column format
            firstColumnRange.Font.Bold = true;
            firstColumnRange.Interior.Color = Color.LightYellow;

            //Last column format
            lastColumnRange.Interior.Color = Color.LightGreen;
            lastColumnRange.NumberFormat = "#,#.00 Ft";
        }

        private void CloseExcelApp()
        {
            xlWb.Close(false);
            xlApp.Quit();
            xlWb = null;
            xlApp = null;
        }


        private void FormatLabel()
        {
            lbl_Magic.Text = "Excel Magic";
            lbl_Magic.Font = new Font("Segoe UI", 55);
            lbl_Magic.AutoSize = false;
            lbl_Magic.Dock = DockStyle.Top;
            lbl_Magic.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Magic.Height = 100;
        }

        private void FormatButtons()
        {
            int btnWidth = 200;
            int btnHeight = 30;
            int btnSpacing = 12;

            btn_Close.Text = "Bezárás";
            btn_Close.Width = btnWidth;
            btn_Close.Height = btnHeight;
            btn_Close.Left = (this.Width / 2) - btnWidth - (btnSpacing);
            btn_Close.Top = 130;
            btn_Close.Anchor = AnchorStyles.Top;

            btn_CloseExcel.Text = "Excel bezárása";
            btn_CloseExcel.Width = btnWidth;
            btn_CloseExcel.Height = btnHeight;
            btn_CloseExcel.Left = (this.Width / 2) + (btnSpacing / 2);
            btn_CloseExcel.Top = 130;
            btn_CloseExcel.Anchor = AnchorStyles.Top;
        }
    }
}
