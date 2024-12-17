using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/TakePointDamageSignature__PythonCallable.TakePointDamageSignature__PythonCallable")]
	public partial class TakePointDamageSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/TakePointDamageSignature__PythonCallable.TakePointDamageSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}