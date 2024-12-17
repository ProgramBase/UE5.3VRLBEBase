using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.Paper2DEditor
{
	[PathName("/Script/Paper2DEditor.PaperTileSetThumbnailRenderer")]
	public partial class UPaperTileSetThumbnailRenderer : UDefaultSizedThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Paper2DEditor.PaperTileSetThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}