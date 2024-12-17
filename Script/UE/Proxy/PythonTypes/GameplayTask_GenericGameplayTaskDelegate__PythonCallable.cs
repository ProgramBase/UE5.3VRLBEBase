using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/GameplayTask_GenericGameplayTaskDelegate__PythonCallable.GameplayTask_GenericGameplayTaskDelegate__PythonCallable")]
	public partial class GameplayTask_GenericGameplayTaskDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/GameplayTask_GenericGameplayTaskDelegate__PythonCallable.GameplayTask_GenericGameplayTaskDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}