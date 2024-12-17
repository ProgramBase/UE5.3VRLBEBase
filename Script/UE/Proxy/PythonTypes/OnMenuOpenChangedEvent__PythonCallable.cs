using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnMenuOpenChangedEvent__PythonCallable.OnMenuOpenChangedEvent__PythonCallable")]
	public partial class OnMenuOpenChangedEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnMenuOpenChangedEvent__PythonCallable.OnMenuOpenChangedEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}