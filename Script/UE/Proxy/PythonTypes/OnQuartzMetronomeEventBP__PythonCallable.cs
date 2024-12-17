using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnQuartzMetronomeEventBP__PythonCallable.OnQuartzMetronomeEventBP__PythonCallable")]
	public partial class OnQuartzMetronomeEventBP__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnQuartzMetronomeEventBP__PythonCallable.OnQuartzMetronomeEventBP__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}