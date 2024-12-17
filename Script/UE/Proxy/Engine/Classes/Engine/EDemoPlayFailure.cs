using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EDemoPlayFailure")]
	public enum EDemoPlayFailure : long
	{
		Generic = 0,
		DemoNotFound = 1,
		Corrupt = 2,
		InvalidVersion = 3,
		InitBase = 4,
		GameSpecificHeader = 5,
		ReplayStreamerInternal = 6,
		LoadMap = 7,
		Serialization = 8,
	}
}