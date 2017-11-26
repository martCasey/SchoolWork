/* Name: Martin Casey
 * Date: 16/11/2017
 * X-number: X00119025
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCA            //Q.5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()       //check if lower limit is not greater than upper limit
        {
            RadioStation radio = new RadioStation();
            radio.FMFrequencyBand = { 89, 90}
            if(radio.FMFrequencyBand.Upper < radio.FMFrequencyBand.Lower)
            {
                Assert(false);
            }
            Assert(true);
        }

        public void TestMethod2()           //Test if radio station was liked
        {
            RadaioApp radioApp = new RadaioApp();
            radioApp.collectionOfSations = { RadioStation("bigRadio", "Music", FMFrequency{ 90, 110}), RadioStation("smallRadio", "News", FMFrequency{ 80, 90})};
            radio.Like("bigRadio");
            if(radio.favoriteStations.FirstOrDefault.RadioStationName.Assert.Equals("bigRadio"))
            {
                Assert("Station was liked", true)
            }
            else
            {
                Assert(false);
            }
        }

        public void TestMethod3()           //Test for single radio frequency
        {
            RadioStation radioStation = new RadioStation("mediumRadio", "Music", FMFrequency{ 85, null});
            if(radioStation == AssertFailedException)
            {
                Assert(false);
            }
            else
            {
                Assert(true);
            }
        }

        public void TestMethod4()       //Check if stations are stored in collection
        {
            RadioApp radioApp = new RadioApp();
            radioApp.collectionofSations.Add(RadioStation("bigRadio", "Music", FMFrequency{ 90, 110}));
            radioApp.collectionofSations.Add(RadioStation("smallRadio", "News", FMFrequency{ 80, 90}));
            if(radioApp.collectionofStations == AssertFailedException)
            {
                Assert(false);
            }
            else
            {
                Assert(true);
            }
        }
    }
}
