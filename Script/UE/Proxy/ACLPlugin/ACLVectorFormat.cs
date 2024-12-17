using Script.CoreUObject;

namespace Script.ACLPlugin
{
	[PathName("/Script/ACLPlugin.ACLVectorFormat")]
	public enum ACLVectorFormat : byte
	{
		ACLVF_Vector3_96 = 0,
		ACLVF_Vector3_Variable = 1,
	}
}