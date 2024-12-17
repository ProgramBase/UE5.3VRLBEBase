using Script.CoreUObject;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.WidgetBlueprintToolMenuContext")]
	public partial class UWidgetBlueprintToolMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMGEditor.WidgetBlueprintToolMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}