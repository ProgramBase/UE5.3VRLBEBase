using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnAudioOutputDevicesObtained__PythonCallable.OnAudioOutputDevicesObtained__PythonCallable")]
	public partial class OnAudioOutputDevicesObtained__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnAudioOutputDevicesObtained__PythonCallable.OnAudioOutputDevicesObtained__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}