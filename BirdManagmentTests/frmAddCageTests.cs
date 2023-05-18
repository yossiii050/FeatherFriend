using BirdManagment;
using NUnit.Framework;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;
using Assert = NUnit.Framework.Assert;

namespace BirdManagement.Tests
{
    [TestFixture]
    public class FrmAddCageTests
    {
        private frmAddCage form;

        [SetUp]
        public void SetUp()
        {
            // Create an instance of frmAddCage before each test
            form = new frmAddCage();
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up the instance after each test
            form.Dispose();
            form = null;
        }

        [Test]
        public void Add_btn_Click_InvalidCageID_ShowErrorMessage()
        {
            // Arrange
            form.serial.Text = "!@#$"; // Invalid cage ID

            // Act
            form.add_btn_Click(null, null);

            // Assert
            Assert.That(form.DialogResult, Is.EqualTo(DialogResult.None));
            // Verify that the error message box is shown
            Assert.That(form.OwnedForms, Has.Exactly(1).InstanceOf<MessageBox>());
        }

        [Test]
        public void Add_btn_Click_InvalidLength_ShowErrorMessage()
        {
            // Arrange
            form.serial.Text = "Cage1";
            form.length.Text = "abc"; // Invalid length

            // Act
            form.add_btn_Click(null, null);

            // Assert
            Assert.That(form.DialogResult, Is.EqualTo(DialogResult.None));
            // Verify that the error message box is shown
            Assert.That(form.OwnedForms, Has.Exactly(1).InstanceOf<MessageBox>());
        }

        // Add more tests to cover other scenarios...

        /*[Test]
        public void IsCageIdUsed_ExistingCageId_ReturnsTrue()
        {
            // Arrange
            var existingCageId = "Cage1";
            var app = new Application();
            var wb = app.Workbooks.Open(@"C:\FeatherFriend\DataBased\CageDB.xlsx");
            var ws = wb.Worksheets["sheet1"];
            ws.Cells[2, 1].Value = existingCageId;

            // Act
            var result = form.IsCageIdUsed(existingCageId);

            // Assert
            Assert.That(result, Is.True);

            // Clean up
            wb.Close();
            app.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
            ws = null;
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            wb = null;
            app = null;
        }*/

        // Add more tests for IsCageIdUsed to cover other scenarios...

        [Test]
        public void IsValidDimension_ValidDimension_ReturnsTrue()
        {
            // Arrange
            var validDimension = "10";

            // Act
            var result = form.IsValidDimension(validDimension);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValidDimension_InvalidDimension_ReturnsFalse()
        {
            // Arrange
            var invalidDimension = "abc";

            // Act
            var result = form.IsValidDimension(invalidDimension);

            // Assert
            Assert.That(result, Is.False);
        }
    }
}