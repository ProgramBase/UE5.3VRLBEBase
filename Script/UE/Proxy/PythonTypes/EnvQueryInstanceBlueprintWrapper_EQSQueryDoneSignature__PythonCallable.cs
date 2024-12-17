using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/EnvQueryInstanceBlueprintWrapper_EQSQueryDoneSignature__PythonCallable.EnvQueryInstanceBlueprintWrapper_EQSQueryDoneSignature__PythonCallable")]
	public partial class EnvQueryInstanceBlueprintWrapper_EQSQueryDoneSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/EnvQueryInstanceBlueprintWrapper_EQSQueryDoneSignature__PythonCallable.EnvQueryInstanceBlueprintWrapper_EQSQueryDoneSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}