using Script.CoreUObject;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EPolyEditExtrudeModeOptions")]
	public enum EPolyEditExtrudeModeOptions : int
	{
		SingleDirection = 3,
		SelectedTriangleNormals = 0,
		SelectedTriangleNormalsEven = 1,
	}
}