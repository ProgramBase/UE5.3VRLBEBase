using Script.CoreUObject;

namespace Script.Sequencer
{
	[PathName("/Script/Sequencer.ESequencerZoomPosition")]
	public enum ESequencerZoomPosition : byte
	{
		SZP_CurrentTime = 0,
		SZP_MousePosition = 1,
	}
}