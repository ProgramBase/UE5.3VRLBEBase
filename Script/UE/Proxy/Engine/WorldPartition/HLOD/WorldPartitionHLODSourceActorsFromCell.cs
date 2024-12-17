using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionHLODSourceActorsFromCell")]
	public partial class UWorldPartitionHLODSourceActorsFromCell : UWorldPartitionHLODSourceActors, IStaticClass
	{
		public TArray<FHLODSubActor> Actors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Actors, __ReturnBuffer);

					return *(TArray<FHLODSubActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Actors, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionHLODSourceActorsFromCell");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Actors = 0;
	}
}