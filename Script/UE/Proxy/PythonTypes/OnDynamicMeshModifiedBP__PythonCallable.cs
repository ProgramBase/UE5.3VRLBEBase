using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnDynamicMeshModifiedBP__PythonCallable.OnDynamicMeshModifiedBP__PythonCallable")]
	public partial class OnDynamicMeshModifiedBP__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnDynamicMeshModifiedBP__PythonCallable.OnDynamicMeshModifiedBP__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}