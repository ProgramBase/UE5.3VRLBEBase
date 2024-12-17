﻿using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EReverbSendMethod")]
	public enum EReverbSendMethod : byte
	{
		Linear = 0,
		CustomCurve = 1,
		Manual = 2,
	}
}