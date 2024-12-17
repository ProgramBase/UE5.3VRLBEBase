using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.GeometryCacheEd
{
	[PathName("/Script/GeometryCacheEd.ActorFactoryGeometryCache")]
	public partial class UActorFactoryGeometryCache : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCacheEd.ActorFactoryGeometryCache");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}