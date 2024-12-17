using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.WebMMediaEditor
{
	[PathName("/Script/WebMMediaEditor.WebMPlatFileMediaSourceFactory")]
	public partial class UWebMPlatFileMediaSourceFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/WebMMediaEditor.WebMPlatFileMediaSourceFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}