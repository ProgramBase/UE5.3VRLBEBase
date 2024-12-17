﻿using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EQuartzCommandQuantization")]
	public enum EQuartzCommandQuantization : byte
	{
		Bar = 0,
		Beat = 1,
		ThirtySecondNote = 2,
		SixteenthNote = 3,
		EighthNote = 4,
		QuarterNote = 5,
		HalfNote = 6,
		WholeNote = 7,
		DottedSixteenthNote = 8,
		DottedEighthNote = 9,
		DottedQuarterNote = 10,
		DottedHalfNote = 11,
		DottedWholeNote = 12,
		SixteenthNoteTriplet = 13,
		EighthNoteTriplet = 14,
		QuarterNoteTriplet = 15,
		HalfNoteTriplet = 16,
		Tick = 17,
		Count = 18,
		None = 19,
	}
}