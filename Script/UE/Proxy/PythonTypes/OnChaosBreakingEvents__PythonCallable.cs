using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnChaosBreakingEvents__PythonCallable.OnChaosBreakingEvents__PythonCallable")]
	public partial class OnChaosBreakingEvents__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnChaosBreakingEvents__PythonCallable.OnChaosBreakingEvents__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}