using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ProjectileMovementComponent_OnProjectileStopDelegate__PythonCallable.ProjectileMovementComponent_OnProjectileStopDelegate__PythonCallable")]
	public partial class ProjectileMovementComponent_OnProjectileStopDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ProjectileMovementComponent_OnProjectileStopDelegate__PythonCallable.ProjectileMovementComponent_OnProjectileStopDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}