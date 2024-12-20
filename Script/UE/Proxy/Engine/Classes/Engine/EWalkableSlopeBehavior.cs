﻿using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EWalkableSlopeBehavior")]
	public enum EWalkableSlopeBehavior : byte
	{
		WalkableSlope_Default = 0,
		WalkableSlope_Increase = 1,
		WalkableSlope_Decrease = 2,
		WalkableSlope_Unwalkable = 3,
		WalkableSlope_Max = 4,
	}
}