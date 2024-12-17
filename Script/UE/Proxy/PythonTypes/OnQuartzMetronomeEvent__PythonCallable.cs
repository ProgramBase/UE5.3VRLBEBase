using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnQuartzMetronomeEvent__PythonCallable.OnQuartzMetronomeEvent__PythonCallable")]
	public partial class OnQuartzMetronomeEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnQuartzMetronomeEvent__PythonCallable.OnQuartzMetronomeEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}