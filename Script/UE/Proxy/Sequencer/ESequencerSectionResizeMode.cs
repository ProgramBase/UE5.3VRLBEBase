using Script.CoreUObject;

namespace Script.Sequencer
{
	[PathName("/Script/Sequencer.ESequencerSectionResizeMode")]
	public enum ESequencerSectionResizeMode : long
	{
		SSRM_LeadingEdge = 0,
		SSRM_TrailingEdge = 1,
	}
}