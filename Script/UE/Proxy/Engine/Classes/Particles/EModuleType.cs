﻿using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EModuleType")]
	public enum EModuleType : long
	{
		EPMT_General = 0,
		EPMT_TypeData = 1,
		EPMT_Beam = 2,
		EPMT_Trail = 3,
		EPMT_Spawn = 4,
		EPMT_Required = 5,
		EPMT_Event = 6,
		EPMT_Light = 7,
		EPMT_SubUV = 8,
	}
}