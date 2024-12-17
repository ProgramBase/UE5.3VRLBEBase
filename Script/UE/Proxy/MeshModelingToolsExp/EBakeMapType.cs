using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EBakeMapType")]
	public enum EBakeMapType : int
	{
		None = 0,
		TangentSpaceNormal = 1,
		ObjectSpaceNormal = 2,
		FaceNormal = 4,
		BentNormal = 8,
		Position = 16,
		Curvature = 32,
		AmbientOcclusion = 64,
		Texture = 128,
		MultiTexture = 256,
		VertexColor = 512,
		MaterialID = 1024,
		PolyGroupID = 2048,
		All = 2047,
	}
}