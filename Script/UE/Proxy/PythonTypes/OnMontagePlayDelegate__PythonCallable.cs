using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnMontagePlayDelegate__PythonCallable.OnMontagePlayDelegate__PythonCallable")]
	public partial class OnMontagePlayDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnMontagePlayDelegate__PythonCallable.OnMontagePlayDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}