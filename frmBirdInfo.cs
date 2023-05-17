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
    public partial class frmBirdInfo : Form
    {
      
        public frmBirdInfo()
        {
            InitializeComponent();

            Application app2 = new Application();
            Workbook wb2 = app2.Workbooks.Open(@"C:\FeatherFriend\DataBased\BirdDB.xlsx", ReadOnly: true);
            Worksheet ws2 = wb2.Worksheets["sheet1"];
            Range usedRange2 = ws2.UsedRange;

            int lastRow = usedRange2.Rows.Count;
            comboBox1.Items.Add(0); // Add a default option if needed

            for (int row = 2; row <= lastRow; row++)
            {
                int id = Convert.ToInt32(ws2.Cells[row, 1].Value);
                comboBox1.Items.Add(id);
            }

            wb2.Close();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb2);
            ws2 = null;
            wb2 = null;

            app2.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app2);
            app2 = null;
        }

       

        private void frmBirdInfo_Load(object sender, EventArgs e)
        {
           
        }

   
    }

}
