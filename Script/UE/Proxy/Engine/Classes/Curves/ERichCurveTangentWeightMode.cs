﻿using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERichCurveTangentWeightMode")]
	public enum ERichCurveTangentWeightMode : byte
	{
		RCTWM_WeightedNone = 0,
		RCTWM_WeightedArrive = 1,
		RCTWM_WeightedLeave = 2,
		RCTWM_WeightedBoth = 3,
	}
}