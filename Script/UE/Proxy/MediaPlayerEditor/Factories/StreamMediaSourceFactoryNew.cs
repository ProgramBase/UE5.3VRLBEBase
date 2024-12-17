using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.MediaPlayerEditor
{
	[PathName("/Script/MediaPlayerEditor.StreamMediaSourceFactoryNew")]
	public partial class UStreamMediaSourceFactoryNew : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaPlayerEditor.StreamMediaSourceFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}