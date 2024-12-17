using Script.CoreUObject;

namespace Script.MediaCompositingEditor
{
	[PathName("/Script/MediaCompositingEditor.EMediaPlayerRecordingNumerationStyle")]
	public enum EMediaPlayerRecordingNumerationStyle : byte
	{
		AppendFrameNumber = 0,
		AppendSampleTime = 1,
	}
}