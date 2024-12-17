using Script.CoreUObject;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.ESceneSnapQueryTargetType")]
	public enum ESceneSnapQueryTargetType : long
	{
		None = 0,
		MeshVertex = 1,
		MeshEdge = 2,
		Grid = 4,
		All = 7,
	}
}