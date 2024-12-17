using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnTakeRecorderStopped__PythonCallable.OnTakeRecorderStopped__PythonCallable")]
	public partial class OnTakeRecorderStopped__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnTakeRecorderStopped__PythonCallable.OnTakeRecorderStopped__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}