using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ComponentEndCursorOverSignature__PythonCallable.ComponentEndCursorOverSignature__PythonCallable")]
	public partial class ComponentEndCursorOverSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ComponentEndCursorOverSignature__PythonCallable.ComponentEndCursorOverSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}