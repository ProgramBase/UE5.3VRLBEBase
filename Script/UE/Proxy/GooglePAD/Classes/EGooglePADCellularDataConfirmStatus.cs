using Script.CoreUObject;

namespace Script.GooglePAD
{
	[PathName("/Script/GooglePAD.EGooglePADCellularDataConfirmStatus")]
	public enum EGooglePADCellularDataConfirmStatus : byte
	{
		AssetPack_CONFIRM_UNKNOWN = 0,
		AssetPack_CONFIRM_PENDING = 1,
		AssetPack_CONFIRM_USER_APPROVED = 2,
		AssetPack_CONFIRM_USER_CANCELED = 3,
	}
}