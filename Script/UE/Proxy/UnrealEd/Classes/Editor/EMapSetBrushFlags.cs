﻿using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EMapSetBrushFlags")]
	public enum EMapSetBrushFlags : long
	{
		MSB_BrushColor = 1,
		MSB_Group = 2,
		MSB_PolyFlags = 4,
		MSB_BrushType = 8,
	}
}