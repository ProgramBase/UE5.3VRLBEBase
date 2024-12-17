using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EConvertToPolygonsMode")]
	public enum EConvertToPolygonsMode : int
	{
		FaceNormalDeviation = 0,
		FindPolygons = 1,
		FromUVIslands = 2,
		FromNormalSeams = 3,
		FromConnectedTris = 4,
		FromFurthestPointSampling = 5,
		CopyFromLayer = 6,
	}
}