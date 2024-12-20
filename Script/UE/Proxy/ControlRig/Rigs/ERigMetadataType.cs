﻿using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ERigMetadataType")]
	public enum ERigMetadataType : byte
	{
		Bool = 0,
		BoolArray = 1,
		Float = 2,
		FloatArray = 3,
		Int32 = 4,
		Int32Array = 5,
		Name = 6,
		NameArray = 7,
		Vector = 8,
		VectorArray = 9,
		Rotator = 10,
		RotatorArray = 11,
		Quat = 12,
		QuatArray = 13,
		Transform = 14,
		TransformArray = 15,
		LinearColor = 16,
		LinearColorArray = 17,
		RigElementKey = 18,
		RigElementKeyArray = 19,
		Invalid = 20,
	}
}