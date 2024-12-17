using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LightWeightInstanceBlueprintFunctionLibrary")]
	public partial class ULightWeightInstanceBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LightWeightInstanceBlueprintFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FActorInstanceHandle CreateNewLightWeightInstance(UClass ActorClass, FTransform Transform, UDataLayerInstance Layer, UWorld World)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = ActorClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Transform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Layer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = World?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateNewLightWeightInstance, __InBuffer, __ReturnBuffer);

				return *(FActorInstanceHandle*)__ReturnBuffer;
			}
		}

		public static FActorInstanceHandle ConvertActorToLightWeightInstance(AActor Actor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertActorToLightWeightInstance, __InBuffer, __ReturnBuffer);

				return *(FActorInstanceHandle*)__ReturnBuffer;
			}
		}

		private static uint __CreateNewLightWeightInstance = 0;

		private static uint __ConvertActorToLightWeightInstance = 0;
	}
}