using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnMontageEndedMCDelegate__PythonCallable.OnMontageEndedMCDelegate__PythonCallable")]
	public partial class OnMontageEndedMCDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnMontageEndedMCDelegate__PythonCallable.OnMontageEndedMCDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}