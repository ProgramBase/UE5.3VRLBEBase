using Script.CoreUObject;

namespace Script.SequenceRecorder
{
	[PathName("/Script/SequenceRecorder.EAudioRecordingMode")]
	public enum EAudioRecordingMode : byte
	{
		None = 0,
		AudioTrack = 1,
	}
}