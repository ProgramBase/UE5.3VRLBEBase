using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.GeometryCollectionEditor
{
	[PathName("/Script/GeometryCollectionEditor.GeometryCollectionThumbnailRenderer")]
	public partial class UGeometryCollectionThumbnailRenderer : UDefaultSizedThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCollectionEditor.GeometryCollectionThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}