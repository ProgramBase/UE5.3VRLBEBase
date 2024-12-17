using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnConstructEvent__PythonCallable.OnConstructEvent__PythonCallable")]
	public partial class OnConstructEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnConstructEvent__PythonCallable.OnConstructEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}