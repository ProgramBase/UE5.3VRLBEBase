using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ELightMapPaddingType")]
	public enum ELightMapPaddingType : long
	{
		LMPT_NormalPadding = 0,
		LMPT_PrePadding = 1,
		LMPT_NoPadding = 2,
	}
}