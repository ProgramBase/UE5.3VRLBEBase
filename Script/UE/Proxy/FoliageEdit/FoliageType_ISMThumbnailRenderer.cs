using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.FoliageEdit
{
	[PathName("/Script/FoliageEdit.FoliageType_ISMThumbnailRenderer")]
	public partial class UFoliageType_ISMThumbnailRenderer : UDefaultSizedThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FoliageEdit.FoliageType_ISMThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}