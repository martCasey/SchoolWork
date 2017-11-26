/* Name: Martin Casey
 * Date: 16/11/2017
 * X-number: X00119025
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2_Work
{
    class Program
    {
        interface IStreamable           //Q.1
        {
            void Play();

            void Pause();
        }

        public struct FMFrequencyBand          //structure         //Q.2
        {
            int upperLimit;
            int lowerLimit;

            public int LowerLimit
            {
                get
                {
                    return lowerLimit;
                }
                set
                {
                    lowerLimit = value;
                }
            }

            public int UpperLimit
            {
                get
                {
                    return upperLimit;
                }
                set
                {
                    upperLimit = value;
                    if(upperLimit < lowerLimit)         //stops program if upper limit is less than lower limit
                    {
                        UpperLimit = value;
                    }
                }
            }
        }

        class RadioStation : IStreamable            //Q.3
        {
            public String RadioStationName { get; set; }           //auto-implemented properties
            public String GenreOfContent { get; set; }

            FMFrequencyBand fMFrequencyBand = new FMFrequencyBand { };

            void IStreamable.Play()
            {
                Console.WriteLine("Played");
            }

            void IStreamable.Pause()
            {
                Console.WriteLine("Paused");
            }

            public override string ToString()
            {
                return "Station Name: " + this.RadioStationName +
                       "\nGenere of Content: " + this.GenreOfContent +
                       "\nFM Frequency Range: " + this.fMFrequencyBand.LowerLimit + " - " + this.fMFrequencyBand.UpperLimit +
                       "\n";
            }
        }

        class RadioPlayerApp            //Q.4
        {
            List<RadioStation> collectionOfStations = new List<RadioStation>();         //collection to hold radio station objects

            readonly List<RadioStation> favouriteSations = new List<RadioStation>();

            public void Like(string stationName)            //method to like a radio station
            {
                foreach(RadioStation radio in collectionOfStations)
                {
                    if(radio.RadioStationName == stationName)
                    {
                        favouriteSations.Add(radio);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            RadioPlayerApp radioPlayerApp = new RadioPlayerApp();
            radioPlayerApp.Like("bigRadio");
        }
    }
}
