using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionHLODSourceActorsFromLevel")]
	public partial class UWorldPartitionHLODSourceActorsFromLevel : UWorldPartitionHLODSourceActors, IStaticClass
	{
		public TSoftObjectPtr<UWorld> SourceLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceLevel, __ReturnBuffer);

					return *(TSoftObjectPtr<UWorld>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceLevel, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionHLODSourceActorsFromLevel");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SourceLevel = 0;
	}
}