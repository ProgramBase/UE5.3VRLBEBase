using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERuntimeVirtualTextureMaterialType")]
	public enum ERuntimeVirtualTextureMaterialType : byte
	{
		BaseColor = 0,
		BaseColor_Normal_DEPRECATED = 1,
		BaseColor_Normal_Roughness = 2,
		BaseColor_Normal_Specular = 3,
		BaseColor_Normal_Specular_YCoCg = 4,
		BaseColor_Normal_Specular_Mask_YCoCg = 5,
		WorldHeight = 6,
		Count = 7,
	}
}