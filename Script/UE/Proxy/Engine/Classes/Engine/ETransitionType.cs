using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETransitionType")]
	public enum ETransitionType : byte
	{
		None = 0,
		Paused = 1,
		Loading = 2,
		Saving = 3,
		Connecting = 4,
		Precaching = 5,
		WaitingToConnect = 6,
	}
}