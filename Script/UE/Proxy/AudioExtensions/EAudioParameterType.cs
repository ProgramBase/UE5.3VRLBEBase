﻿using Script.CoreUObject;

namespace Script.AudioExtensions
{
	[PathName("/Script/AudioExtensions.EAudioParameterType")]
	public enum EAudioParameterType : byte
	{
		None = 0,
		Boolean = 1,
		Integer = 2,
		Float = 3,
		String = 4,
		Object = 5,
		NoneArray = 6,
		BooleanArray = 7,
		IntegerArray = 8,
		FloatArray = 9,
		StringArray = 10,
		ObjectArray = 11,
		Trigger = 12,
		COUNT = 13,
	}
}