using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/TakesCoreBlueprintLibrary_OnTakeRecorderSlateChanged__PythonCallable.TakesCoreBlueprintLibrary_OnTakeRecorderSlateChanged__PythonCallable")]
	public partial class TakesCoreBlueprintLibrary_OnTakeRecorderSlateChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/TakesCoreBlueprintLibrary_OnTakeRecorderSlateChanged__PythonCallable.TakesCoreBlueprintLibrary_OnTakeRecorderSlateChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}