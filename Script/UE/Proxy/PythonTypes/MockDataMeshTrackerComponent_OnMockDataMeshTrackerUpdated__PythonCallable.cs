using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/MockDataMeshTrackerComponent_OnMockDataMeshTrackerUpdated__PythonCallable.MockDataMeshTrackerComponent_OnMockDataMeshTrackerUpdated__PythonCallable")]
	public partial class MockDataMeshTrackerComponent_OnMockDataMeshTrackerUpdated__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/MockDataMeshTrackerComponent_OnMockDataMeshTrackerUpdated__PythonCallable.MockDataMeshTrackerComponent_OnMockDataMeshTrackerUpdated__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}