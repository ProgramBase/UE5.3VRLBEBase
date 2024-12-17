using Script.CoreUObject;

namespace Script.GooglePAD
{
	[PathName("/Script/GooglePAD.EGooglePADStorageMethod")]
	public enum EGooglePADStorageMethod : byte
	{
		AssetPack_STORAGE_FILES = 0,
		AssetPack_STORAGE_APK = 1,
		AssetPack_STORAGE_UNKNOWN = 2,
		AssetPack_STORAGE_NOT_INSTALLED = 3,
	}
}