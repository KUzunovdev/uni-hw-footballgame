using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_hw
{
    public class Goal
    {
        private int minute;

        public int Minute
        {
            get { return minute; }
            set
            {
                if (value < 0 || value > 90)
                {
                    throw new ArgumentException("Minute must be between 0 and 90.");
                }
                minute = value;
            }
        }

        public Player Player { get; set; }
    }
}
