using Script.CoreUObject;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.EAnimGraphNodePropertyBindingType")]
	public enum EAnimGraphNodePropertyBindingType : int
	{
		None = 0,
		Property = 1,
		Function = 2,
	}
}