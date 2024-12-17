using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/InstancePointDamageSignature__PythonCallable.InstancePointDamageSignature__PythonCallable")]
	public partial class InstancePointDamageSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/InstancePointDamageSignature__PythonCallable.InstancePointDamageSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}