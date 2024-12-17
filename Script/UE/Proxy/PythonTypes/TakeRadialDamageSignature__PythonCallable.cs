using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/TakeRadialDamageSignature__PythonCallable.TakeRadialDamageSignature__PythonCallable")]
	public partial class TakeRadialDamageSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/TakeRadialDamageSignature__PythonCallable.TakeRadialDamageSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}