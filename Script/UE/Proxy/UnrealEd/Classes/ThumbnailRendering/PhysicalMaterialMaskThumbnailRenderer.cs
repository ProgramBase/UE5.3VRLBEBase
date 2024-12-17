using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.PhysicalMaterialMaskThumbnailRenderer")]
	public partial class UPhysicalMaterialMaskThumbnailRenderer : UTextureThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.PhysicalMaterialMaskThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}