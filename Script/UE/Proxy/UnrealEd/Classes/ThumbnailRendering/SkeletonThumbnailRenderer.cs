using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SkeletonThumbnailRenderer")]
	public partial class USkeletonThumbnailRenderer : UDefaultSizedThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.SkeletonThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}