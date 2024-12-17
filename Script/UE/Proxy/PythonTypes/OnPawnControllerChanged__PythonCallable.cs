using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnPawnControllerChanged__PythonCallable.OnPawnControllerChanged__PythonCallable")]
	public partial class OnPawnControllerChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnPawnControllerChanged__PythonCallable.OnPawnControllerChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}