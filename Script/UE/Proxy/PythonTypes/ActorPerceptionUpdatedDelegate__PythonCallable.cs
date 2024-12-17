using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ActorPerceptionUpdatedDelegate__PythonCallable.ActorPerceptionUpdatedDelegate__PythonCallable")]
	public partial class ActorPerceptionUpdatedDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ActorPerceptionUpdatedDelegate__PythonCallable.ActorPerceptionUpdatedDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}