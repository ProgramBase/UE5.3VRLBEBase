using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.ESetCollisionGeometryInputMode")]
	public enum ESetCollisionGeometryInputMode : int
	{
		CombineAll = 0,
		PerInputObject = 1,
		PerMeshComponent = 2,
		PerMeshGroup = 3,
	}
}