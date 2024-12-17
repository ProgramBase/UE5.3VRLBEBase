using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAudioRecordingExportType")]
	public enum EAudioRecordingExportType : byte
	{
		SoundWave = 0,
		WavFile = 1,
	}
}