using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SkeletalMeshThumbnailRenderer")]
	public partial class USkeletalMeshThumbnailRenderer : UDefaultSizedThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.SkeletalMeshThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}