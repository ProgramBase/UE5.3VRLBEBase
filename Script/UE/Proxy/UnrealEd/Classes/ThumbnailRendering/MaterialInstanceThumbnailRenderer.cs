using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialInstanceThumbnailRenderer")]
	public partial class UMaterialInstanceThumbnailRenderer : UDefaultSizedThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.MaterialInstanceThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}