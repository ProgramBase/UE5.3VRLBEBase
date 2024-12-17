using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetBlueprintGeneratedClassExtension")]
	public partial class UWidgetBlueprintGeneratedClassExtension : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WidgetBlueprintGeneratedClassExtension");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}