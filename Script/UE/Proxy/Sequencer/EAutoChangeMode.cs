using Script.CoreUObject;

namespace Script.Sequencer
{
	[PathName("/Script/Sequencer.EAutoChangeMode")]
	public enum EAutoChangeMode : byte
	{
		AutoKey = 0,
		AutoTrack = 1,
		All = 2,
		None = 3,
	}
}