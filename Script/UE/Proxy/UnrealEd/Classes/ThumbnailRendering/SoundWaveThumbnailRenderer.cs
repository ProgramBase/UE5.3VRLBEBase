using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SoundWaveThumbnailRenderer")]
	public partial class USoundWaveThumbnailRenderer : UDefaultSizedThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.SoundWaveThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}