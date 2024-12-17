using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnCheckBoxComponentStateChanged__PythonCallable.OnCheckBoxComponentStateChanged__PythonCallable")]
	public partial class OnCheckBoxComponentStateChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnCheckBoxComponentStateChanged__PythonCallable.OnCheckBoxComponentStateChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}