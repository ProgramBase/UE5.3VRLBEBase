﻿using Script.CoreUObject;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.ETransitionGetter")]
	public enum ETransitionGetter : byte
	{
		AnimationAsset_GetCurrentTime = 0,
		AnimationAsset_GetLength = 1,
		AnimationAsset_GetCurrentTimeFraction = 2,
		AnimationAsset_GetTimeFromEnd = 3,
		AnimationAsset_GetTimeFromEndFraction = 4,
		CurrentState_ElapsedTime = 5,
		CurrentState_GetBlendWeight = 6,
		CurrentTransitionDuration = 7,
		ArbitraryState_GetBlendWeight = 8,
	}
}