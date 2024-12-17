using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnAudioDefaultDeviceChanged__PythonCallable.OnAudioDefaultDeviceChanged__PythonCallable")]
	public partial class OnAudioDefaultDeviceChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnAudioDefaultDeviceChanged__PythonCallable.OnAudioDefaultDeviceChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}