using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ActorEndOverlapSignature__PythonCallable.ActorEndOverlapSignature__PythonCallable")]
	public partial class ActorEndOverlapSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ActorEndOverlapSignature__PythonCallable.ActorEndOverlapSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}