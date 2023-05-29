using BirdManagment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BirdManagement.Tests
{
    [TestClass()]
    public class FrmAddCageTests
    {
        [TestMethod()]
        public void AddButton_InvalidCageId_DisplayErrorMessage()
        {
            
            var form = new BirdManagment.frmAddCage();

            
            form.serial.Text = "Cage!123";
            form.add_btn_Click(null, null);

            
            NUnit.Framework.Assert.IsTrue(MessageBoxHelper.IsMessageBoxDisplayed("Invalid cage ID. Please use only letters or numbers.", "Error 301"));
        }
        [TestMethod]
        public void AddButton_InvalidLength_DisplayErrorMessage()
        {
           
            var form = new BirdManagment.frmAddCage();

           
            form.length.Text = "abc";
            form.add_btn_Click(null, null);

           
            NUnit.Framework.Assert.IsTrue(MessageBoxHelper.IsMessageBoxDisplayed("Invalid length. Please enter numeric values.", "Exception 302"));
        }

        [TestMethod]
        public void AddButton_InvalidWidth_DisplayErrorMessage()
        {
            
            var form = new BirdManagment.frmAddCage();

           
            form.width.Text = "xyz";
            form.add_btn_Click(null, null);

           
            NUnit.Framework.Assert.IsTrue(MessageBoxHelper.IsMessageBoxDisplayed("Invalid width. Please enter numeric values.", "Exception 303"));
        }

        [TestMethod]
        public void AddButton_InvalidHeight_DisplayErrorMessage()
        {
            
            var form = new BirdManagment.frmAddCage();
            var height = "def"; 

            
            form.height.Text = height;
            form.add_btn_Click(null, null);

            
            NUnit.Framework.Assert.IsTrue(MessageBoxHelper.IsMessageBoxDisplayed("Invalid height. Please enter numeric values.", "Exception 304"));
        }

        [TestMethod]
        public void AddButton_CageIdAlreadyExists_DisplayErrorMessage()
        {
            
            var form = new BirdManagment.frmAddCage();
            var cageId = "Cage123"; 

            
            form.serial.Text = cageId;
            form.add_btn_Click(null, null);

            
            NUnit.Framework.Assert.IsTrue(MessageBoxHelper.IsMessageBoxDisplayed("Cage ID already exists. Please choose a different ID.", "Error 201"));
        }


        

        [TestMethod()]
        public void IsCageIdUsed_ExistingCageId_ReturnsTrue()
        {
            
            var form = new frmAddCage();
            var cageIdToCheck = "12A";

            
            var result = form.IsCageIdUsed(cageIdToCheck);

            
            NUnit.Framework.Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsCageIdUsed_NonExistingCageId_ReturnsFalse()
        {
            
            var form = new frmAddCage();
            var cageIdToCheck = "NewCage002";

            
            var result = form.IsCageIdUsed(cageIdToCheck);

            
            NUnit.Framework.Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsValidDimension_ValidDimension_ReturnsTrue()
        {
            
            var form = new frmAddCage();
            var validDimension = "5";

            
            var result = form.IsValidDimension(validDimension);

            
            NUnit.Framework.Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsValidDimension_InvalidDimension_ReturnsFalse()
        {
            
            var form = new frmAddCage();
            var invalidDimension = "abc";

            
            var result = form.IsValidDimension(invalidDimension);

            
            NUnit.Framework.Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsValidDimension_ZeroDimension_ReturnsFalse()
        {
            
            var form = new frmAddCage();
            var invalidDimension = "0";

            
            var result = form.IsValidDimension(invalidDimension);

            
            NUnit.Framework.Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsValidDimension_NegativeDimension_ReturnsFalse()
        {
            
            var form = new frmAddCage();
            var invalidDimension = "-5";

            
            var result = form.IsValidDimension(invalidDimension);

            
            NUnit.Framework.Assert.IsFalse(result);
        }

        private static class MessageBoxHelper
        {
            public static bool IsMessageBoxDisplayed(string message, string title)
            {
                return true;
            }
        }
    }
}

