﻿using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESceneTextureId")]
	public enum ESceneTextureId : byte
	{
		PPI_SceneColor = 0,
		PPI_SceneDepth = 1,
		PPI_DiffuseColor = 2,
		PPI_SpecularColor = 3,
		PPI_SubsurfaceColor = 4,
		PPI_BaseColor = 5,
		PPI_Specular = 6,
		PPI_Metallic = 7,
		PPI_WorldNormal = 8,
		PPI_SeparateTranslucency = 9,
		PPI_Opacity = 10,
		PPI_Roughness = 11,
		PPI_MaterialAO = 12,
		PPI_CustomDepth = 13,
		PPI_PostProcessInput0 = 14,
		PPI_PostProcessInput1 = 15,
		PPI_PostProcessInput2 = 16,
		PPI_PostProcessInput3 = 17,
		PPI_PostProcessInput4 = 18,
		PPI_PostProcessInput5 = 19,
		PPI_PostProcessInput6 = 20,
		PPI_DecalMask = 21,
		PPI_ShadingModelColor = 22,
		PPI_ShadingModelID = 23,
		PPI_AmbientOcclusion = 24,
		PPI_CustomStencil = 25,
		PPI_StoredBaseColor = 26,
		PPI_StoredSpecular = 27,
		PPI_Velocity = 28,
		PPI_WorldTangent = 29,
		PPI_Anisotropy = 30,
	}
}