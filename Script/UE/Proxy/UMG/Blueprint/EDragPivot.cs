﻿using Script.CoreUObject;

namespace Script.UMG
{
	[PathName("/Script/UMG.EDragPivot")]
	public enum EDragPivot : byte
	{
		MouseDown = 0,
		TopLeft = 1,
		TopCenter = 2,
		TopRight = 3,
		CenterLeft = 4,
		CenterCenter = 5,
		CenterRight = 6,
		BottomLeft = 7,
		BottomCenter = 8,
		BottomRight = 9,
	}
}