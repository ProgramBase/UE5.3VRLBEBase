using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnControllerCaptureBeginEvent__PythonCallable.OnControllerCaptureBeginEvent__PythonCallable")]
	public partial class OnControllerCaptureBeginEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnControllerCaptureBeginEvent__PythonCallable.OnControllerCaptureBeginEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}