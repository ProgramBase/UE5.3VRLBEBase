using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.MediaPlayerEditor
{
	[PathName("/Script/MediaPlayerEditor.PlatformMediaSourceFactoryNew")]
	public partial class UPlatformMediaSourceFactoryNew : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaPlayerEditor.PlatformMediaSourceFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}