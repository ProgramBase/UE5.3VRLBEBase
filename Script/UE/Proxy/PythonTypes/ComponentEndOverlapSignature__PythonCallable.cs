using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ComponentEndOverlapSignature__PythonCallable.ComponentEndOverlapSignature__PythonCallable")]
	public partial class ComponentEndOverlapSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ComponentEndOverlapSignature__PythonCallable.ComponentEndOverlapSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}