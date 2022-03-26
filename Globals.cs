using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
	class Globals
	{
		public static int globalID { get; private set; }

		public static void SetGlobalID(int id)
		{
			globalID = id;
		}
	}
}
