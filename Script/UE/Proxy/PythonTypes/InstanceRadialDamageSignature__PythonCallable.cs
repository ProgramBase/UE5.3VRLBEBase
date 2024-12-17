using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/InstanceRadialDamageSignature__PythonCallable.InstanceRadialDamageSignature__PythonCallable")]
	public partial class InstanceRadialDamageSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/InstanceRadialDamageSignature__PythonCallable.InstanceRadialDamageSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}