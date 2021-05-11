using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasterMind.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMind.Resources.Tests
{
    [TestClass()]
    public class MastermindTests
    {
        [TestMethod()]
        public void GetHintsTest()
        {
            var expect = new List<ResultPeg> { ResultPeg.White, ResultPeg.White};
           
            var get = new Mastermind(new List<CodePeg> { CodePeg.Black, CodePeg.Blue, CodePeg.Green, CodePeg.Yellow });
            var result =  get.GetHints(new List<CodePeg> { CodePeg.Green, CodePeg.Black, CodePeg.White, CodePeg.White });

            CollectionAssert.AreEqual(expect,result);



          
        }
    }
}
