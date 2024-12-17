using Script.CoreUObject;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.UMGEditorProjectSettings")]
	public partial class UUMGEditorProjectSettings : UWidgetEditingProjectSettings, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMGEditor.UMGEditorProjectSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}