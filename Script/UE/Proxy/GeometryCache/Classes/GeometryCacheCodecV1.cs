using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCache
{
	[PathName("/Script/GeometryCache.GeometryCacheCodecV1")]
	public partial class UGeometryCacheCodecV1 : UGeometryCacheCodecBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCache.GeometryCacheCodecV1");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}