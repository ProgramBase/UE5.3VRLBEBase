using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnDataLayerRuntimeStateChanged__PythonCallable.OnDataLayerRuntimeStateChanged__PythonCallable")]
	public partial class OnDataLayerRuntimeStateChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnDataLayerRuntimeStateChanged__PythonCallable.OnDataLayerRuntimeStateChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}