using Script.CoreUObject;

namespace Script.Sequencer
{
	[PathName("/Script/Sequencer.EAllowEditsMode")]
	public enum EAllowEditsMode : byte
	{
		AllEdits = 0,
		AllowSequencerEditsOnly = 1,
		AllowLevelEditsOnly = 2,
	}
}