﻿using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.ECubeGridToolAction")]
	public enum ECubeGridToolAction : long
	{
		NoAction = 0,
		Push = 1,
		Pull = 2,
		Flip = 3,
		SlideForward = 4,
		SlideBack = 5,
		DecreaseGridPower = 6,
		IncreaseGridPower = 7,
		CornerMode = 8,
		ResetFromActor = 9,
		Done = 10,
		Cancel = 11,
	}
}