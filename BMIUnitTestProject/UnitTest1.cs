using Microsoft.VisualStudio.TestTools.UnitTesting;

using BMICalculator;
using System;

namespace BMIUnitTestProject
{
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
        public void TestBMICategoryOverweightIncrease()
        {
            int beforeIncrease = BMI.NumOverweight;
            BMI bmi = new BMI() { WeightStones = 14, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };

            Assert.AreNotEqual(bmi.BMICategory, bmi.GetNumCat);

            Assert.AreEqual(beforeIncrease + 1, BMI.NumOverweight);
        }

        [TestMethod]
        public void TestBMICategoryUnderweightIncrease()
        {
            int beforeIncrease = BMI.NumUnderWeight;
            BMI bmi = new BMI() { WeightStones = 6, WeightPounds = 0, HeightFeet = 6, HeightInches = 6 };
            Assert.AreNotEqual(bmi.BMICategory, bmi.GetNumCat);
            
            Assert.AreEqual(beforeIncrease + 1, BMI.NumUnderWeight);
        }


    }
}
