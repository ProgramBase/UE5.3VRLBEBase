using Script.CoreUObject;

namespace Script.ACLPlugin
{
	[PathName("/Script/ACLPlugin.ACLCompressionLevel")]
	public enum ACLCompressionLevel : byte
	{
		ACLCL_Lowest = 0,
		ACLCL_Low = 1,
		ACLCL_Medium = 2,
		ACLCL_High = 3,
		ACLCL_Highest = 4,
	}
}