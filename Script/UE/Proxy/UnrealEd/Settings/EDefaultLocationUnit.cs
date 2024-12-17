﻿using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EDefaultLocationUnit")]
	public enum EDefaultLocationUnit : long
	{
		Micrometers = 0,
		Millimeters = 1,
		Centimeters = 2,
		Meters = 3,
		Kilometers = 4,
		Inches = 5,
		Feet = 6,
		Yards = 7,
		Miles = 8,
		Invalid = 9,
	}
}