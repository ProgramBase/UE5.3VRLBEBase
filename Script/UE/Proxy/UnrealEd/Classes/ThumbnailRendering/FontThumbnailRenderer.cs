using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.FontThumbnailRenderer")]
	public partial class UFontThumbnailRenderer : UTextureThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.FontThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}