using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ActorPerceptionForgetUpdatedDelegate__PythonCallable.ActorPerceptionForgetUpdatedDelegate__PythonCallable")]
	public partial class ActorPerceptionForgetUpdatedDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ActorPerceptionForgetUpdatedDelegate__PythonCallable.ActorPerceptionForgetUpdatedDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}