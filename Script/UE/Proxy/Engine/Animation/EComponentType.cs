﻿using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EComponentType")]
	public enum EComponentType : byte
	{
		None = 0,
		TranslationX = 1,
		TranslationY = 2,
		TranslationZ = 3,
		RotationX = 4,
		RotationY = 5,
		RotationZ = 6,
		Scale = 7,
		ScaleX = 8,
		ScaleY = 9,
		ScaleZ = 10,
	}
}