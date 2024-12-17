using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.EAnchorStateEnum")]
	public enum EAnchorStateEnum : byte
	{
		Dataflow_AnchorState_Anchored = 0,
		Dataflow_AnchorState_NotAnchored = 1,
		Dataflow_Max = 2,
	}
}