using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.MediaPlayerEditor
{
	[PathName("/Script/MediaPlayerEditor.MediaPlayerFactoryNew")]
	public partial class UMediaPlayerFactoryNew : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaPlayerEditor.MediaPlayerFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}