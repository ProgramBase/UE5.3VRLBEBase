using Script.CoreUObject;

namespace Script.ImageWriteQueue
{
	[PathName("/Script/ImageWriteQueue.EDesiredImageFormat")]
	public enum EDesiredImageFormat : byte
	{
		PNG = 0,
		JPG = 1,
		BMP = 2,
		EXR = 3,
	}
}