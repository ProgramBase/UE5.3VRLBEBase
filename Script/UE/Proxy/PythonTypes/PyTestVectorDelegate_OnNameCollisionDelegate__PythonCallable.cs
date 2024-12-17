using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/PyTestVectorDelegate_OnNameCollisionDelegate__PythonCallable.PyTestVectorDelegate_OnNameCollisionDelegate__PythonCallable")]
	public partial class PyTestVectorDelegate_OnNameCollisionDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/PyTestVectorDelegate_OnNameCollisionDelegate__PythonCallable.PyTestVectorDelegate_OnNameCollisionDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}