using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/PyTestStructDelegate_OnNameCollisionDelegate__PythonCallable.PyTestStructDelegate_OnNameCollisionDelegate__PythonCallable")]
	public partial class PyTestStructDelegate_OnNameCollisionDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/PyTestStructDelegate_OnNameCollisionDelegate__PythonCallable.PyTestStructDelegate_OnNameCollisionDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}