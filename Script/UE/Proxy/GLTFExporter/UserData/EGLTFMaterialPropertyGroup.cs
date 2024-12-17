using Script.CoreUObject;

namespace Script.GLTFExporter
{
	[PathName("/Script/GLTFExporter.EGLTFMaterialPropertyGroup")]
	public enum EGLTFMaterialPropertyGroup : byte
	{
		None = 0,
		BaseColorOpacity = 1,
		MetallicRoughness = 2,
		EmissiveColor = 3,
		Normal = 4,
		AmbientOcclusion = 5,
		ClearCoatRoughness = 6,
		ClearCoatBottomNormal = 7,
	}
}