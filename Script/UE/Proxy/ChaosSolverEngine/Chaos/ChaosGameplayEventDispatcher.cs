using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ChaosSolverEngine
{
	[PathName("/Script/ChaosSolverEngine.ChaosGameplayEventDispatcher")]
	public partial class UChaosGameplayEventDispatcher : UChaosEventListenerComponent, IStaticClass
	{
		public TMap<UPrimitiveComponent, FChaosHandlerSet> CollisionEventRegistrations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionEventRegistrations, __ReturnBuffer);

					return *(TMap<UPrimitiveComponent, FChaosHandlerSet>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionEventRegistrations, __InBuffer);
				}
			}
		}

		public TMap<UPrimitiveComponent, FBreakEventCallbackWrapper> BreakEventRegistrations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BreakEventRegistrations, __ReturnBuffer);

					return *(TMap<UPrimitiveComponent, FBreakEventCallbackWrapper>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BreakEventRegistrations, __InBuffer);
				}
			}
		}

		public TMap<UPrimitiveComponent, FRemovalEventCallbackWrapper> RemovalEventRegistrations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RemovalEventRegistrations, __ReturnBuffer);

					return *(TMap<UPrimitiveComponent, FRemovalEventCallbackWrapper>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RemovalEventRegistrations, __InBuffer);
				}
			}
		}

		public TMap<UPrimitiveComponent, FCrumblingEventCallbackWrapper> CrumblingEventRegistrations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CrumblingEventRegistrations, __ReturnBuffer);

					return *(TMap<UPrimitiveComponent, FCrumblingEventCallbackWrapper>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CrumblingEventRegistrations, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosSolverEngine.ChaosGameplayEventDispatcher");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CollisionEventRegistrations = 0;

		private static uint __BreakEventRegistrations = 0;

		private static uint __RemovalEventRegistrations = 0;

		private static uint __CrumblingEventRegistrations = 0;
	}
}