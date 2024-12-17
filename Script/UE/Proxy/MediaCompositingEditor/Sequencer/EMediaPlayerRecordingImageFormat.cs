using Script.CoreUObject;

namespace Script.MediaCompositingEditor
{
	[PathName("/Script/MediaCompositingEditor.EMediaPlayerRecordingImageFormat")]
	public enum EMediaPlayerRecordingImageFormat : byte
	{
		PNG = 0,
		JPEG = 1,
		BMP = 2,
		EXR = 3,
	}
}