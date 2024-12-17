using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ComponentOnClickedSignature__PythonCallable.ComponentOnClickedSignature__PythonCallable")]
	public partial class ComponentOnClickedSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ComponentOnClickedSignature__PythonCallable.ComponentOnClickedSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}