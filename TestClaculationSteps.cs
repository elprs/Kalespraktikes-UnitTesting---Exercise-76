using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;//bima a  me deksi click sto refence
using Kalespraktikes_UnitTesting;//bima 2

namespace Kalespraktikes_UnitTesting
{
    //8a testarei olew ti s methods an leitourgoun sosta gia ola ata pi8ana apotelesmata
    [TestClass]
    public class TestClaculationSteps // oli utoi i claass 8a test uti ti function//itteration testin g
    {
        [TestMethod]//decorators
        public void TestCalculateSteps_For1000_600_Res60()
        {
            //autoi mporei na aklesei opoiodipote alli method exo se oppiadipote allo project anf thest if i have right results. // it prosomoionei if a metho dgived the resulats wanted//
            //before i get ther i need to ctrete AAA atchitecture

            // Arrange //auta ta sxolia-titlo ta bazo gia ta AAA
            //Ararnge
            //thleo n aekastaso otan doso tenan ari8mo mou eoistrefei sosta
            //xreaimai oraia onomata

            //bazo ta aparaitit adedomena gia na treksei i sinarthsh

            User u1 = new User();
            string goalSteps = "1000";
            string actualSteps = "600";
            decimal expected = 60M; //ksero ti perimeno. allios de 8a ekan unitTest


            //Act

            decimal actual = u1.CalculateSteps(goalSteps, actualSteps);



            //Assert


            Assert.AreEqual(expected, actual);



        }
        //[TestMethod]
        //public void TestCalculationSteps_For3000_600_Ref20()
        //{
        //    //Arrange
            
        //    User u1 = new User();
        //    string goalSteps = "3000";
        //    string actualSteps = "600";
        //    decimal expected = 20M; //ksero ti perimeno. allios de 8a ekan unitTest


        //    //Act

        //    decimal actual = u1.CalculateSteps(goalSteps, actualSteps);



        //    //Assert


        //    Assert.AreEqual(expected, actual);
        //}


        [TestMethod]
        public void TestCalculationSteps_For1000_100_Ref10()
        {
            //Arrange

            User u1 = new User();
            string goalSteps = "1000";
            string actualSteps = "100";
            decimal expected = 10M; //ksero ti perimeno. allios de 8a ekan unitTest


            //Act

            decimal actual = u1.CalculateSteps(goalSteps, actualSteps);



            //Assert


            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCalculationSteps_For500_60_Ref2_33()
        {
            //Arrange

            User u1 = new User();
            string goalSteps = "3000";
            string actualSteps = "600";
            decimal expected = 20M; //ksero ti perimeno. allios de 8a ekan unitTest


            //Act

            decimal actual = u1.CalculateSteps(goalSteps, actualSteps);



            //Assert


            Assert.AreEqual(expected, actual);
        }


        //[TestMethod]
        //public decimal TestCalculationSteps_For3000_600_Ref20() //px periodikoi ari9moi
        //{
        //    //Arrange

        //    User u1 = new User();
        //    string goalSteps = "3000";
        //    string actualSteps = "600";
        //    decimal expected = 21M; //ksero ti perimeno. allios de 8a ekan unitTest


        //    //Act

        //    decimal actual = u1.CalculateSteps(goalSteps, actualSteps);



        //    //Assert

        //    Assert.AreEqual((double)expected, (double)actual, 2 ); //zitaei 3 double sto precition alla ego exw decimal
        //    //edo de se endiaferei i akribeia ara edo 8a kaneis to casting

        //    Assert.AreEqual(expected, actual);
        //}




        [TestMethod]
        public void TestCalculationSteps_For300_80_Ref26_666()
        {
            //Arrange

            User u1 = new User();
            string goalSteps = "300";
            string actualSteps = "80";
            decimal expected = 26.66M; //26.665 eos 26.667 ora sto xristi de 8a fanei i diafora giati exo ektuposi eos 2 dekadika


            //Act

            decimal actual = u1.CalculateSteps(goalSteps, actualSteps);



            //Assert

            Assert.AreEqual((double)expected, (double)actual, 0.009);  // DES ta giati DEK ta katalabes kala, eleni. px des ti  ua ginei an anti gia 0.009 na baleis 0.001

        }


        public void TestCalcSteps_ForGreterThangoalSteps_1000_1005_Ret_100()
        {
            //Arrange
            //Arrange

            User u1 = new User();
            string goalSteps = "300";
            string actualSteps = "80";
            decimal expected = 26.66M;

            //Act
           

            decimal actual = u1.CalculateSteps(goalSteps, actualSteps);




            //Assert
            Assert.AreEqual(expected, actual);

        } 
        
        
        //public void TestCalcSteps_ForGreterThangoalSteps_1000_1005_Ret_100()
        //{
        //    //Arrange
        //    //Arrange

        //    User u1 = new User();
        //    string goalSteps = "300";
        //    string actualSteps = "80";
        //    decimal expected = 26.66M;

        //    //Act
           

        //    decimal actual = u1.CalculateSteps(goalSteps, actualSteps);




        //    //Assert
        //    Assert.AreEqual(expected, actual);

        //}
        
        public void TestCalcSteps_ForNegativGoalSteps1()
        {
            //Arrange
            //Arrange

            User u1 = new User();
            string goalSteps = "-300";
            string actualSteps = "80";
            decimal expected = -1M;

            //Act
           

            decimal actual = u1.CalculateSteps(goalSteps, actualSteps);




            //Assert
            Assert.AreEqual(expected, actual);

        }public void TestCalcSteps_ForNegativActualSteps2()
        {
            //Arrange
            //Arrange

            User u1 = new User();
            string goalSteps = "300";
            string actualSteps = "-5580";
            decimal expected = -2M;

            //Act
           

            decimal actual = u1.CalculateSteps(goalSteps, actualSteps);




            //Assert
            Assert.AreEqual(expected, actual);

        }public void TestCalcSteps_BothNegative3()
        {
            //Arrange
            //Arrange

            User u1 = new User();
            string goalSteps = "-300";
            string actualSteps = "-5380";
            decimal expected = -3M;

            //Act
           

            decimal actual = u1.CalculateSteps(goalSteps, actualSteps);




            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
