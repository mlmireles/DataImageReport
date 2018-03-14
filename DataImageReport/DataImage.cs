using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
namespace DataImageReport
{
	public partial class DataImage : Form
	{
		public DataImage()
		{
			InitializeComponent();
		}

		private void Button_Save_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(this.textBox_Id.Text.Trim())
				|| String.IsNullOrWhiteSpace(this.textBox_Id.Text.Trim()))
			{
				MessageBox.Show("Must add an ID", "Data", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			if (String.IsNullOrEmpty(this.textBox_Name.Text.Trim())
				|| String.IsNullOrWhiteSpace(this.textBox_Name.Text.Trim()))
			{
				MessageBox.Show("Must add a Name", "Data", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			this.ExportData();
		}

		private void ExportData()
		{
			Microsoft.Office.Interop.Excel.Application excel;
			Workbook workBook;
			Worksheet workSheet;

			excel = new Microsoft.Office.Interop.Excel.Application
			{
				Visible = false
			};

			try
			{
				workBook = excel.Workbooks.Open("report.xlsx");
			}
			catch (System.Runtime.InteropServices.COMException e)
			{
				workBook = excel.Workbooks.Add();
				workSheet = workBook.Worksheets.Add();

				workBook.SaveAs("report.xlsx", Type.Missing, Type.Missing, 
					Type.Missing, Type.Missing, Type.Missing, 
					XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, 
					Type.Missing, Type.Missing);

				MessageBox.Show("New report created successfully", "Report",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			/*
			workSheet = (Worksheet)workBook.Worksheets.get_Item(1);
			Range CR = (Range)workSheet.Cells[1, 1];
			CR.Select();

			workSheet.PasteSpecial(CR, Type.Missing, Type.Missing, 
				Type.Missing, Type.Missing, Type.Missing, true);

			workSheet.SaveAs("report");

			// save the application  
			workBook.SaveAs("report.xls", Type.Missing, Type.Missing, 
				Type.Missing, Type.Missing, Type.Missing, 
				XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, 
				Type.Missing, Type.Missing);
			*/

			// Exit from the application  
			excel.Quit();
		}
	}
}
