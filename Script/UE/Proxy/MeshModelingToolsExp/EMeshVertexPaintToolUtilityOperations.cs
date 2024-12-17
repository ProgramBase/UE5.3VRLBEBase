using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EMeshVertexPaintToolUtilityOperations")]
	public enum EMeshVertexPaintToolUtilityOperations : int
	{
		BlendAllSeams = 0,
		FillChannels = 1,
		InvertChannels = 2,
		CopyChannelToChannel = 3,
		SwapChannels = 4,
		CopyFromWeightMap = 5,
		CopyToOtherLODs = 6,
		CopyToSingleLOD = 7,
	}
}