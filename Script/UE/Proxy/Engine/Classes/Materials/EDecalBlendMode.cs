﻿using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EDecalBlendMode")]
	public enum EDecalBlendMode : byte
	{
		DBM_Translucent = 0,
		DBM_Stain = 1,
		DBM_Normal = 2,
		DBM_Emissive = 3,
		DBM_DBuffer_ColorNormalRoughness = 4,
		DBM_DBuffer_Color = 5,
		DBM_DBuffer_ColorNormal = 6,
		DBM_DBuffer_ColorRoughness = 7,
		DBM_DBuffer_Normal = 8,
		DBM_DBuffer_NormalRoughness = 9,
		DBM_DBuffer_Roughness = 10,
		DBM_DBuffer_Emissive = 11,
		DBM_DBuffer_AlphaComposite = 12,
		DBM_DBuffer_EmissiveAlphaComposite = 13,
		DBM_Volumetric_DistanceFunction = 14,
		DBM_AlphaComposite = 15,
		DBM_AmbientOcclusion = 16,
	}
}