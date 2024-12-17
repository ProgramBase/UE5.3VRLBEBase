using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.PawnActionsComponent")]
	public partial class UDEPRECATED_PawnActionsComponent : UActorComponent, IStaticClass
	{
		public APawn ControlledPawn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ControlledPawn, __ReturnBuffer);

					return *(APawn*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ControlledPawn, __InBuffer);
				}
			}
		}

		public TArray<FPawnActionStack> ActionStacks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActionStacks, __ReturnBuffer);

					return *(TArray<FPawnActionStack>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActionStacks, __InBuffer);
				}
			}
		}

		public TArray<FPawnActionEvent> ActionEvents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActionEvents, __ReturnBuffer);

					return *(TArray<FPawnActionEvent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActionEvents, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.PawnActionsComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool K2_PushAction(UDEPRECATED_PawnAction NewAction, EAIRequestPriority Priority, UObject Instigator = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = NewAction?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Priority;

				*(nint*)(__InBuffer + 9) = Instigator?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __K2_PushAction, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool K2_PerformAction(APawn Pawn, UDEPRECATED_PawnAction Action, EAIRequestPriority Priority = EAIRequestPriority.HardScript)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Pawn?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Action?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Priority;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_PerformAction, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual EPawnActionAbortState K2_ForceAbortAction(UDEPRECATED_PawnAction ActionToAbort)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActionToAbort?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __K2_ForceAbortAction, __InBuffer, __ReturnBuffer);

				return *(EPawnActionAbortState*)__ReturnBuffer;
			}
		}

		public virtual EPawnActionAbortState K2_AbortAction(UDEPRECATED_PawnAction ActionToAbort)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActionToAbort?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __K2_AbortAction, __InBuffer, __ReturnBuffer);

				return *(EPawnActionAbortState*)__ReturnBuffer;
			}
		}

		private static uint __ControlledPawn = 0;

		private static uint __ActionStacks = 0;

		private static uint __ActionEvents = 0;

		private static uint __K2_PushAction = 0;

		private static uint __K2_PerformAction = 0;

		private static uint __K2_ForceAbortAction = 0;

		private static uint __K2_AbortAction = 0;
	}
}