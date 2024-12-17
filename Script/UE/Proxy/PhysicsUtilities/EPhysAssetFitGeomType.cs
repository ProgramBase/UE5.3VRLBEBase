using Script.CoreUObject;

namespace Script.PhysicsUtilities
{
	[PathName("/Script/PhysicsUtilities.EPhysAssetFitGeomType")]
	public enum EPhysAssetFitGeomType : byte
	{
		EFG_Box = 0,
		EFG_Sphyl = 1,
		EFG_Sphere = 2,
		EFG_TaperedCapsule = 3,
		EFG_SingleConvexHull = 4,
		EFG_MultiConvexHull = 5,
		EFG_LevelSet = 6,
		EFG_SkinnedLevelSet = 7,
	}
}