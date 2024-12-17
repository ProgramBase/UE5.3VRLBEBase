﻿using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EParticleSortMode")]
	public enum EParticleSortMode : byte
	{
		PSORTMODE_None = 0,
		PSORTMODE_ViewProjDepth = 1,
		PSORTMODE_DistanceToView = 2,
		PSORTMODE_Age_OldestFirst = 3,
		PSORTMODE_Age_NewestFirst = 4,
	}
}