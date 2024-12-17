using Script.CoreUObject;

namespace Script.ACLPlugin
{
	[PathName("/Script/ACLPlugin.ACLRotationFormat")]
	public enum ACLRotationFormat : byte
	{
		ACLRF_Quat_128 = 0,
		ACLRF_QuatDropW_96 = 1,
		ACLRF_QuatDropW_Variable = 2,
	}
}