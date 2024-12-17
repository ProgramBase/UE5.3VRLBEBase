using Script.CoreUObject;
using Script.UMGEditor;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityWidgetProjectSettings")]
	public partial class UEditorUtilityWidgetProjectSettings : UWidgetEditingProjectSettings, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityWidgetProjectSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}