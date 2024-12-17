using Script.CoreUObject;

namespace Script.AssetManagerEditor
{
	[PathName("/Script/AssetManagerEditor.ESizeMapDependencyType")]
	public enum ESizeMapDependencyType : int
	{
		All = 0,
		Game = 1,
		EditorOnly = 2,
	}
}