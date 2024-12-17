﻿using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EObjectStateTypeEnum")]
	public enum EObjectStateTypeEnum : byte
	{
		Chaos_NONE = 0,
		Chaos_Object_Sleeping = 1,
		Chaos_Object_Kinematic = 2,
		Chaos_Object_Static = 3,
		Chaos_Object_Dynamic = 4,
		Chaos_Object_UserDefined = 100,
		Chaos_Max = 101,
	}
}