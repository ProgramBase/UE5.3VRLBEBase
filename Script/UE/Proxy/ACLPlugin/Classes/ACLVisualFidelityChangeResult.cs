using Script.CoreUObject;

namespace Script.ACLPlugin
{
	[PathName("/Script/ACLPlugin.ACLVisualFidelityChangeResult")]
	public enum ACLVisualFidelityChangeResult : byte
	{
		Dispatched = 0,
		Completed = 1,
		Failed = 2,
	}
}