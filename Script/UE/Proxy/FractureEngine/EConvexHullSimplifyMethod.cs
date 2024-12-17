using Script.CoreUObject;

namespace Script.FractureEngine
{
	[PathName("/Script/FractureEngine.EConvexHullSimplifyMethod")]
	public enum EConvexHullSimplifyMethod : int
	{
		MeshQSlim = 0,
		AngleTolerance = 1,
	}
}