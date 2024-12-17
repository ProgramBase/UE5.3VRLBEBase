using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ActorComponentDeactivateSignature__PythonCallable.ActorComponentDeactivateSignature__PythonCallable")]
	public partial class ActorComponentDeactivateSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ActorComponentDeactivateSignature__PythonCallable.ActorComponentDeactivateSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}