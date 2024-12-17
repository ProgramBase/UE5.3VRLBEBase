using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ETextureSourceColorSpace")]
	public enum ETextureSourceColorSpace : int
	{
		Auto = 0,
		Linear = 1,
		SRGB = 2,
	}
}