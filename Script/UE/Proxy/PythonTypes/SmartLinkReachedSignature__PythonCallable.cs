using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/SmartLinkReachedSignature__PythonCallable.SmartLinkReachedSignature__PythonCallable")]
	public partial class SmartLinkReachedSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/SmartLinkReachedSignature__PythonCallable.SmartLinkReachedSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}