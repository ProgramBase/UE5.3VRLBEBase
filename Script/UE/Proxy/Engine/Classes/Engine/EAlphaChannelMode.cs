using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAlphaChannelMode")]
	public enum EAlphaChannelMode : byte
	{
		Disabled = 0,
		LinearColorSpaceOnly = 1,
		AllowThroughTonemapper = 2,
	}
}