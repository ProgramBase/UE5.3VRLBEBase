using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETravelType")]
	public enum ETravelType : byte
	{
		TRAVEL_Absolute = 0,
		TRAVEL_Partial = 1,
		TRAVEL_Relative = 2,
	}
}