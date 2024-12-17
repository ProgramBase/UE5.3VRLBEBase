using Script.CoreUObject;

namespace Script.Sequencer
{
	[PathName("/Script/Sequencer.EKeyGroupMode")]
	public enum EKeyGroupMode : byte
	{
		KeyChanged = 0,
		KeyGroup = 1,
		KeyAll = 2,
	}
}