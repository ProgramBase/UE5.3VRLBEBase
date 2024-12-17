using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/PyTestMulticastDelegate__PythonCallable.PyTestMulticastDelegate__PythonCallable")]
	public partial class PyTestMulticastDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/PyTestMulticastDelegate__PythonCallable.PyTestMulticastDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}