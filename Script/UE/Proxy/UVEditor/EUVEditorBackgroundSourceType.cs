using Script.CoreUObject;

namespace Script.UVEditor
{
	[PathName("/Script/UVEditor.EUVEditorBackgroundSourceType")]
	public enum EUVEditorBackgroundSourceType : int
	{
		Checkerboard = 0,
		Texture = 1,
		Material = 2,
	}
}