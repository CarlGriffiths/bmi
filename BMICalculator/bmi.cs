// model classes for BMI calculator
// GC
//

using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;


namespace BMICalculator

{

    public enum BMICategory { Underweight, Normal, Overweight, Obese };

    public class BMI
    {
        const double UnderWeightUpperLimit = 18.4;              // inclusive upper limit
        const double NormalWeightUpperLimit = 24.9;
        const double OverWeightUpperLimit = 29.9;               // Obese from 30 +

        // conversion factors from imperial to metric
        const double PoundsToKgs = 0.453592;
        const double InchestoMetres = 0.0254;

        [Display(Name = "Weight - Stones")]
        [Range(5, 50, ErrorMessage = "Stones must be between 5 and 50")]                              // max 50 stone
        public int WeightStones { get; set; }

        [Display(Name = "Pounds")]
        [Range(0, 13, ErrorMessage = "Pounds must be between 0 and 13")]                              // 14 lbs in a stone
        public int WeightPounds { get; set; }

        [Display(Name = "Height - Feet")]
        [Range(4, 7, ErrorMessage = "Feet must be between 4 and 7")]                               // max 7 feet
        public int HeightFeet { get; set; }

        [Display(Name = "Inches")]
        [Range(0, 11, ErrorMessage = "Inches must be between 0 and 11")]                              // 12 inches in a foot
        public int HeightInches { get; set; }


        //additional feature

        //number of people overweight
        public static int NumOverweight { get; set; } = 0;

        //number of people underweight
        public static int NumUnderWeight { get; set; } = 0;

        //number of people obese
        public static int NumObeseWeight { get; set; } = 0;

        public BMICategory GetTheCat { get; set; }



        //number of people obese
        public static int NumNormalWeight { get; set; } = 0;

        // calculate BMI, display to 2 decimal places
        [Display(Name = "Your BMI is")]
        [DisplayFormat(DataFormatString = "{0:F2}")]

        [ExcludeFromCodeCoverage]
        public double BMIValue
        {
            get
            {
                // bmi = weight in Kgs / height in metres squared

                double totalWeightInPounds = (WeightStones * 14) + WeightPounds;
                double totalHeightInInches = (HeightFeet * 12) + HeightInches;

                // do conversions to metric
                double totalWeightInKgs = totalWeightInPounds * PoundsToKgs;
                double totalHeightInMetres = totalHeightInInches * InchestoMetres;

                double bmi = totalWeightInKgs / (Math.Pow(totalHeightInMetres, 2));
                System.Diagnostics.Debug.WriteLine("test");

                return bmi;
            }
        }

        // calculate BMI category 
        [Display(Name = "Your BMI Category is")]
        public BMICategory BMICategory
        {
            get
            {
                double bmi = this.BMIValue;

                System.Diagnostics.Debug.WriteLine("innnnnnnn");


                // calculate BMI category based on upper limits
                if (bmi <= UnderWeightUpperLimit)
                {

                    //NumUnderWeight = NumUnderWeight + 1;
                    GetTheCat = BMICategory.Underweight;
                    return BMICategory.Underweight;
                }
                else if (bmi <= NormalWeightUpperLimit)
                {
                    //NumNormalWeight++;
                    GetTheCat = BMICategory.Normal;
                    return BMICategory.Normal;
                }
                else if (bmi <= OverWeightUpperLimit)
                {
                    //NumOverweight++;
                    GetTheCat = BMICategory.Overweight;
                    return BMICategory.Overweight;
                }
                else
                {
                    //NumObeseWeight++;
                    GetTheCat = BMICategory.Obese;
                    return BMICategory.Obese;
                }
            }
        }

        
        public int GetNumInCat
        {
            get
            {
                if (GetTheCat == BMICategory.Underweight)
                {
                    NumUnderWeight++;
                    return NumUnderWeight;
                }

                else if (GetTheCat == BMICategory.Normal)
                {
                    NumNormalWeight++;
                    return NumNormalWeight;
                }

                else if (GetTheCat == BMICategory.Overweight)
                {
                    NumOverweight++;
                    return NumOverweight;
                }
                else
                {
                    NumObeseWeight++;
                    return NumObeseWeight;
                }

            }


        }
       
        //public string getNumbers
        //{
         //   get
         //   {
         //       return "Number of underweight = " + NumUnderWeight + "Number of normal = " + NumNormalWeight + "Number of overweight = " + NumOverweight + "Number of obese = " + NumObeseWeight;

         //   }
        //}
    }
}

