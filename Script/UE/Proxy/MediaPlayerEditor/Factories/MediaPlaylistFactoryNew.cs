using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.MediaPlayerEditor
{
	[PathName("/Script/MediaPlayerEditor.MediaPlaylistFactoryNew")]
	public partial class UMediaPlaylistFactoryNew : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaPlayerEditor.MediaPlaylistFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}