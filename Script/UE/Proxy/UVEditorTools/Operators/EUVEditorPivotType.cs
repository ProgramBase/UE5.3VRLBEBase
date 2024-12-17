using Script.CoreUObject;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.EUVEditorPivotType")]
	public enum EUVEditorPivotType : int
	{
		BoundingBoxCenter = 0,
		Origin = 1,
		IndividualBoundingBoxCenter = 2,
		Manual = 3,
	}
}