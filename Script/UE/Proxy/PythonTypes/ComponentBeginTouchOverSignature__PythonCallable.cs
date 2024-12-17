using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ComponentBeginTouchOverSignature__PythonCallable.ComponentBeginTouchOverSignature__PythonCallable")]
	public partial class ComponentBeginTouchOverSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ComponentBeginTouchOverSignature__PythonCallable.ComponentBeginTouchOverSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}