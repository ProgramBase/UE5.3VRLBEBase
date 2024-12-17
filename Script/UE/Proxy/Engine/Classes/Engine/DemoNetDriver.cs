using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DemoNetDriver")]
	public partial class UDemoNetDriver : UNetDriver, IStaticClass
	{
		public TMap<FString, FRollbackNetStartupActorInfo> RollbackNetStartupActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RollbackNetStartupActors, __ReturnBuffer);

					return *(TMap<FString, FRollbackNetStartupActorInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RollbackNetStartupActors, __InBuffer);
				}
			}
		}

		public float CheckpointSaveMaxMSPerFrame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CheckpointSaveMaxMSPerFrame, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CheckpointSaveMaxMSPerFrame, __InBuffer);
				}
			}
		}

		public TArray<FMulticastRecordOptions> MulticastRecordOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MulticastRecordOptions, __ReturnBuffer);

					return *(TArray<FMulticastRecordOptions>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MulticastRecordOptions, __InBuffer);
				}
			}
		}

		public TArray<APlayerController> SpectatorControllers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpectatorControllers, __ReturnBuffer);

					return *(TArray<APlayerController>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpectatorControllers, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DemoNetDriver");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __RollbackNetStartupActors = 0;

		private static uint __CheckpointSaveMaxMSPerFrame = 0;

		private static uint __MulticastRecordOptions = 0;

		private static uint __SpectatorControllers = 0;
	}
}