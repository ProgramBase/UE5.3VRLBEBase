using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnAudioInputDevicesObtained__PythonCallable.OnAudioInputDevicesObtained__PythonCallable")]
	public partial class OnAudioInputDevicesObtained__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnAudioInputDevicesObtained__PythonCallable.OnAudioInputDevicesObtained__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}