using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ComponentOnInputTouchBeginSignature__PythonCallable.ComponentOnInputTouchBeginSignature__PythonCallable")]
	public partial class ComponentOnInputTouchBeginSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ComponentOnInputTouchBeginSignature__PythonCallable.ComponentOnInputTouchBeginSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}