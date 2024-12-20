﻿using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESpeedTreeWindType")]
	public enum ESpeedTreeWindType : byte
	{
		STW_None = 0,
		STW_Fastest = 1,
		STW_Fast = 2,
		STW_Better = 3,
		STW_Best = 4,
		STW_Palm = 5,
		STW_BestPlus = 6,
	}
}