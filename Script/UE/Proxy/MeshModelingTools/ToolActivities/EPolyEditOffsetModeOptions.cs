using Script.CoreUObject;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EPolyEditOffsetModeOptions")]
	public enum EPolyEditOffsetModeOptions : int
	{
		VertexNormals = 2,
		SelectedTriangleNormals = 0,
		SelectedTriangleNormalsEven = 1,
	}
}