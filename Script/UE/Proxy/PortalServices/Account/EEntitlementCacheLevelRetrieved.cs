using Script.CoreUObject;

namespace Script.PortalServices
{
	[PathName("/Script/PortalServices.EEntitlementCacheLevelRetrieved")]
	public enum EEntitlementCacheLevelRetrieved : byte
	{
		None = 0,
		Memory = 1,
		Disk = 2,
	}
}