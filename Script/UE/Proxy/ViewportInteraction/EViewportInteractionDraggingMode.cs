﻿using Script.CoreUObject;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.EViewportInteractionDraggingMode")]
	public enum EViewportInteractionDraggingMode : byte
	{
		Nothing = 0,
		TransformablesWithGizmo = 1,
		TransformablesAtLaserImpact = 2,
		AssistingDrag = 3,
		TransformablesFreely = 4,
		World = 5,
		Interactable = 6,
		Material = 7,
	}
}