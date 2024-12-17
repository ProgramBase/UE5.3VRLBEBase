using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ActorDestroyedSignature__PythonCallable.ActorDestroyedSignature__PythonCallable")]
	public partial class ActorDestroyedSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ActorDestroyedSignature__PythonCallable.ActorDestroyedSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}