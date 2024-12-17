using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.PhysicsAssetThumbnailRenderer")]
	public partial class UPhysicsAssetThumbnailRenderer : UDefaultSizedThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.PhysicsAssetThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}