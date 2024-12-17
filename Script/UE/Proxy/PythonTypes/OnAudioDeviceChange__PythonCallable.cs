using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnAudioDeviceChange__PythonCallable.OnAudioDeviceChange__PythonCallable")]
	public partial class OnAudioDeviceChange__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnAudioDeviceChange__PythonCallable.OnAudioDeviceChange__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}