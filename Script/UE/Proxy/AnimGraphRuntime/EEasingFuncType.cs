﻿using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.EEasingFuncType")]
	public enum EEasingFuncType : byte
	{
		Linear = 0,
		Sinusoidal = 1,
		Cubic = 2,
		QuadraticInOut = 3,
		CubicInOut = 4,
		HermiteCubic = 5,
		QuarticInOut = 6,
		QuinticInOut = 7,
		CircularIn = 8,
		CircularOut = 9,
		CircularInOut = 10,
		ExpIn = 11,
		ExpOut = 12,
		ExpInOut = 13,
		CustomCurve = 14,
	}
}