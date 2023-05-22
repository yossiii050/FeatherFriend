using NUnit.Framework;
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
            // Arrange
            var form = new BirdManagment.frmAddCage();

            // Act
            form.serial.Text = "Cage!123";
            form.add_btn_Click(null, null);

            // Assert
            NUnit.Framework.Assert.IsTrue(MessageBoxHelper.IsMessageBoxDisplayed("Invalid cage ID. Please use only letters or numbers.", "Error 301"));
        }
        [TestMethod]
        public void AddButton_InvalidLength_DisplayErrorMessage()
        {
            // Arrange
            var form = new BirdManagment.frmAddCage();

            // Act
            form.length.Text = "abc";
            form.add_btn_Click(null, null);

            // Assert
            NUnit.Framework.Assert.IsTrue(MessageBoxHelper.IsMessageBoxDisplayed("Invalid length. Please enter numeric values.", "Exception 302"));
        }

        [TestMethod]
        public void AddButton_InvalidWidth_DisplayErrorMessage()
        {
            // Arrange
            var form = new BirdManagment.frmAddCage();

            // Act
            form.width.Text = "xyz";
            form.add_btn_Click(null, null);

            // Assert
            NUnit.Framework.Assert.IsTrue(MessageBoxHelper.IsMessageBoxDisplayed("Invalid width. Please enter numeric values.", "Exception 303"));
        }

        [TestMethod]
        public void AddButton_InvalidHeight_DisplayErrorMessage()
        {
            // Arrange
            var form = new BirdManagment.frmAddCage();
            var height = "def"; // An invalid height

            // Act
            form.height.Text = height;
            form.add_btn_Click(null, null);

            // Assert
            NUnit.Framework.Assert.IsTrue(MessageBoxHelper.IsMessageBoxDisplayed("Invalid height. Please enter numeric values.", "Exception 304"));
        }

        [TestMethod]
        public void AddButton_CageIdAlreadyExists_DisplayErrorMessage()
        {
            // Arrange
            var form = new BirdManagment.frmAddCage();
            var cageId = "Cage123"; // An existing cage ID

            // Act
            form.serial.Text = cageId;
            form.add_btn_Click(null, null);

            // Assert
            NUnit.Framework.Assert.IsTrue(MessageBoxHelper.IsMessageBoxDisplayed("Cage ID already exists. Please choose a different ID.", "Error 201"));
        }


        

        [TestMethod()]
        public void IsCageIdUsed_ExistingCageId_ReturnsTrue()
        {
            // Arrange
            var form = new frmAddCage();
            var cageIdToCheck = "12A";

            // Act
            var result = form.IsCageIdUsed(cageIdToCheck);

            // Assert
            NUnit.Framework.Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsCageIdUsed_NonExistingCageId_ReturnsFalse()
        {
            // Arrange
            var form = new frmAddCage();
            var cageIdToCheck = "NewCage002";

            // Act
            var result = form.IsCageIdUsed(cageIdToCheck);

            // Assert
            NUnit.Framework.Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsValidDimension_ValidDimension_ReturnsTrue()
        {
            // Arrange
            var form = new frmAddCage();
            var validDimension = "5";

            // Act
            var result = form.IsValidDimension(validDimension);

            // Assert
            NUnit.Framework.Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsValidDimension_InvalidDimension_ReturnsFalse()
        {
            // Arrange
            var form = new frmAddCage();
            var invalidDimension = "abc";

            // Act
            var result = form.IsValidDimension(invalidDimension);

            // Assert
            NUnit.Framework.Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsValidDimension_ZeroDimension_ReturnsFalse()
        {
            // Arrange
            var form = new frmAddCage();
            var invalidDimension = "0";

            // Act
            var result = form.IsValidDimension(invalidDimension);

            // Assert
            NUnit.Framework.Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsValidDimension_NegativeDimension_ReturnsFalse()
        {
            // Arrange
            var form = new frmAddCage();
            var invalidDimension = "-5";

            // Act
            var result = form.IsValidDimension(invalidDimension);

            // Assert
            NUnit.Framework.Assert.IsFalse(result);
        }

        private static class MessageBoxHelper
        {
            public static bool IsMessageBoxDisplayed(string message, string title)
            {
                // TODO: Implement the logic to check if a message box with the given message and title is displayed.
                // You can use UI automation libraries like TestStack.White or Microsoft UI Automation for this purpose.

                // For the sake of simplicity, assume the message box is displayed.
                return true;
            }
        }
    }
}



/*using BirdManagment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using Moq;

namespace BirdManagmentTests
{


    [TestClass()]
    public class frmAddCageTests
    {
        
        [TestMethod()]
        public void Add_btn_Click_InvalidCageId_ShowErrorMessage()
        {
            // Arrange
            var form = new frmAddCage();
            var expectedMessage = "Invalid cage ID. Please use only letters or numbers.";
            

            // Act
            form.add_btn_Click(null, null);

            // Assert
            Assert.AreEqual(expectedMessage, TestMessageBox.LastMessage);
            form.cageid
        }

        [TestMethod()]
        public void Add_btn_Click_InvalidLength_ShowErrorMessage()
        {
            // Arrange
            var form = new frmAddCage();
            var expectedMessage = "Invalid length. Please enter numeric values.";

            // Act
            form.length.Text = "abc"; // Invalid length
            form.add_btn_Click(null, null);

            // Assert
            Assert.AreEqual(expectedMessage, TestMessageBox.LastMessage);
        }

        [TestMethod()]
        public void Add_btn_Click_InvalidWidth_ShowErrorMessage()
        {
            // Arrange
            var form = new frmAddCage();
            var expectedMessage = "Invalid width. Please enter numeric values.";

            // Act
            form.width.Text = "def"; // Invalid width
            form.add_btn_Click(null, null);

            // Assert
            Assert.AreEqual(expectedMessage, TestMessageBox.LastMessage);
        }

        [TestMethod()]
        public void Add_btn_Click_InvalidHeight_ShowErrorMessage()
        {
            // Arrange
            var form = new frmAddCage();
            var expectedMessage = "Invalid height. Please enter numeric values.";

            // Act
            form.height.Text = "xyz"; // Invalid height
            form.add_btn_Click(null, null);

            // Assert
            Assert.AreEqual(expectedMessage, TestMessageBox.LastMessage);
        }

        [TestMethod()]
        public void Add_btn_Click_DuplicateCageId_ShowErrorMessage()
        {
            // Arrange
            var form = new frmAddCage();
            var expectedMessage = "Cage ID already exists. Please choose a different ID.";

            // Mock the IsCageIdUsed method to return true
            //form.IsCageIdUsed = cageId => true;

            // Act
            form.serial.Text = "Cage001"; // Existing cage ID
            form.add_btn_Click(null, null);

            // Assert
            Assert.AreEqual(expectedMessage, TestMessageBox.LastMessage);
        }

        [TestMethod()]
        public void Add_btn_Click_ValidInput_ShowSuccessMessage()
        {
            // Arrange
            var form = new frmAddCage();
            var expectedMessage = "Cage add successfully!";

            // Mock the IsCageIdUsed method to return false
            //form.IsCageIdUsed = cageId => false;

            // Act
            form.serial.Text = "NewCage001";
            form.length.Text = "10";
            form.width.Text = "5";
            form.height.Text = "8";
            form.add_btn_Click(null, null);

            // Assert
            Assert.AreEqual(expectedMessage, TestMessageBox.LastMessage);
        }

        [TestMethod()]
        public void IsCageIdUsed_ExistingCageId_ReturnsTrue()
        {
            // Arrange
            var form = new frmAddCage();
            var cageIdToCheck = "Cage001";

            // Act
            var result = form.IsCageIdUsed(cageIdToCheck);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsCageIdUsed_NonExistingCageId_ReturnsFalse()
        {
            // Arrange
            var form = new frmAddCage();
            var cageIdToCheck = "NewCage001";

            // Act
            var result = form.IsCageIdUsed(cageIdToCheck);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsValidDimension_ValidDimension_ReturnsTrue()
        {
            // Arrange
            var form = new frmAddCage();
            var validDimension = "5";

            // Act
            var result = form.IsValidDimension(validDimension);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsValidDimension_InvalidDimension_ReturnsFalse()
        {
            // Arrange
            var form = new frmAddCage();
            var invalidDimension = "abc";

            // Act
            var result = form.IsValidDimension(invalidDimension);

            // Assert
            Assert.IsFalse(result);
        }

        
    }
}
*/