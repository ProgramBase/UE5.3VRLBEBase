using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TextureCubeArrayThumbnailRenderer")]
	public partial class UTextureCubeArrayThumbnailRenderer : UTextureThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TextureCubeArrayThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}