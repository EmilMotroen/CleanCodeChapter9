using CleanCodeChapter9;

namespace TestEnvironmentController
{
    [TestClass]
    public class TestEnvironmentController
    {
        EnvironmentController hw = new EnvironmentController();

        [TestMethod]
        public void TurnOnLoTempAlarmAtThreshold()
        {
            hw.SetTemp("WAY_TOO_COLD");
            //controller.tic();
            Assert.IsTrue(hw.HeaterState());
            Assert.IsTrue(hw.BlowerState());
            Assert.IsFalse(hw.CoolerState());
            Assert.IsFalse(hw.HiTempAlarm());
            Assert.IsTrue(hw.LoTempAlarm());

        }
    }
}