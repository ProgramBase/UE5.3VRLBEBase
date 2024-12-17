using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SlateBrushThumbnailRenderer")]
	public partial class USlateBrushThumbnailRenderer : UDefaultSizedThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.SlateBrushThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}