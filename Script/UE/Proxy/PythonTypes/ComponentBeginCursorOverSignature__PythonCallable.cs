using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ComponentBeginCursorOverSignature__PythonCallable.ComponentBeginCursorOverSignature__PythonCallable")]
	public partial class ComponentBeginCursorOverSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ComponentBeginCursorOverSignature__PythonCallable.ComponentBeginCursorOverSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}