using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnAudioDeviceStateChanged__PythonCallable.OnAudioDeviceStateChanged__PythonCallable")]
	public partial class OnAudioDeviceStateChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnAudioDeviceStateChanged__PythonCallable.OnAudioDeviceStateChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}