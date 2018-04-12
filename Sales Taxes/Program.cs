using System;

namespace Sales_Taxes
{
    class Program
    {
        public class TestCaseResult
        {
            public decimal Taxes { get; set; }
            public decimal TotalPrice { get; set; }
        }
        public class Test
        {
            //Test case1
            public TestCaseResult GetResultForCasee1()
            {
                throw new NotImplementedException();
            }

            public TestCaseResult GetResultForCasee2()
            {
                throw new NotImplementedException();
            }

            public TestCaseResult GetResultForCasee3()
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
            //Test case 1
            var test = new Test();
            var result = test.GetResultForCasee1();
            Assert.AreEqual(1.50m, result.Taxes);
            Assert.AreEqual(29.83m, result.TotalPrice);

            //Test case 2
            result = test.GetResultForCasee2();
            Assert.AreEqual(7.65m, result.Taxes);
            Assert.AreEqual(65.15m, result.TotalPrice);

            //Test case 3
            result = test.GetResultForCasee3();
            Assert.AreEqual(6.70m, result.Taxes);
            Assert.AreEqual(74.68m, result.TotalPrice);
        }
    }
}
