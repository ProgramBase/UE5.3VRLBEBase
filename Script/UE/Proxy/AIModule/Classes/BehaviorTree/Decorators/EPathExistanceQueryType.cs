using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EPathExistanceQueryType")]
	public enum EPathExistanceQueryType : byte
	{
		NavmeshRaycast2D = 0,
		HierarchicalQuery = 1,
		RegularPathFinding = 2,
	}
}