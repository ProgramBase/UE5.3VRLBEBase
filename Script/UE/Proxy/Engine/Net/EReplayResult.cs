using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EReplayResult")]
	public enum EReplayResult : long
	{
		Success = 0,
		ReplayNotFound = 1,
		Corrupt = 2,
		UnsupportedCheckpoint = 3,
		GameSpecific = 4,
		InitConnect = 5,
		LoadMap = 6,
		Serialization = 7,
		StreamerError = 8,
		ConnectionClosed = 9,
		MissingArchive = 10,
		Unknown = 11,
	}
}