using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ComponentOnInputTouchEndSignature__PythonCallable.ComponentOnInputTouchEndSignature__PythonCallable")]
	public partial class ComponentOnInputTouchEndSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ComponentOnInputTouchEndSignature__PythonCallable.ComponentOnInputTouchEndSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}