using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/InstigatedAnyDamageSignature__PythonCallable.InstigatedAnyDamageSignature__PythonCallable")]
	public partial class InstigatedAnyDamageSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/InstigatedAnyDamageSignature__PythonCallable.InstigatedAnyDamageSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}