﻿using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EDynamicMeshSculptBrushType")]
	public enum EDynamicMeshSculptBrushType : byte
	{
		Move = 0,
		PullKelvin = 1,
		PullSharpKelvin = 2,
		Smooth = 3,
		Offset = 4,
		SculptView = 5,
		SculptMax = 6,
		Inflate = 7,
		ScaleKelvin = 8,
		Pinch = 9,
		TwistKelvin = 10,
		Flatten = 11,
		Plane = 12,
		PlaneViewAligned = 13,
		FixedPlane = 14,
		Resample = 15,
		LastValue = 16,
	}
}