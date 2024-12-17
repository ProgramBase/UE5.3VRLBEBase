using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/GameplayTask_TimeLimitedExecution_TaskFinishDelegate__PythonCallable.GameplayTask_TimeLimitedExecution_TaskFinishDelegate__PythonCallable")]
	public partial class GameplayTask_TimeLimitedExecution_TaskFinishDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/GameplayTask_TimeLimitedExecution_TaskFinishDelegate__PythonCallable.GameplayTask_TimeLimitedExecution_TaskFinishDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}