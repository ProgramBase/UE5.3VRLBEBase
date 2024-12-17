using Script.CoreUObject;

namespace Script.TakeRecorder
{
	[PathName("/Script/TakeRecorder.ETakeRecorderPanelMode")]
	public enum ETakeRecorderPanelMode : byte
	{
		NewRecording = 0,
		RecordingInto = 1,
		EditingPreset = 2,
		ReviewingRecording = 3,
	}
}