using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.ECollisionGeometryType")]
	public enum ECollisionGeometryType : int
	{
		CopyFromInputs = 0,
		AlignedBoxes = 1,
		OrientedBoxes = 2,
		MinimalSpheres = 3,
		Capsules = 4,
		ConvexHulls = 5,
		SweptHulls = 6,
		LevelSets = 7,
		MinVolume = 10,
		Empty = 11,
	}
}