using Script.CoreUObject;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.EGrassScaling")]
	public enum EGrassScaling : byte
	{
		Uniform = 0,
		Free = 1,
		LockXY = 2,
	}
}