using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnAnimInitialized__PythonCallable.OnAnimInitialized__PythonCallable")]
	public partial class OnAnimInitialized__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnAnimInitialized__PythonCallable.OnAnimInitialized__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}