using Microsoft.VisualStudio.TestTools.UnitTesting;

using BMICalculator;
using System;
using System.Diagnostics.CodeAnalysis;

namespace BMIUnitTestProject
{
    [ExcludeFromCodeCoverage]

    [TestClass]
    public class UnitTest1
    {
   
        [TestMethod]
        public void TestBMICategoryNormal()
        {
            BMI bmi = new BMI() { WeightStones = 12, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Normal);
        }

        [TestMethod]
        public void TestBMICategoryUnderweight()
        {
            BMI bmi = new BMI() { WeightStones = 5, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Underweight);
        }

        [TestMethod]
        public void TestBMICategoryObese()
        {
            BMI bmi = new BMI() { WeightStones = 40, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Obese);
        }

         [TestMethod]
        public void TestBMICategoryOverweight()
        {
            
            BMI bmi = new BMI() { WeightStones = 14, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Overweight);
            
        }

        [TestMethod]
        public void TestBMIWeight()
        {
            
            BMI bmi = new BMI() { WeightStones = 6, WeightPounds = 0, HeightFeet = 6, HeightInches = 6 };
            //Assert.AreNotEqual(bmi.BMICategory, bmi.GetNumCat);
            Assert.AreEqual(bmi.WeightStones, 6);
            Assert.AreEqual(bmi.WeightPounds, 0);
        }

     
        [TestMethod]
        public void TestBMIHeight()
        {
            BMI bmi = new BMI() { WeightStones = 6, WeightPounds = 0, HeightFeet = 6, HeightInches = 6 };
            //Assert.AreNotEqual(bmi.BMICategory, bmi.GetNumCat);
            Assert.AreEqual(bmi.HeightFeet, 6);
            Assert.AreEqual(bmi.HeightInches, 6);
        }


        //added feature test
        [TestMethod]
        public void TestBMIMessage()
        {
            BMI bmi = new BMI() { WeightStones = 50, WeightPounds = 0, HeightFeet = 6, HeightInches = 6 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Obese);
            Assert.AreEqual(bmi.Message, "Please consult a doctor");
        }




    }
}
