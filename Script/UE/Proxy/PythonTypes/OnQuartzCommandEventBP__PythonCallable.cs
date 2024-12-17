using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnQuartzCommandEventBP__PythonCallable.OnQuartzCommandEventBP__PythonCallable")]
	public partial class OnQuartzCommandEventBP__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnQuartzCommandEventBP__PythonCallable.OnQuartzCommandEventBP__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}