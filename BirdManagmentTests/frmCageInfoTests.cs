using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace BirdManagment.Tests
{
    [TestClass()]
    public class frmCageInfoTests
    {

        
        [TestMethod()]
        public void ComboBox1_ItemsNotEmpty()
        {
            frmCageInfo form = new frmCageInfo();
            
            form.frmCageInfo_Load(null, null);

          
            NUnit.Framework.Assert.That(form.comboBox1.Items, Is.Not.Empty);
            form = null;
        }


        [TestMethod()]

        public void Button1_Click_WitoutCageSelected()
        {
            frmCageInfo form = new frmCageInfo();
          
            form.comboBox1.Text = "";

            
            form.button1_Click(null, null);

         
            NUnit.Framework. Assert.That(form.textBox1.Text, Is.Empty);
            NUnit.Framework. Assert.That(form.textBox2.Text, Is.Empty);
            NUnit.Framework.Assert.That(form.textBox3.Text, Is.Empty);
            NUnit.Framework. Assert.That(form.textBox4.Text, Is.Empty);

            form = null;
        }


        [TestMethod()]
        public void Button2_Click_EnableTextBoxes()
        {
            frmCageInfo form = new frmCageInfo();

          
            form.comboBox1.SelectedIndex=1;
            form.button1_Click(null, null);
            form.button2_Click(null, null);

          
            NUnit.Framework.Assert.That(form.textBox1.Enabled, Is.True);
            NUnit.Framework.Assert.That(form.textBox2.Enabled, Is.True);
            NUnit.Framework.Assert.That(form.textBox3.Enabled, Is.True);

            form = null;
        }

        [TestMethod()]
        public void IsValidDimension_TestTrue()
        {
            frmCageInfo form = new frmCageInfo();

           
            string validDimension = "10";

         
            bool isValid = form.IsValidDimension(validDimension);

         
            NUnit.Framework.Assert.That(isValid, Is.True);
            form = null;
        }

        [TestMethod()]
        public void IsValidDimension_TestFalse()
        {
            frmCageInfo form = new frmCageInfo();

           
            string invalidDimension = "Invalid";

           
            bool isValid = form.IsValidDimension(invalidDimension);

         
            NUnit.Framework.Assert.That(isValid, Is.False);
            form = null;
        }

    }
}