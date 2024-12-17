using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CachedAnimDataLibrary")]
	public partial class UCachedAnimDataLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CachedAnimDataLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool StateMachine_IsStateRelevant(UAnimInstance InAnimInstance, FCachedAnimStateData CachedAnimStateData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InAnimInstance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CachedAnimStateData?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __StateMachine_IsStateRelevant, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static float StateMachine_GetLocalWeight(UAnimInstance InAnimInstance, FCachedAnimStateData CachedAnimStateData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InAnimInstance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CachedAnimStateData?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __StateMachine_GetLocalWeight, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static float StateMachine_GetGlobalWeight(UAnimInstance InAnimInstance, FCachedAnimStateData CachedAnimStateData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InAnimInstance?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CachedAnimStateData?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __StateMachine_GetGlobalWeight, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __StateMachine_IsStateRelevant = 0;

		private static uint __StateMachine_GetLocalWeight = 0;

		private static uint __StateMachine_GetGlobalWeight = 0;
	}
}