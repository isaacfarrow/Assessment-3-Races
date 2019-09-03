using System;
using CSharpClassMovingMonsters;
using CSharpClassMovingMonsters.Business.AllPunters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MonstersUnitTest
{
    [TestClass]
    public class UnitTest1
    {

        // make an instance of the form
        Home myForm1 = new Home();
        Punter[] myPunter = new Punter[2];

        [TestMethod]
        //test if true
        public void TestLoadPunters()
        {
            //act
            myPunter[0] = Factory.GetAPunter(0);
            //assert
            Assert.AreEqual("Howard", myPunter[0].PunterName);

        }

        [TestMethod]
        //Tests if false
        public void TestLoadPuntersFalse()
        {
            //act
            myPunter[0] = Factory.GetAPunter(1);
            //assert
            Assert.AreEqual("Howard", myPunter[0].PunterName);

        }

    }
}
