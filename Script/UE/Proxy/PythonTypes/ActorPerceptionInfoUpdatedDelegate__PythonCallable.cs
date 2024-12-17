using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ActorPerceptionInfoUpdatedDelegate__PythonCallable.ActorPerceptionInfoUpdatedDelegate__PythonCallable")]
	public partial class ActorPerceptionInfoUpdatedDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ActorPerceptionInfoUpdatedDelegate__PythonCallable.ActorPerceptionInfoUpdatedDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}