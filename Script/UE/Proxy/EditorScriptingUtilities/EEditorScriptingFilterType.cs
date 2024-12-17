using Script.CoreUObject;

namespace Script.EditorScriptingUtilities
{
	[PathName("/Script/EditorScriptingUtilities.EEditorScriptingFilterType")]
	public enum EEditorScriptingFilterType : byte
	{
		Include = 0,
		Exclude = 1,
	}
}