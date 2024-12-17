using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EBlendSpacePerBoneBlendMode")]
	public enum EBlendSpacePerBoneBlendMode : byte
	{
		ManualPerBoneOverride = 0,
		BlendProfile = 1,
	}
}