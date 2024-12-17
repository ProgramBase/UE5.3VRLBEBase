using Script.CoreUObject;

namespace Script.AppleImageUtils
{
	[PathName("/Script/AppleImageUtils.EAppleTextureType")]
	public enum EAppleTextureType : long
	{
		Unknown = 0,
		Image = 1,
		PixelBuffer = 2,
		Surface = 3,
		MetalTexture = 4,
	}
}