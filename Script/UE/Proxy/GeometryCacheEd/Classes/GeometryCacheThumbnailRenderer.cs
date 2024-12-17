using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.GeometryCacheEd
{
	[PathName("/Script/GeometryCacheEd.GeometryCacheThumbnailRenderer")]
	public partial class UGeometryCacheThumbnailRenderer : UDefaultSizedThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCacheEd.GeometryCacheThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}