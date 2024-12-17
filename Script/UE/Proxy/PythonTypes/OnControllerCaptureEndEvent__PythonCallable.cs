using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnControllerCaptureEndEvent__PythonCallable.OnControllerCaptureEndEvent__PythonCallable")]
	public partial class OnControllerCaptureEndEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnControllerCaptureEndEvent__PythonCallable.OnControllerCaptureEndEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}