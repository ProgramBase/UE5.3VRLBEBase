using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EUpdateRateShiftBucket")]
	public enum EUpdateRateShiftBucket : byte
	{
		ShiftBucket0 = 0,
		ShiftBucket1 = 1,
		ShiftBucket2 = 2,
		ShiftBucket3 = 3,
		ShiftBucket4 = 4,
		ShiftBucket5 = 5,
		ShiftBucketMax = 6,
	}
}