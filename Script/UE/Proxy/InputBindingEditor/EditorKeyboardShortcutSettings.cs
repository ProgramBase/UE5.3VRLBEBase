using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.InputBindingEditor
{
	[PathName("/Script/InputBindingEditor.EditorKeyboardShortcutSettings")]
	public partial class UEditorKeyboardShortcutSettings : UDeveloperSettings, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InputBindingEditor.EditorKeyboardShortcutSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}