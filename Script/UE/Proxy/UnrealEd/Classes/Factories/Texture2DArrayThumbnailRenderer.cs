using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.Texture2DArrayThumbnailRenderer")]
	public partial class UTexture2DArrayThumbnailRenderer : UTextureThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.Texture2DArrayThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}