using Script.CoreUObject;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EMakeMeshPolygroupMode")]
	public enum EMakeMeshPolygroupMode : byte
	{
		PerShape = 0,
		PerFace = 1,
		PerQuad = 2,
	}
}