using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.BlendSpaceThumbnailRenderer")]
	public partial class UBlendSpaceThumbnailRenderer : UDefaultSizedThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.BlendSpaceThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}