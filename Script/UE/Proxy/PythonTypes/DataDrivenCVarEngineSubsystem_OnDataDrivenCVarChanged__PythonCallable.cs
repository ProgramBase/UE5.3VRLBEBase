using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/DataDrivenCVarEngineSubsystem_OnDataDrivenCVarChanged__PythonCallable.DataDrivenCVarEngineSubsystem_OnDataDrivenCVarChanged__PythonCallable")]
	public partial class DataDrivenCVarEngineSubsystem_OnDataDrivenCVarChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/DataDrivenCVarEngineSubsystem_OnDataDrivenCVarChanged__PythonCallable.DataDrivenCVarEngineSubsystem_OnDataDrivenCVarChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}