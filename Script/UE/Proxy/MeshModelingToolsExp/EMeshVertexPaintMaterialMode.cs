using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EMeshVertexPaintMaterialMode")]
	public enum EMeshVertexPaintMaterialMode : byte
	{
		LitVertexColor = 0,
		UnlitVertexColor = 1,
		OriginalMaterial = 2,
	}
}