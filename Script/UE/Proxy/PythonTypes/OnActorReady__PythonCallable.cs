using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnActorReady__PythonCallable.OnActorReady__PythonCallable")]
	public partial class OnActorReady__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnActorReady__PythonCallable.OnActorReady__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}