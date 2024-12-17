using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.AnimSequenceThumbnailRenderer")]
	public partial class UAnimSequenceThumbnailRenderer : UDefaultSizedThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.AnimSequenceThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}