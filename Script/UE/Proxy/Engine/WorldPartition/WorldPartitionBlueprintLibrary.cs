using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionBlueprintLibrary")]
	public partial class UWorldPartitionBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void UnpinActors(TArray<FGuid> InActorsToUnpin)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InActorsToUnpin?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __UnpinActors, __InBuffer);
			}
		}

		public static void UnloadActors(TArray<FGuid> InActorsToUnload)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InActorsToUnload?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __UnloadActors, __InBuffer);
			}
		}

		public static void PinActors(TArray<FGuid> InActorsToPin)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InActorsToPin?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PinActors, __InBuffer);
			}
		}

		public static void LoadActors(TArray<FGuid> InActorsToLoad)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InActorsToLoad?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __LoadActors, __InBuffer);
			}
		}

		/// <returns>
		/// The runtime world bounds.
		/// </returns>
		public static FBox GetRuntimeWorldBounds()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetRuntimeWorldBounds, __ReturnBuffer);

				return *(FBox*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// True if the operation was successful.
		/// </returns>
		public static bool GetIntersectingActorDescs(FBox InBox, ref TArray<FActorDesc> OutActorDescs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InBox?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutActorDescs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetIntersectingActorDescs, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutActorDescs = *(TArray<FActorDesc>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The editor world bounds.
		/// </returns>
		public static FBox GetEditorWorldBounds()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetEditorWorldBounds, __ReturnBuffer);

				return *(FBox*)__ReturnBuffer;
			}
		}

		public static UDataLayerManager GetDataLayerManager(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDataLayerManager, __InBuffer, __ReturnBuffer);

				return *(UDataLayerManager*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// True if the operation was successful.
		/// </returns>
		public static bool GetActorDescs(ref TArray<FActorDesc> OutActorDescs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutActorDescs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetActorDescs, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutActorDescs = *(TArray<FActorDesc>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __UnpinActors = 0;

		private static uint __UnloadActors = 0;

		private static uint __PinActors = 0;

		private static uint __LoadActors = 0;

		private static uint __GetRuntimeWorldBounds = 0;

		private static uint __GetIntersectingActorDescs = 0;

		private static uint __GetEditorWorldBounds = 0;

		private static uint __GetDataLayerManager = 0;

		private static uint __GetActorDescs = 0;
	}
}