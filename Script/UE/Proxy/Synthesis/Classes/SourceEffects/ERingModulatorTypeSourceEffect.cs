﻿using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ERingModulatorTypeSourceEffect")]
	public enum ERingModulatorTypeSourceEffect : byte
	{
		Sine = 0,
		Saw = 1,
		Triangle = 2,
		Square = 3,
		Count = 4,
	}
}