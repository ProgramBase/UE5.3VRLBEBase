using Script.CoreUObject;

namespace Script.HierarchicalLODOutliner
{
	[PathName("/Script/HierarchicalLODOutliner.EHierarchicalLODActionType")]
	public enum EHierarchicalLODActionType : long
	{
		InvalidAction = 0,
		CreateCluster = 1,
		AddActorToCluster = 2,
		MoveActorToCluster = 3,
		RemoveActorFromCluster = 4,
		MergeClusters = 5,
		ChildCluster = 6,
	}
}