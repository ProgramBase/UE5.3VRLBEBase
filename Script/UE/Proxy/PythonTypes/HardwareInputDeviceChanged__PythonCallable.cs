using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/HardwareInputDeviceChanged__PythonCallable.HardwareInputDeviceChanged__PythonCallable")]
	public partial class HardwareInputDeviceChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/HardwareInputDeviceChanged__PythonCallable.HardwareInputDeviceChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}