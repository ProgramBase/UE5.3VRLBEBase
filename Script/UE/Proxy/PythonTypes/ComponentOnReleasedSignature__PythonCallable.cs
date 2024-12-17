using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ComponentOnReleasedSignature__PythonCallable.ComponentOnReleasedSignature__PythonCallable")]
	public partial class ComponentOnReleasedSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ComponentOnReleasedSignature__PythonCallable.ComponentOnReleasedSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}