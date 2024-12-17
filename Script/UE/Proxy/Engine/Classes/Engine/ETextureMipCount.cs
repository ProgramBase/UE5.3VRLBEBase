using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETextureMipCount")]
	public enum ETextureMipCount : long
	{
		TMC_ResidentMips = 0,
		TMC_AllMips = 1,
		TMC_AllMipsBiased = 2,
	}
}