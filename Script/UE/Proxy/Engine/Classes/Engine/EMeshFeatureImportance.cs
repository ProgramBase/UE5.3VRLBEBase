using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMeshFeatureImportance")]
	public enum EMeshFeatureImportance : byte
	{
		Off = 0,
		Lowest = 1,
		Low = 2,
		Normal = 3,
		High = 4,
		Highest = 5,
	}
}