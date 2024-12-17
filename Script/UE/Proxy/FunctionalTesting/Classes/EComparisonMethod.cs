﻿using Script.CoreUObject;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.EComparisonMethod")]
	public enum EComparisonMethod : byte
	{
		Equal_To = 0,
		Not_Equal_To = 1,
		Greater_Than_Or_Equal_To = 2,
		Less_Than_Or_Equal_To = 3,
		Greater_Than = 4,
		Less_Than = 5,
	}
}