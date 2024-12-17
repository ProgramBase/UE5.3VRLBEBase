using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/IsRootComponentChanged__PythonCallable.IsRootComponentChanged__PythonCallable")]
	public partial class IsRootComponentChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/IsRootComponentChanged__PythonCallable.IsRootComponentChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}