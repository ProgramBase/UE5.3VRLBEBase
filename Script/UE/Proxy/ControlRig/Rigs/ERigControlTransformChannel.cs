﻿using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ERigControlTransformChannel")]
	public enum ERigControlTransformChannel : byte
	{
		TranslationX = 0,
		TranslationY = 1,
		TranslationZ = 2,
		Pitch = 3,
		Yaw = 4,
		Roll = 5,
		ScaleX = 6,
		ScaleY = 7,
		ScaleZ = 8,
	}
}