﻿using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EPlayModeType")]
	public enum EPlayModeType : byte
	{
		PlayMode_InViewPort = 0,
		PlayMode_InEditorFloating = 1,
		PlayMode_InMobilePreview = 2,
		PlayMode_InTargetedMobilePreview = 3,
		PlayMode_InVulkanPreview = 4,
		PlayMode_InNewProcess = 5,
		PlayMode_InVR = 6,
		PlayMode_Simulate = 7,
		PlayMode_QuickLaunch = 8,
		PlayMode_Count = 9,
	}
}