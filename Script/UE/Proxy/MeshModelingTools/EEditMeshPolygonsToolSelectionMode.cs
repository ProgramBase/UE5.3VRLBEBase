using Script.CoreUObject;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EEditMeshPolygonsToolSelectionMode")]
	public enum EEditMeshPolygonsToolSelectionMode : long
	{
		Faces = 0,
		Edges = 1,
		Vertices = 2,
		Loops = 3,
		Rings = 4,
		FacesEdgesVertices = 5,
	}
}