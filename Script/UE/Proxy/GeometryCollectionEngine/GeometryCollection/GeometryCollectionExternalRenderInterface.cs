using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.GeometryCollectionExternalRenderInterface")]
	public partial class UGeometryCollectionExternalRenderInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCollectionEngine.GeometryCollectionExternalRenderInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/GeometryCollectionEngine.GeometryCollectionExternalRenderInterface")]
	public interface IGeometryCollectionExternalRenderInterface : IInterface
	{
	}
}