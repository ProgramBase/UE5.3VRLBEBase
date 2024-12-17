using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnQuartzCommandEvent__PythonCallable.OnQuartzCommandEvent__PythonCallable")]
	public partial class OnQuartzCommandEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnQuartzCommandEvent__PythonCallable.OnQuartzCommandEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}