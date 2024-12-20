﻿using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ERigHierarchyNotification")]
	public enum ERigHierarchyNotification : byte
	{
		ElementAdded = 0,
		ElementRemoved = 1,
		ElementRenamed = 2,
		ElementSelected = 3,
		ElementDeselected = 4,
		ParentChanged = 5,
		HierarchyReset = 6,
		ControlSettingChanged = 7,
		ControlVisibilityChanged = 8,
		ControlDrivenListChanged = 9,
		ControlShapeTransformChanged = 10,
		ParentWeightsChanged = 11,
		InteractionBracketOpened = 12,
		InteractionBracketClosed = 13,
		ElementReordered = 14,
		Max = 15,
	}
}