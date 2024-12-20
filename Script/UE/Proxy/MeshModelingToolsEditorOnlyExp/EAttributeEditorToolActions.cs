﻿using Script.CoreUObject;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.EAttributeEditorToolActions")]
	public enum EAttributeEditorToolActions : long
	{
		NoAction = 0,
		ClearNormals = 1,
		DiscardTangents = 2,
		ClearAllUVs = 3,
		ClearSelectedUVs = 4,
		AddUVSet = 5,
		DeleteSelectedUVSet = 6,
		DuplicateSelectedUVSet = 7,
		AddAttribute = 8,
		AddWeightMapLayer = 9,
		AddPolyGroupLayer = 10,
		DeleteAttribute = 11,
		ClearAttribute = 12,
		CopyAttributeFromTo = 13,
		EnableLightmapUVs = 14,
		DisableLightmapUVs = 15,
		ResetLightmapUVChannels = 16,
	}
}