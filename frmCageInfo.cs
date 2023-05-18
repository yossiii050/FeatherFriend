using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace BirdManagment
{
    public partial class frmCageInfo : Form
    {
      
        public frmCageInfo()
        {
            InitializeComponent();
            Application app2 = new Application();
            Workbook wbCage = app2.Workbooks.Open(@"C:\FeatherFriend\DataBased\CageDB.xlsx", ReadOnly: true);
            Worksheet wsCage = wbCage.Worksheets["sheet1"];
            Range usedRangeCage = wsCage.UsedRange;

            int lastRowCage = usedRangeCage.Rows.Count;
            for (int row = 2; row <= lastRowCage; row++)
            {
                string CageIds = Convert.ToString(wsCage.Cells[row, 1].Value);

                comboBox1.Items.Add(CageIds);

            }


            wbCage.Close();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wbCage);
            wbCage = null;
            wsCage = null;
            app2.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app2);
            app2 = null;
        }

       

        private void frmCageInfo_Load(object sender, EventArgs e)
        {
           
        }

   
    }

}
