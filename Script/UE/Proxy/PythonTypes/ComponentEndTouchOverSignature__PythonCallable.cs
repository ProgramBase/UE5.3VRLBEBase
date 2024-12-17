using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ComponentEndTouchOverSignature__PythonCallable.ComponentEndTouchOverSignature__PythonCallable")]
	public partial class ComponentEndTouchOverSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ComponentEndTouchOverSignature__PythonCallable.ComponentEndTouchOverSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}