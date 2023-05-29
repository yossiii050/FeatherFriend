using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;

namespace BirdManagment.Tests
{
    [TestClass()]
    public class frmBirdInfoTests
    {

        [TestMethod()]
        public void ComboBox1_ItemsNotEmpty()
        {
            frmBirdInfo form = new frmBirdInfo();
            
            form.frmBirdInfo_Load(null, null);

            
            NUnit.Framework.Assert.That(form.comboBox1.Items, Is.Not.Empty);
            form = null;
        }
        [TestMethod()]

        public void Button1_Click_WitoutCageSelected()
        {
            frmBirdInfo form = new frmBirdInfo();
            
            form.comboBox1.Text = "";

            
            form.button1_Click(null, null);

          
            
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

            form = null;
        }
        [TestMethod()]
        public void Button2_Click_LoadCageOptions()
        {
            frmBirdInfo form = new frmBirdInfo();

           
            form.comboBox1.SelectedIndex=1;
            form.button1_Click(null, null);
            form.button2_Click(null, EventArgs.Empty);

           
            NUnit.Framework.Assert.That(form.comboBox2.Items, Is.Not.Empty);

            form = null;
        }


    }
}