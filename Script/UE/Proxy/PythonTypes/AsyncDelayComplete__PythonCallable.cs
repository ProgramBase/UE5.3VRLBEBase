using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/AsyncDelayComplete__PythonCallable.AsyncDelayComplete__PythonCallable")]
	public partial class AsyncDelayComplete__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/AsyncDelayComplete__PythonCallable.AsyncDelayComplete__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}