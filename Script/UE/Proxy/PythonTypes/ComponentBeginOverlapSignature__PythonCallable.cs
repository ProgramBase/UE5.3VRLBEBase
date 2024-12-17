using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ComponentBeginOverlapSignature__PythonCallable.ComponentBeginOverlapSignature__PythonCallable")]
	public partial class ComponentBeginOverlapSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ComponentBeginOverlapSignature__PythonCallable.ComponentBeginOverlapSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}