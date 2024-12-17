using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnChaosBreakEvent__PythonCallable.OnChaosBreakEvent__PythonCallable")]
	public partial class OnChaosBreakEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnChaosBreakEvent__PythonCallable.OnChaosBreakEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}