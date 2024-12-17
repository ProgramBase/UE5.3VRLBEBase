using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnChaosTrailingEvents__PythonCallable.OnChaosTrailingEvents__PythonCallable")]
	public partial class OnChaosTrailingEvents__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnChaosTrailingEvents__PythonCallable.OnChaosTrailingEvents__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}