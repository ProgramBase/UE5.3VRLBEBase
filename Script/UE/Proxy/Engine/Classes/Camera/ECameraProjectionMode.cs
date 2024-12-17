using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ECameraProjectionMode")]
	public enum ECameraProjectionMode : byte
	{
		Perspective = 0,
		Orthographic = 1,
	}
}