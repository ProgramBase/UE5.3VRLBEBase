using Script.CoreUObject;
using Script.EditorFramework;
using Script.Library;

namespace Script.LevelEditor
{
	[PathName("/Script/LevelEditor.LevelEditorUISubsystem")]
	public partial class ULevelEditorUISubsystem : UAssetEditorUISubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelEditor.LevelEditorUISubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}