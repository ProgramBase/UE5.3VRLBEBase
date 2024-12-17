using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ELocalFogMode")]
	public enum ELocalFogMode : byte
	{
		LocalHeightFog = 0,
		LocalSphereFog = 1,
	}
}