using Script.CoreUObject;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.EThumbnailPreviewSizeMode")]
	public enum EThumbnailPreviewSizeMode : byte
	{
		MatchDesignerMode = 0,
		FillScreen = 1,
		Custom = 2,
		Desired = 3,
	}
}