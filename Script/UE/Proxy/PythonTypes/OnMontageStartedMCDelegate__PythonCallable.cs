using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnMontageStartedMCDelegate__PythonCallable.OnMontageStartedMCDelegate__PythonCallable")]
	public partial class OnMontageStartedMCDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnMontageStartedMCDelegate__PythonCallable.OnMontageStartedMCDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}