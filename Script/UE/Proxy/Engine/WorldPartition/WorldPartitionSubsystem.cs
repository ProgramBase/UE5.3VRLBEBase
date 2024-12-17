using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionSubsystem")]
	public partial class UWorldPartitionSubsystem : UTickableWorldSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool IsStreamingCompleted(EWorldPartitionRuntimeCellState QueryState, TArray<FWorldPartitionStreamingQuerySource> QuerySources, bool bExactState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(byte*)(__InBuffer) = (byte)QueryState;

				*(nint*)(__InBuffer + 1) = QuerySources?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 9) = bExactState;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsStreamingCompleted, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsAllStreamingCompleted()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsAllStreamingCompleted, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __IsStreamingCompleted = 0;

		private static uint __IsAllStreamingCompleted = 0;
	}
}