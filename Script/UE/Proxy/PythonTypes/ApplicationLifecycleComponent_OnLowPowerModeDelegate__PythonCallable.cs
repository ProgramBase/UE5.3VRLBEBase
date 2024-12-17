using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ApplicationLifecycleComponent_OnLowPowerModeDelegate__PythonCallable.ApplicationLifecycleComponent_OnLowPowerModeDelegate__PythonCallable")]
	public partial class ApplicationLifecycleComponent_OnLowPowerModeDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ApplicationLifecycleComponent_OnLowPowerModeDelegate__PythonCallable.ApplicationLifecycleComponent_OnLowPowerModeDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}