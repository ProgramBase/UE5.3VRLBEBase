using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EEarlyZPass")]
	public enum EEarlyZPass : byte
	{
		None = 0,
		OpaqueOnly = 1,
		OpaqueAndMasked = 2,
		Auto = 3,
	}
}