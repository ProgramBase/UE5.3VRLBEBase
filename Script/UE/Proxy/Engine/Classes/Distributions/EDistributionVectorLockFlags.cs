using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EDistributionVectorLockFlags")]
	public enum EDistributionVectorLockFlags : byte
	{
		EDVLF_None = 0,
		EDVLF_XY = 1,
		EDVLF_XZ = 2,
		EDVLF_YZ = 3,
		EDVLF_XYZ = 4,
	}
}