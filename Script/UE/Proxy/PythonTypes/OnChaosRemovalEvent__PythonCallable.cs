using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnChaosRemovalEvent__PythonCallable.OnChaosRemovalEvent__PythonCallable")]
	public partial class OnChaosRemovalEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnChaosRemovalEvent__PythonCallable.OnChaosRemovalEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}