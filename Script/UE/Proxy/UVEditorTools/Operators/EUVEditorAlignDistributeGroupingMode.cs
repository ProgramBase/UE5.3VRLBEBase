using Script.CoreUObject;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.EUVEditorAlignDistributeGroupingMode")]
	public enum EUVEditorAlignDistributeGroupingMode : byte
	{
		IndividualBoundingBoxes = 0,
		EnclosingBoundingBox = 1,
		IndividualVertices = 2,
	}
}