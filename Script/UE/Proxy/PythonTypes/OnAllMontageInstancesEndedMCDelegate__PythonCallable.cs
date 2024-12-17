using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnAllMontageInstancesEndedMCDelegate__PythonCallable.OnAllMontageInstancesEndedMCDelegate__PythonCallable")]
	public partial class OnAllMontageInstancesEndedMCDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnAllMontageInstancesEndedMCDelegate__PythonCallable.OnAllMontageInstancesEndedMCDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}