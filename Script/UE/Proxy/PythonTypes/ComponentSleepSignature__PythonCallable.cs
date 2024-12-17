using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ComponentSleepSignature__PythonCallable.ComponentSleepSignature__PythonCallable")]
	public partial class ComponentSleepSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ComponentSleepSignature__PythonCallable.ComponentSleepSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}