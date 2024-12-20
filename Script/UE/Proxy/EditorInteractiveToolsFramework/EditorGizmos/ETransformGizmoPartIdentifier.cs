﻿using Script.CoreUObject;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.ETransformGizmoPartIdentifier")]
	public enum ETransformGizmoPartIdentifier : int
	{
		Default = 0,
		TranslateAll = 1,
		TranslateXAxis = 2,
		TranslateYAxis = 3,
		TranslateZAxis = 4,
		TranslateXYPlanar = 5,
		TranslateYZPlanar = 6,
		TranslateXZPlanar = 7,
		TranslateScreenSpace = 8,
		RotateAll = 9,
		RotateXAxis = 10,
		RotateYAxis = 11,
		RotateZAxis = 12,
		RotateScreenSpace = 13,
		RotateArcball = 14,
		RotateArcballInnerCircle = 15,
		ScaleAll = 16,
		ScaleXAxis = 17,
		ScaleYAxis = 18,
		ScaleZAxis = 19,
		ScaleXYPlanar = 20,
		ScaleYZPlanar = 21,
		ScaleXZPlanar = 22,
		ScaleUniform = 23,
		Max = 24,
	}
}