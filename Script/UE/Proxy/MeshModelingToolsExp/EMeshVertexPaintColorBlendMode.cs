using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EMeshVertexPaintColorBlendMode")]
	public enum EMeshVertexPaintColorBlendMode : byte
	{
		Lerp = 0,
		Mix = 1,
		Multiply = 2,
	}
}