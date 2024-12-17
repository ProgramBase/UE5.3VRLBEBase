using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnUserInputDevicePairingChange__PythonCallable.OnUserInputDevicePairingChange__PythonCallable")]
	public partial class OnUserInputDevicePairingChange__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnUserInputDevicePairingChange__PythonCallable.OnUserInputDevicePairingChange__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}