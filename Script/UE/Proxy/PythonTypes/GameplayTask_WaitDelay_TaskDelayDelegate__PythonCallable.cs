using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/GameplayTask_WaitDelay_TaskDelayDelegate__PythonCallable.GameplayTask_WaitDelay_TaskDelayDelegate__PythonCallable")]
	public partial class GameplayTask_WaitDelay_TaskDelayDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/GameplayTask_WaitDelay_TaskDelayDelegate__PythonCallable.GameplayTask_WaitDelay_TaskDelayDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}