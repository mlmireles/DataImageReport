using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;

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

			if(this.ExportData())
			{
				MessageBox.Show("Data save successfully", "Save", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				return;
			}
		}

		private Boolean ExportData()
		{
			Excel.Workbook workBook;
			Excel.Worksheet workSheet;

			Excel.Application excel = new Excel.Application
			{
				Visible = false
			};

			try
			{
				workBook = excel.Workbooks.Open("report.xlsx");
			}
			catch (COMException e)
			{
				if (e.ErrorCode != -2146827284)
				{
					MessageBox.Show("Something went wrong", "Excel", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
					return false;
				}

				workBook = this.CreateNewBook(excel);
			}

			workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);
			int row = this.GetLastRow(workSheet);

			workSheet.Cells[++row, 2] = this.textBox_Id.Text;
			workSheet.Cells[row, 3] = this.textBox_Name.Text;

			Excel.Range signature = workSheet.Cells[row, 5];
			float left = (float)((double)signature.Left);
			float top = (float)((double)signature.Top);
			workSheet.Shapes.AddPicture("C:\\Users\\HS\\Pictures\\9GAG\\Programmers-A-different-kind-of-humans.jpg", 
				MsoTriState.msoFalse, MsoTriState.msoCTrue, left, top, 200, 70);
			signature.RowHeight = 70;
			signature.ColumnWidth = 50;

			Excel.Range photo = workSheet.Cells[row, 7];
			left = (float)((double)photo.Left);
			top = (float)((double)photo.Top);
			workSheet.Shapes.AddPicture("C:\\Users\\HS\\Pictures\\9GAG\\Procrastinating.jpg", 
				MsoTriState.msoFalse, MsoTriState.msoCTrue, left, top, 100, 130);
			photo.RowHeight = 130;
			photo.ColumnWidth = 30;

			// Exit book
			workBook.Close(true);
			//workBook.Close(0);
			// Exit from the application  
			excel.Quit();
			Marshal.ReleaseComObject(excel);

			return true;
		}

		private Excel.Workbook CreateNewBook(Excel.Application excel)
		{
			try
			{
				Excel.Workbook	workBook = excel.Workbooks.Add();
				Excel.Worksheet	workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

				workSheet.Cells[1, 2] = "ID";
				workSheet.Cells[1, 3] = "Name";
				workSheet.Cells[1, 5] = "Signature";
				workSheet.Cells[1, 7] = "Photo";

				workBook.SaveAs("report.xlsx", Type.Missing, Type.Missing, 
					Type.Missing, Type.Missing, Type.Missing, 
					Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, 
					Type.Missing, Type.Missing);
				
				return workBook;
			}
			catch (Exception)
			{
				MessageBox.Show("Something went wrong", "Create file", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				throw;
			}
		}

		private int GetLastRow(Excel.Worksheet workSheet)
		{
			int row = 3;
			while (!String.IsNullOrEmpty(((Excel.Range)workSheet.Cells[row, 2]).Text))
			{
				row += 2;
			}

			return row;
		}
	}
}
