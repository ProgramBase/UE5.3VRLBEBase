using Script.CoreUObject;
using Script.Library;

namespace Script.Paper2DEditor
{
	[PathName("/Script/Paper2DEditor.PaperFlipbookThumbnailRenderer")]
	public partial class UPaperFlipbookThumbnailRenderer : UPaperSpriteThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Paper2DEditor.PaperFlipbookThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}