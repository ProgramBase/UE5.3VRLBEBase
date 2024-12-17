using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ProjectileMovementComponent_OnProjectileBounceDelegate__PythonCallable.ProjectileMovementComponent_OnProjectileBounceDelegate__PythonCallable")]
	public partial class ProjectileMovementComponent_OnProjectileBounceDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ProjectileMovementComponent_OnProjectileBounceDelegate__PythonCallable.ProjectileMovementComponent_OnProjectileBounceDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}