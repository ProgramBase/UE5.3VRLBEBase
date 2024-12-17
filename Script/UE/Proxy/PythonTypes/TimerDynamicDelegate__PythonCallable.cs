using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/TimerDynamicDelegate__PythonCallable.TimerDynamicDelegate__PythonCallable")]
	public partial class TimerDynamicDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/TimerDynamicDelegate__PythonCallable.TimerDynamicDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}