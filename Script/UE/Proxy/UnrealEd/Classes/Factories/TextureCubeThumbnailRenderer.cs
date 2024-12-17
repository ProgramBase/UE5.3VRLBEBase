using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TextureCubeThumbnailRenderer")]
	public partial class UTextureCubeThumbnailRenderer : UTextureThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TextureCubeThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}