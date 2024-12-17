using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/RemovalEventSignature__PythonCallable.RemovalEventSignature__PythonCallable")]
	public partial class RemovalEventSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/RemovalEventSignature__PythonCallable.RemovalEventSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}