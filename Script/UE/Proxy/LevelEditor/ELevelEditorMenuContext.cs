using Script.CoreUObject;

namespace Script.LevelEditor
{
	[PathName("/Script/LevelEditor.ELevelEditorMenuContext")]
	public enum ELevelEditorMenuContext : byte
	{
		Viewport = 0,
		SceneOutliner = 1,
		MainMenu = 2,
	}
}