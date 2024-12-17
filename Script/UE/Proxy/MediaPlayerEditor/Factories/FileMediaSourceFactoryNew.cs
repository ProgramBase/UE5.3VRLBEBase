using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.MediaPlayerEditor
{
	[PathName("/Script/MediaPlayerEditor.FileMediaSourceFactoryNew")]
	public partial class UFileMediaSourceFactoryNew : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaPlayerEditor.FileMediaSourceFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}