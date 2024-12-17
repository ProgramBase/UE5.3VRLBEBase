using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnTakeRecorderFinished__PythonCallable.OnTakeRecorderFinished__PythonCallable")]
	public partial class OnTakeRecorderFinished__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnTakeRecorderFinished__PythonCallable.OnTakeRecorderFinished__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}