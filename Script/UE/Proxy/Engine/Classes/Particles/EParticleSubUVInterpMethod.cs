﻿using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EParticleSubUVInterpMethod")]
	public enum EParticleSubUVInterpMethod : byte
	{
		PSUVIM_None = 0,
		PSUVIM_Linear = 1,
		PSUVIM_Linear_Blend = 2,
		PSUVIM_Random = 3,
		PSUVIM_Random_Blend = 4,
	}
}