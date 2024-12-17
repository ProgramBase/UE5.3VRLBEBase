using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.AnimBlueprintThumbnailRenderer")]
	public partial class UAnimBlueprintThumbnailRenderer : UDefaultSizedThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.AnimBlueprintThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}