﻿using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkeletalMeshOptimizationImportance")]
	public enum SkeletalMeshOptimizationImportance : byte
	{
		SMOI_Off = 0,
		SMOI_Lowest = 1,
		SMOI_Low = 2,
		SMOI_Normal = 3,
		SMOI_High = 4,
		SMOI_Highest = 5,
	}
}