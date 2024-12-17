using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.WidgetBlueprintThumbnailRenderer")]
	public partial class UWidgetBlueprintThumbnailRenderer : UDefaultSizedThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMGEditor.WidgetBlueprintThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}