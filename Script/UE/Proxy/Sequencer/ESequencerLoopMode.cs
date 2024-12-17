using Script.CoreUObject;

namespace Script.Sequencer
{
	[PathName("/Script/Sequencer.ESequencerLoopMode")]
	public enum ESequencerLoopMode : byte
	{
		SLM_NoLoop = 0,
		SLM_Loop = 1,
		SLM_LoopSelectionRange = 2,
	}
}