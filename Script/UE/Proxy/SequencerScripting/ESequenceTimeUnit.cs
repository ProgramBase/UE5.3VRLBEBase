using Script.CoreUObject;

namespace Script.SequencerScripting
{
	[PathName("/Script/SequencerScripting.ESequenceTimeUnit")]
	public enum ESequenceTimeUnit : byte
	{
		DisplayRate = 0,
		TickResolution = 1,
	}
}