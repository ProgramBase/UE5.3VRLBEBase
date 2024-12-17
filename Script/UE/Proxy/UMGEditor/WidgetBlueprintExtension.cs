using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.WidgetBlueprintExtension")]
	public partial class UWidgetBlueprintExtension : UBlueprintExtension, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMGEditor.WidgetBlueprintExtension");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}