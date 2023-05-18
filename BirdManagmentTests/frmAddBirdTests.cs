//using BirdManagment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdManagment.Tests
{

    [TestClass()]
    public class FrmAddBirdTests
    {
        [TestMethod()]
        public void HeadGeneticCalcTest()
        {
            BirdManagment.frmAddBird frmAddBirdInstance = new BirdManagment.frmAddBird();

            //start
            
            string breastmom = "BreastMomColor";
            string breastdad = "BreastDadColor";
            string bodymom = "BodyMomColor";
            string bodydad = "BodyDadColor";
            string gender = "Male";

            string BabyHeadColor = "";
            string BabyBreastColor = "";
            string BabyBodyColor = "";

            //MaleBird
            frmAddBirdInstance.GeneticCalc("Red", "Red", breastmom, breastdad, bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyHeadColor, "Red");

            frmAddBirdInstance.GeneticCalc("Black", "Red", breastmom, breastdad, bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyHeadColor, "Red");

            frmAddBirdInstance.GeneticCalc("Red", "Black", breastmom, breastdad, bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyHeadColor, "Red");

            frmAddBirdInstance.GeneticCalc("Black", "Black", breastmom, breastdad, bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyHeadColor, "Black");

            //FemaleBird
            gender = "Female";
            frmAddBirdInstance.GeneticCalc("Red", "Red", breastmom, breastdad, bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyHeadColor, "Red");

            frmAddBirdInstance.GeneticCalc("Black", "Red", breastmom, breastdad, bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyHeadColor, "Red");

            frmAddBirdInstance.GeneticCalc("Red", "Black", breastmom, breastdad, bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyHeadColor, "Black");

            frmAddBirdInstance.GeneticCalc("Black", "Black", breastmom, breastdad, bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyHeadColor, "Black");
        }

        [TestMethod()]
        public void BreastGeneticCalcTest()
        {
            BirdManagment.frmAddBird frmAddBirdInstance = new BirdManagment.frmAddBird();


            string headmom = "HeadMomColor";
            string headdad = "HeadDadColor";
            
            string bodymom = "BodyMomColor";
            string bodydad = "BodyDadColor";
            string gender = "Male";

            string BabyHeadColor = "";
            string BabyBreastColor = "";
            string BabyBodyColor = "";

            //MaleBird
            frmAddBirdInstance.GeneticCalc(headmom, headdad, "Purple", "Purple", bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBreastColor, "Purple");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, "Lilach", "Lilach", bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBreastColor, "Lilach");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, "White", "White", bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBreastColor, "White");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, "Lilach", "Purple", bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBreastColor, "Purple");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, "Purple", "Lilach", bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBreastColor, "Purple");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, "White", "Purple", bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBreastColor, "Purple");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, "Purple", "White", bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBreastColor, "Purple");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, "Lilach", "White", bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBreastColor, "Lilach");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, "White", "Lilach", bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBreastColor, "Lilach");


            //FemaleBird
            gender = "Female";
            frmAddBirdInstance.GeneticCalc(headmom, headdad, "Purple", "Purple", bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBreastColor, "Purple");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, "Lilach", "Lilach", bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBreastColor, "Lilach");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, "White", "White", bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBreastColor, "White");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, "Lilach", "Purple", bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBreastColor, "Purple");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, "Purple", "Lilach", bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBreastColor, "Purple");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, "White", "Purple", bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBreastColor, "Purple");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, "Purple", "White", bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBreastColor, "Purple");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, "Lilach", "White", bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBreastColor, "Lilach");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, "White", "Lilach", bodymom, bodydad, gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBreastColor, "Lilach");
        }

        [TestMethod()]
        public void BodyGeneticCalcTest()
        {
            BirdManagment.frmAddBird frmAddBirdInstance = new BirdManagment.frmAddBird();


            string headmom = "HeadMomColor";
            string headdad = "HeadDadColor";
            string breastmom = "BreastMomColor";
            string breastdad = "BreastDadColor";
            
            string gender = "Male";

            string BabyHeadColor = "";
            string BabyBreastColor = "";
            string BabyBodyColor = "";

            //MaleBird
            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "Green", "Green", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "Green");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "Green", "White", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "Pastel");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "White", "Green", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "Pastel");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "White", "White", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "White");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "Blue", "Blue", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "Blue");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "Blue", "Green", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "Blue");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "Blue", "White", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "Silver");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "Blue", "Pastel", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "Blue Pastel");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "Green", "Blue", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "Blue");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "White", "Blue", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "Silver");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "Pastel", "Blue", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "Blue Pastel");


            //FemaleBird
            gender = "Female";
            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "Green", "Green", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "Green");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "Green", "White", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "White");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "White", "Green", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "Green");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "White", "White", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "White");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "Blue", "Blue", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "Blue");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "Blue", "Green", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "Blue");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "Blue", "White", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "Silver");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "Blue", "Pastel", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "Blue Pastel");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "Green", "Blue", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "Blue");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "White", "Blue", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "Silver");

            frmAddBirdInstance.GeneticCalc(headmom, headdad, breastmom, breastdad, "Pastel", "Blue", gender, ref BabyHeadColor, ref BabyBreastColor, ref BabyBodyColor);
            Assert.AreEqual(BabyBodyColor, "Blue Pastel");
        }
    }
}