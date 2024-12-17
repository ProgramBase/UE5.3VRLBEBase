using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TextureThumbnailRenderer")]
	public partial class UTextureThumbnailRenderer : UThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TextureThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}