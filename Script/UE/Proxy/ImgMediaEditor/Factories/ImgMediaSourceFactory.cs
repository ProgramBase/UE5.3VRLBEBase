using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.ImgMediaEditor
{
	[PathName("/Script/ImgMediaEditor.ImgMediaSourceFactory")]
	public partial class UImgMediaSourceFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ImgMediaEditor.ImgMediaSourceFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}