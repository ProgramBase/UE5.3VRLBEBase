using Script.CoreUObject;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.EUVEditorDistributeMode")]
	public enum EUVEditorDistributeMode : ushort
	{
		None = 0,
		VerticalSpace = 1,
		HorizontalSpace = 2,
		TopEdges = 3,
		BottomEdges = 4,
		LeftEdges = 5,
		RightEdges = 6,
		CentersVertically = 7,
		CentersHorizontally = 8,
		MinimallyRemoveOverlap = 9,
	}
}