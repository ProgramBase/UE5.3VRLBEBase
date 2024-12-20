﻿using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EFieldFilterType")]
	public enum EFieldFilterType : byte
	{
		Field_Filter_Dynamic = 0,
		Field_Filter_Kinematic = 1,
		Field_Filter_Static = 2,
		Field_Filter_All = 3,
		Field_Filter_Sleeping = 4,
		Field_Filter_Disabled = 5,
		Field_Filter_Max = 6,
	}
}