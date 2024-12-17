using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.PawnAction_BlueprintBase")]
	public partial class UDEPRECATED_PawnAction_BlueprintBase : UDEPRECATED_PawnAction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.PawnAction_BlueprintBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ActionTick(APawn ControlledPawn, float DeltaSeconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ControlledPawn?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = DeltaSeconds;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ActionTick, __InBuffer);
			}
		}

		public virtual void ActionStart(APawn ControlledPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ControlledPawn?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ActionStart, __InBuffer);
			}
		}

		public virtual void ActionResume(APawn ControlledPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ControlledPawn?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ActionResume, __InBuffer);
			}
		}

		public virtual void ActionPause(APawn ControlledPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ControlledPawn?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ActionPause, __InBuffer);
			}
		}

		public virtual void ActionFinished(APawn ControlledPawn, EPawnActionResult WithResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ControlledPawn?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)WithResult;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ActionFinished, __InBuffer);
			}
		}

		private static uint __ActionTick = 0;

		private static uint __ActionStart = 0;

		private static uint __ActionResume = 0;

		private static uint __ActionPause = 0;

		private static uint __ActionFinished = 0;
	}
}