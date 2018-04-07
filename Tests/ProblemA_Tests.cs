using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem = ContestSolutions.ProblemA;

namespace Tests
{
    [TestClass]
    public class ProblemA_Tests
    {
        [TestMethod]
        public void CaseA01()
        {
            var res = Problem.Solve(1, "CS");
            Assert.AreEqual(res, 1);
        }
        [TestMethod]
        public void CaseA02()
        {
            var res = Problem.Solve(2, "CS");
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void CaseA03()
        {
            var res = Problem.Solve(1, "SS");
            Assert.IsNull(res);
        }
        [TestMethod]
        public void CaseA04()
        {
            var res = Problem.Solve(6, "SCCSSC");
            Assert.AreEqual(res, 2);
        }
        [TestMethod]
        public void CaseA05()
        {
            var res = Problem.Solve(2, "CC");
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void CaseA06()
        {
            var res = Problem.Solve(3, "CSCSS");
            Assert.AreEqual(res, 5);
        }
        [TestMethod]
        public void CaseA07()
        {
            var res = Problem.Solve(1, "SSSCCC");
            Assert.IsNull(res);
        }
        [TestMethod]
        public void CaseA08()
        {
            var res = Problem.Solve(1, "CCCS");
            Assert.AreEqual(res, 3);
        }
        [TestMethod] public void CaseA09()
        {
            var res = Problem.Solve(2, "CCCS");
            Assert.AreEqual(res, 2);
        }
        //[TestMethod] public void CaseA10() { }
        //[TestMethod] public void CaseA11() { }
        //[TestMethod] public void CaseA12() { }
        //[TestMethod] public void CaseA13() { }
        //[TestMethod] public void CaseA14() { }
        //[TestMethod] public void CaseA15() { }
        //[TestMethod] public void CaseA16() { }
        //[TestMethod] public void CaseA17() { }
        //[TestMethod] public void CaseA18() { }
        //[TestMethod] public void CaseA19() { }
        //[TestMethod] public void CaseA20() { }
        //[TestMethod] public void CaseA21() { }
        //[TestMethod] public void CaseA22() { }
        //[TestMethod] public void CaseA23() { }
        //[TestMethod] public void CaseA24() { }
        //[TestMethod] public void CaseA25() { }
        //[TestMethod] public void CaseA26() { }
        //[TestMethod] public void CaseA27() { }
        //[TestMethod] public void CaseA28() { }
        //[TestMethod] public void CaseA29() { }
        //[TestMethod] public void CaseA30() { }
        //[TestMethod] public void CaseA31() { }
        //[TestMethod] public void CaseA32() { }
        //[TestMethod] public void CaseA33() { }
        //[TestMethod] public void CaseA34() { }
        //[TestMethod] public void CaseA35() { }
        //[TestMethod] public void CaseA36() { }
        //[TestMethod] public void CaseA37() { }
        //[TestMethod] public void CaseA38() { }
        //[TestMethod] public void CaseA39() { }
        //[TestMethod] public void CaseA40() { }
        //[TestMethod] public void CaseA41() { }
        //[TestMethod] public void CaseA42() { }
        //[TestMethod] public void CaseA43() { }
        //[TestMethod] public void CaseA44() { }
        //[TestMethod] public void CaseA45() { }
        //[TestMethod] public void CaseA46() { }
        //[TestMethod] public void CaseA47() { }
        //[TestMethod] public void CaseA48() { }
        //[TestMethod] public void CaseA49() { }
        //[TestMethod] public void CaseA50() { }
        //[TestMethod] public void CaseA51() { }
        //[TestMethod] public void CaseA52() { }
        //[TestMethod] public void CaseA53() { }
        //[TestMethod] public void CaseA54() { }
        //[TestMethod] public void CaseA55() { }
        //[TestMethod] public void CaseA56() { }
        //[TestMethod] public void CaseA57() { }
        //[TestMethod] public void CaseA58() { }
        //[TestMethod] public void CaseA59() { }
        //[TestMethod] public void CaseA60() { }
        //[TestMethod] public void CaseA61() { }
        //[TestMethod] public void CaseA62() { }
        //[TestMethod] public void CaseA63() { }
        //[TestMethod] public void CaseA64() { }
        //[TestMethod] public void CaseA65() { }
        //[TestMethod] public void CaseA66() { }
        //[TestMethod] public void CaseA67() { }
        //[TestMethod] public void CaseA68() { }
        //[TestMethod] public void CaseA69() { }
        //[TestMethod] public void CaseA70() { }
        //[TestMethod] public void CaseA71() { }
        //[TestMethod] public void CaseA72() { }
        //[TestMethod] public void CaseA73() { }
        //[TestMethod] public void CaseA74() { }
        //[TestMethod] public void CaseA75() { }
        //[TestMethod] public void CaseA76() { }
        //[TestMethod] public void CaseA77() { }
        //[TestMethod] public void CaseA78() { }
        //[TestMethod] public void CaseA79() { }
        //[TestMethod] public void CaseA80() { }
        //[TestMethod] public void CaseA81() { }
        //[TestMethod] public void CaseA82() { }
        //[TestMethod] public void CaseA83() { }
        //[TestMethod] public void CaseA84() { }
        //[TestMethod] public void CaseA85() { }
        //[TestMethod] public void CaseA86() { }
        //[TestMethod] public void CaseA87() { }
        //[TestMethod] public void CaseA88() { }
        //[TestMethod] public void CaseA89() { }
        //[TestMethod] public void CaseA90() { }
        //[TestMethod] public void CaseA91() { }
        //[TestMethod] public void CaseA92() { }
        //[TestMethod] public void CaseA93() { }
        //[TestMethod] public void CaseA94() { }
        //[TestMethod] public void CaseA95() { }
        //[TestMethod] public void CaseA96() { }
        //[TestMethod] public void CaseA97() { }
        //[TestMethod] public void CaseA98() { }
        //[TestMethod] public void CaseA99() { }
    }
}
