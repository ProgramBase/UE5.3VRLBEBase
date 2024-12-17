using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.AndroidMediaEditor
{
	[PathName("/Script/AndroidMediaEditor.AndroidFileMediaSourceFactory")]
	public partial class UAndroidFileMediaSourceFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AndroidMediaEditor.AndroidFileMediaSourceFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}