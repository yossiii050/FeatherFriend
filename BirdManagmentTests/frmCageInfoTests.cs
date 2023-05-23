using Microsoft.VisualStudio.TestTools.UnitTesting;
using BirdManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Windows.Forms;

namespace BirdManagment.Tests
{
    [TestClass()]
    public class frmCageInfoTests
    {

        
        [TestMethod()]
        public void ComboBox1_ItemsNotEmpty()
        {
            frmCageInfo form = new frmCageInfo();
            // Act
            form.frmCageInfo_Load(null, null);

            // Assert
            NUnit.Framework.Assert.That(form.comboBox1.Items, Is.Not.Empty);
            form = null;
        }


        [TestMethod()]

        public void Button1_Click_WitoutCageSelected()
        {
            frmCageInfo form = new frmCageInfo();
            // Arrange
            form.comboBox1.Text = "";

            // Act
            form.button1_Click(null, null);

            // Assert
            NUnit.Framework. Assert.That(form.textBox1.Text, Is.Empty);
            NUnit.Framework. Assert.That(form.textBox2.Text, Is.Empty);
            NUnit.Framework.Assert.That(form.textBox3.Text, Is.Empty);
            NUnit.Framework. Assert.That(form.textBox4.Text, Is.Empty);
            // Verify that the error message box was shown
            // (you can use a mocking framework to verify the MessageBox invocation)
            form = null;
        }


        [TestMethod()]
        public void Button2_Click_EnableTextBoxes()
        {
            frmCageInfo form = new frmCageInfo();

            // Act
            form.comboBox1.SelectedIndex=1;
            form.button1_Click(null, null);
            form.button2_Click(null, null);

            // Assert
            NUnit.Framework.Assert.That(form.textBox1.Enabled, Is.True);
            NUnit.Framework.Assert.That(form.textBox2.Enabled, Is.True);
            NUnit.Framework.Assert.That(form.textBox3.Enabled, Is.True);
            // Verify that a message box was shown with the expected message
            // (you can use a mocking framework to verify the MessageBox invocation)
            form = null;
        }

        [TestMethod()]
        public void IsValidDimension_TestTrue()
        {
            frmCageInfo form = new frmCageInfo();

            // Arrange
            string validDimension = "10";

            // Act
            bool isValid = form.IsValidDimension(validDimension);

            // Assert
            NUnit.Framework.Assert.That(isValid, Is.True);
            form = null;
        }

        [TestMethod()]
        public void IsValidDimension_TestFalse()
        {
            frmCageInfo form = new frmCageInfo();

            // Arrange
            string invalidDimension = "Invalid";

            // Act
            bool isValid = form.IsValidDimension(invalidDimension);

            // Assert
            NUnit.Framework.Assert.That(isValid, Is.False);
            form = null;
        }

    }
}