using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.ImgMediaEditor
{
	[PathName("/Script/ImgMediaEditor.ImgMediaSourceFactoryNew")]
	public partial class UImgMediaSourceFactoryNew : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ImgMediaEditor.ImgMediaSourceFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}