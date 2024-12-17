﻿using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ESynthLFOType")]
	public enum ESynthLFOType : byte
	{
		Sine = 0,
		UpSaw = 1,
		DownSaw = 2,
		Square = 3,
		Triangle = 4,
		Exponential = 5,
		RandomSampleHold = 6,
		Count = 7,
	}
}