using Script.CoreUObject;

namespace Script.UVEditor
{
	[PathName("/Script/UVEditor.EUVEditorModeActions")]
	public enum EUVEditorModeActions : long
	{
		NoAction = 0,
		ConfigureUDIMsFromAsset = 1,
		ConfigureUDIMsFromTexture = 2,
	}
}