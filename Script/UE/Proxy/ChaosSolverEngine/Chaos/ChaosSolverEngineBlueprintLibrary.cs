using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ChaosSolverEngine
{
	[PathName("/Script/ChaosSolverEngine.ChaosSolverEngineBlueprintLibrary")]
	public partial class UChaosSolverEngineBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosSolverEngine.ChaosSolverEngineBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FHitResult ConvertPhysicsCollisionToHitResult(FChaosPhysicsCollisionInfo PhysicsCollision)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PhysicsCollision?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertPhysicsCollisionToHitResult, __InBuffer, __ReturnBuffer);

				return *(FHitResult*)__ReturnBuffer;
			}
		}

		private static uint __ConvertPhysicsCollisionToHitResult = 0;
	}
}