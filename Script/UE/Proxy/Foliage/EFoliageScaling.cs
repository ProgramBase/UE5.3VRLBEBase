using Script.CoreUObject;

namespace Script.Foliage
{
	[PathName("/Script/Foliage.EFoliageScaling")]
	public enum EFoliageScaling : byte
	{
		Uniform = 0,
		Free = 1,
		LockXY = 2,
		LockXZ = 3,
		LockYZ = 4,
	}
}