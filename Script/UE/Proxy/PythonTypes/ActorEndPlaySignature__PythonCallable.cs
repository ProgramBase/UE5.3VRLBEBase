using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ActorEndPlaySignature__PythonCallable.ActorEndPlaySignature__PythonCallable")]
	public partial class ActorEndPlaySignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ActorEndPlaySignature__PythonCallable.ActorEndPlaySignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}