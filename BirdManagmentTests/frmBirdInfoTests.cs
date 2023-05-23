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
    public class frmBirdInfoTests
    {

        [TestMethod()]
        public void ComboBox1_ItemsNotEmpty()
        {
            frmBirdInfo form = new frmBirdInfo();
            // Act
            form.frmBirdInfo_Load(null, null);

            // Assert
            NUnit.Framework.Assert.That(form.comboBox1.Items, Is.Not.Empty);
            form = null;
        }
        [TestMethod()]

        public void Button1_Click_WitoutCageSelected()
        {
            frmBirdInfo form = new frmBirdInfo();
            // Arrange
            form.comboBox1.Text = "";

            // Act
            form.button1_Click(null, null);

            // Assert
            
            NUnit.Framework.Assert.That(form.textBox2.Text, Is.Empty);
            NUnit.Framework.Assert.That(form.textBox3.Text, Is.Empty);
            NUnit.Framework.Assert.That(form.textBox4.Text, Is.Empty);
            NUnit.Framework.Assert.That(form.textBox5.Text, Is.Empty);
            NUnit.Framework.Assert.That(form.textBox6.Text, Is.Empty);
            NUnit.Framework.Assert.That(form.textBox7.Text, Is.Empty);
            NUnit.Framework.Assert.That(form.textBox8.Text, Is.Empty);
            NUnit.Framework.Assert.That(form.textBox9.Text, Is.Empty);
            NUnit.Framework.Assert.That(form.textBox10.Text, Is.Empty);
            NUnit.Framework.Assert.That(form.textBox11.Text, Is.Empty);
            // Verify that the error message box was shown
            // (you can use a mocking framework to verify the MessageBox invocation)
            form = null;
        }
        [TestMethod()]
        public void Button2_Click_LoadCageOptions()
        {
            frmBirdInfo form = new frmBirdInfo();

            // Act
            form.comboBox1.SelectedIndex=1;
            form.button1_Click(null, null);
            form.button2_Click(null, EventArgs.Empty);

            // Assert
            NUnit.Framework.Assert.That(form.comboBox2.Items, Is.Not.Empty);
            // Verify that the workbook was opened and closed
            // Verify that the cage options were populated in the combo box
            // (you can use a mocking framework to verify the Workbook and ComboBox interactions)
            form = null;
        }


    }
}