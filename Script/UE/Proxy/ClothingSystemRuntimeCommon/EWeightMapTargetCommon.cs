using Script.CoreUObject;

namespace Script.ClothingSystemRuntimeCommon
{
	[PathName("/Script/ClothingSystemRuntimeCommon.EWeightMapTargetCommon")]
	public enum EWeightMapTargetCommon : byte
	{
		None = 0,
		MaxDistance = 1,
		BackstopDistance = 2,
		BackstopRadius = 3,
		AnimDriveStiffness = 4,
		AnimDriveDamping_DEPRECATED = 5,
	}
}