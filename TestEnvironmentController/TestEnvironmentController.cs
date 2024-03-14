// Listing 9-3 - 9-5

using CleanCodeChapter9;

namespace TestEnvironmentController
{
    [TestClass]
    public class TestEnvironmentController
    {
        EnvironmentController hw = new EnvironmentController();
        Controller controller = new Controller();

        [TestMethod]
        public void TurnOnLoTempAlarmAtThreshold()
        {
            hw.SetTemp("WAY_TOO_COLD");
            controller.tic();
            Assert.IsTrue(hw.HeaterState());
            Assert.IsTrue(hw.BlowerState());
            Assert.IsFalse(hw.CoolerState());
            Assert.IsFalse(hw.HiTempAlarm());
            Assert.IsTrue(hw.LoTempAlarm());

        }

        [TestMethod]
        public void Refactored_TurnOnLoTempAlarmAtThreshold()
        {
            hw.wayTooCold();
            Assert.AreEqual("HBchL", hw.GetState());
        }

        [TestMethod]
        public void TurnOnCoolerAndBlowerIfTooHot()
        {
            hw.TooHot();
            Assert.AreEqual("hBChl", hw.GetState());
        }

        [TestMethod]
        public void TurnOnHeaterAndBlowerIfTooCold()
        {
            hw.TooCold();
            Assert.AreEqual("HBchl", hw.GetState());
        }

        [TestMethod]
        public void TurnOnHiTempAlarmAtThreshold()
        {
            hw.WayTooHot();
            Assert.AreEqual("hBCHl", hw.GetState());
        }

    }
}