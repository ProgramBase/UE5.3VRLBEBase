using Script.CoreUObject;

namespace Script.EditorScriptingUtilities
{
	[PathName("/Script/EditorScriptingUtilities.EEditorScriptingStringMatchType")]
	public enum EEditorScriptingStringMatchType : byte
	{
		Contains = 0,
		MatchesWildcard = 1,
		ExactMatch = 2,
	}
}