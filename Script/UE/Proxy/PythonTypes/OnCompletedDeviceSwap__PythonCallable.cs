using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnCompletedDeviceSwap__PythonCallable.OnCompletedDeviceSwap__PythonCallable")]
	public partial class OnCompletedDeviceSwap__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnCompletedDeviceSwap__PythonCallable.OnCompletedDeviceSwap__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}