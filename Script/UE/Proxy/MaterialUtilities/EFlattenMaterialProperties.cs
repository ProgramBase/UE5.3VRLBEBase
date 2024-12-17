using Script.CoreUObject;

namespace Script.MaterialUtilities
{
	[PathName("/Script/MaterialUtilities.EFlattenMaterialProperties")]
	public enum EFlattenMaterialProperties : long
	{
		Diffuse = 0,
		Metallic = 1,
		Specular = 2,
		Roughness = 3,
		Anisotropy = 4,
		Normal = 5,
		Tangent = 6,
		Opacity = 7,
		Emissive = 8,
		SubSurface = 9,
		OpacityMask = 10,
		AmbientOcclusion = 16,
		NumFlattenMaterialProperties = 17,
	}
}