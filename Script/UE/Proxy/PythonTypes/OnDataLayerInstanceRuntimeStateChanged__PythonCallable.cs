using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnDataLayerInstanceRuntimeStateChanged__PythonCallable.OnDataLayerInstanceRuntimeStateChanged__PythonCallable")]
	public partial class OnDataLayerInstanceRuntimeStateChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnDataLayerInstanceRuntimeStateChanged__PythonCallable.OnDataLayerInstanceRuntimeStateChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}