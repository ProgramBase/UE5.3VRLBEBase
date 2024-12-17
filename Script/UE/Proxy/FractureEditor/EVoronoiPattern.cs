using Script.CoreUObject;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.EVoronoiPattern")]
	public enum EVoronoiPattern : int
	{
		Centered = 0,
		Uniform = 1,
		Grid = 2,
		MeshVertices = 3,
		SelectedBones = 4,
	}
}