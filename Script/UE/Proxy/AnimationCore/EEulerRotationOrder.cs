using Script.CoreUObject;

namespace Script.AnimationCore
{
	[PathName("/Script/AnimationCore.EEulerRotationOrder")]
	public enum EEulerRotationOrder : byte
	{
		XYZ = 0,
		XZY = 1,
		YXZ = 2,
		YZX = 3,
		ZXY = 4,
		ZYX = 5,
	}
}