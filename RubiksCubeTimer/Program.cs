using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeTimer
{
	class Program
	{
		static void Main(string[] args)
		{
			Program program = new Program();
			program.Run();
		}
		void Run()
		{
			Menu m = new Menu();
			m.Show();
		}
	}
}
