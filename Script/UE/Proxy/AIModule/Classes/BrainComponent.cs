using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BrainComponent")]
	public partial class UBrainComponent : UActorComponent, IStaticClass, IAIResourceInterface
	{
		public UBlackboardComponent BlackboardComp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlackboardComp, __ReturnBuffer);

					return *(UBlackboardComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlackboardComp, __InBuffer);
				}
			}
		}

		public AAIController AIOwner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AIOwner, __ReturnBuffer);

					return *(AAIController*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AIOwner, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BrainComponent");
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

		public virtual void StopLogic(FString Reason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Reason?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopLogic, __InBuffer);
			}
		}

		public virtual void StartLogic()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StartLogic);
			}
		}

		public virtual void RestartLogic()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RestartLogic);
			}
		}

		public virtual bool IsRunning()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsRunning, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsPaused()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPaused, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __BlackboardComp = 0;

		private static uint __AIOwner = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __StopLogic = 0;

		private static uint __StartLogic = 0;

		private static uint __RestartLogic = 0;

		private static uint __IsRunning = 0;

		private static uint __IsPaused = 0;
	}
}