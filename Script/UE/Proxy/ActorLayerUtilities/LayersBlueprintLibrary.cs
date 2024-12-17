using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ActorLayerUtilities
{
	[PathName("/Script/ActorLayerUtilities.LayersBlueprintLibrary")]
	public partial class ULayersBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ActorLayerUtilities.LayersBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void RemoveActorFromLayer(AActor InActor, FActorLayer Layer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Layer?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveActorFromLayer, __InBuffer);
			}
		}

		public static TArray<AActor> GetActors(UObject WorldContextObject, FActorLayer ActorLayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ActorLayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetActors, __InBuffer, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		public static void AddActorToLayer(AActor InActor, FActorLayer Layer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Layer?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddActorToLayer, __InBuffer);
			}
		}

		private static uint __RemoveActorFromLayer = 0;

		private static uint __GetActors = 0;

		private static uint __AddActorToLayer = 0;
	}
}