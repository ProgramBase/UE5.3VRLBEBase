using Script.CoreUObject;
using Script.EditorFramework;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.WidgetEditorModeUISubsystem")]
	public partial class UWidgetEditorModeUISubsystem : UAssetEditorUISubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMGEditor.WidgetEditorModeUISubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}