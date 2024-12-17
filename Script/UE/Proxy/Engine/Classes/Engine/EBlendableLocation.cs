using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EBlendableLocation")]
	public enum EBlendableLocation : byte
	{
		BL_AfterTonemapping = 0,
		BL_BeforeTonemapping = 1,
		BL_BeforeTranslucency = 2,
		BL_ReplacingTonemapper = 3,
		BL_SSRInput = 4,
	}
}