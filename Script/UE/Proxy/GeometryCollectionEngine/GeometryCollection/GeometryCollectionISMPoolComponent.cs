using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.GeometryCollectionISMPoolComponent")]
	public partial class UGeometryCollectionISMPoolComponent : USceneComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCollectionEngine.GeometryCollectionISMPoolComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}