using Script.CoreUObject;
using Script.Engine;
using Script.NavigationSystem;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.PathFollowingComponent")]
	public partial class UPathFollowingComponent : UActorComponent, IStaticClass, IAIResourceInterface, IPathFollowingAgentInterface
	{
		public UNavMovementComponent MovementComp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MovementComp, __ReturnBuffer);

					return *(UNavMovementComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MovementComp, __InBuffer);
				}
			}
		}

		public ANavigationData MyNavData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MyNavData, __ReturnBuffer);

					return *(ANavigationData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MyNavData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.PathFollowingComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		public virtual void OnNavDataRegistered(ANavigationData NavData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NavData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnNavDataRegistered, __InBuffer);
			}
		}

		public virtual void OnActorBump(AActor SelfActor, AActor OtherActor, FVector NormalImpulse, FHitResult Hit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = SelfActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OtherActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NormalImpulse?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Hit?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnActorBump, __InBuffer);
			}
		}

		public virtual FVector GetPathDestination()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPathDestination, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual EPathFollowingAction GetPathActionType()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPathActionType, __ReturnBuffer);

				return *(EPathFollowingAction*)__ReturnBuffer;
			}
		}

		private static uint __MovementComp = 0;

		private static uint __MyNavData = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __OnNavDataRegistered = 0;

		private static uint __OnActorBump = 0;

		private static uint __GetPathDestination = 0;

		private static uint __GetPathActionType = 0;
	}
}