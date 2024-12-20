﻿using Script.CoreUObject;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.ERuntimeGenerationType")]
	public enum ERuntimeGenerationType : byte
	{
		Static = 0,
		DynamicModifiersOnly = 1,
		Dynamic = 2,
		LegacyGeneration = 3,
	}
}