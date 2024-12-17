using Script.CoreUObject;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.EGenerateStaticMeshLODSimpleCollisionGeometryType")]
	public enum EGenerateStaticMeshLODSimpleCollisionGeometryType : byte
	{
		AlignedBoxes = 0,
		OrientedBoxes = 1,
		MinimalSpheres = 2,
		Capsules = 3,
		ConvexHulls = 4,
		SweptHulls = 5,
		MinVolume = 6,
		None = 7,
	}
}