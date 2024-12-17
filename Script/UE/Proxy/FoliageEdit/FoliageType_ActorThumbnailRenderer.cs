using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.FoliageEdit
{
	[PathName("/Script/FoliageEdit.FoliageType_ActorThumbnailRenderer")]
	public partial class UFoliageType_ActorThumbnailRenderer : UBlueprintThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FoliageEdit.FoliageType_ActorThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}