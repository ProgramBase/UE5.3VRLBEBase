using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnUserScrolledEvent__PythonCallable.OnUserScrolledEvent__PythonCallable")]
	public partial class OnUserScrolledEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnUserScrolledEvent__PythonCallable.OnUserScrolledEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}