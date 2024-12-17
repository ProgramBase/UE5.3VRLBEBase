using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnChaosPhysicsCollision__PythonCallable.OnChaosPhysicsCollision__PythonCallable")]
	public partial class OnChaosPhysicsCollision__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnChaosPhysicsCollision__PythonCallable.OnChaosPhysicsCollision__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}