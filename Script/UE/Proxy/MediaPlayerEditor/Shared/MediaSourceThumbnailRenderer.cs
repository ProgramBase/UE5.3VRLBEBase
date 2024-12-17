using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.MediaPlayerEditor
{
	[PathName("/Script/MediaPlayerEditor.MediaSourceThumbnailRenderer")]
	public partial class UMediaSourceThumbnailRenderer : UTextureThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaPlayerEditor.MediaSourceThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}