using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNotifyStateMachineInspectionLibrary")]
	public partial class UAnimNotifyStateMachineInspectionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimNotifyStateMachineInspectionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EventReference">
		/// The event to inspect
		/// </param>
		/// <param name="MeshComp">
		/// The skeletal mesh that contains the animation instance that produced the event
		/// </param>
		/// <param name="StateMachineName">
		/// The Name of a state machine to test
		/// </param>
		public static bool IsTriggeredByStateMachine(FAnimNotifyEventReference EventReference, UAnimInstance AnimInstance, FName StateMachineName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = EventReference?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AnimInstance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = StateMachineName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsTriggeredByStateMachine, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="EventReference">
		/// The event to inspect
		/// </param>
		/// <param name="MeshComp">
		/// The skeletal mesh that contains the animation instance that produced the event
		/// </param>
		/// <param name="StateMachineName">
		/// The name of a state machine to test
		/// </param>
		/// <param name="StateName">
		/// The name of a state to test
		/// </param>
		public static bool IsTriggeredByStateInStateMachine(FAnimNotifyEventReference EventReference, UAnimInstance AnimInstance, FName StateMachineName, FName StateName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = EventReference?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AnimInstance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = StateMachineName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = StateName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsTriggeredByStateInStateMachine, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="EventReference">
		/// The event to inspect
		/// </param>
		/// <param name="MeshComp">
		/// The skeletal mesh that contains the animation instance that produced the event
		/// </param>
		/// <param name="StateName">
		/// The name of a state to test
		/// </param>
		public static bool IsTriggeredByState(FAnimNotifyEventReference EventReference, UAnimInstance AnimInstance, FName StateName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = EventReference?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AnimInstance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = StateName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsTriggeredByState, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __IsTriggeredByStateMachine = 0;

		private static uint __IsTriggeredByStateInStateMachine = 0;

		private static uint __IsTriggeredByState = 0;
	}
}