﻿using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMaterialProperty")]
	public enum EMaterialProperty : byte
	{
		MP_EmissiveColor = 0,
		MP_Opacity = 1,
		MP_OpacityMask = 2,
		MP_DiffuseColor = 3,
		MP_SpecularColor = 4,
		MP_BaseColor = 5,
		MP_Metallic = 6,
		MP_Specular = 7,
		MP_Roughness = 8,
		MP_Anisotropy = 9,
		MP_Normal = 10,
		MP_Tangent = 11,
		MP_WorldPositionOffset = 12,
		MP_WorldDisplacement_DEPRECATED = 13,
		MP_TessellationMultiplier_DEPRECATED = 14,
		MP_SubsurfaceColor = 15,
		MP_CustomData0 = 16,
		MP_CustomData1 = 17,
		MP_AmbientOcclusion = 18,
		MP_Refraction = 19,
		MP_CustomizedUVs0 = 20,
		MP_CustomizedUVs1 = 21,
		MP_CustomizedUVs2 = 22,
		MP_CustomizedUVs3 = 23,
		MP_CustomizedUVs4 = 24,
		MP_CustomizedUVs5 = 25,
		MP_CustomizedUVs6 = 26,
		MP_CustomizedUVs7 = 27,
		MP_PixelDepthOffset = 28,
		MP_ShadingModel = 29,
		MP_FrontMaterial = 30,
		MP_SurfaceThickness = 31,
		MP_Displacement = 32,
		MP_MaterialAttributes = 33,
		MP_CustomOutput = 34,
	}
}