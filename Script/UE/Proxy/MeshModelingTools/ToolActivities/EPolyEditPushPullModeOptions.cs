using Script.CoreUObject;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EPolyEditPushPullModeOptions")]
	public enum EPolyEditPushPullModeOptions : int
	{
		SelectedTriangleNormals = 0,
		SelectedTriangleNormalsEven = 1,
		SingleDirection = 3,
		VertexNormals = 2,
	}
}