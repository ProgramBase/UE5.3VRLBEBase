using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnControllerCaptureEndEventSynth2D__PythonCallable.OnControllerCaptureEndEventSynth2D__PythonCallable")]
	public partial class OnControllerCaptureEndEventSynth2D__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnControllerCaptureEndEventSynth2D__PythonCallable.OnControllerCaptureEndEventSynth2D__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}