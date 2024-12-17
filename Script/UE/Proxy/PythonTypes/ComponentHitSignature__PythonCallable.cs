using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ComponentHitSignature__PythonCallable.ComponentHitSignature__PythonCallable")]
	public partial class ComponentHitSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ComponentHitSignature__PythonCallable.ComponentHitSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}