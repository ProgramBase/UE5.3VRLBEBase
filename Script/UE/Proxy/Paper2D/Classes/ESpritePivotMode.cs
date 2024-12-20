﻿using Script.CoreUObject;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.ESpritePivotMode")]
	public enum ESpritePivotMode : byte
	{
		Top_Left = 0,
		Top_Center = 1,
		Top_Right = 2,
		Center_Left = 3,
		Center_Center = 4,
		Center_Right = 5,
		Bottom_Left = 6,
		Bottom_Center = 7,
		Bottom_Right = 8,
		Custom = 9,
	}
}