using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnUserInputDeviceConnectionChange__PythonCallable.OnUserInputDeviceConnectionChange__PythonCallable")]
	public partial class OnUserInputDeviceConnectionChange__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnUserInputDeviceConnectionChange__PythonCallable.OnUserInputDeviceConnectionChange__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}