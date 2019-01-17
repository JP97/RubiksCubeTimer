using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Timer
    {

		private List<Timer> timers = new List<Timer>();

		private int second;

		public int Second { get { return this.second; } set { this.second = value; } }


    }
}
