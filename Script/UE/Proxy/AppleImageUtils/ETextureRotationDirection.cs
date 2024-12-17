using Script.CoreUObject;

namespace Script.AppleImageUtils
{
	[PathName("/Script/AppleImageUtils.ETextureRotationDirection")]
	public enum ETextureRotationDirection : byte
	{
		None = 0,
		Left = 1,
		Right = 2,
		Down = 3,
		LeftMirrored = 4,
		RightMirrored = 5,
		DownMirrored = 6,
		UpMirrored = 7,
	}
}