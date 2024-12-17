using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnMainAudioOutputDeviceObtained__PythonCallable.OnMainAudioOutputDeviceObtained__PythonCallable")]
	public partial class OnMainAudioOutputDeviceObtained__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnMainAudioOutputDeviceObtained__PythonCallable.OnMainAudioOutputDeviceObtained__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}