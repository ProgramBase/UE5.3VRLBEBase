using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/GeometryCollectionComponent_NotifyGeometryCollectionPhysicsLoadingStateChange__PythonCallable.GeometryCollectionComponent_NotifyGeometryCollectionPhysicsLoadingStateChange__PythonCallable")]
	public partial class GeometryCollectionComponent_NotifyGeometryCollectionPhysicsLoadingStateChange__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/GeometryCollectionComponent_NotifyGeometryCollectionPhysicsLoadingStateChange__PythonCallable.GeometryCollectionComponent_NotifyGeometryCollectionPhysicsLoadingStateChange__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}