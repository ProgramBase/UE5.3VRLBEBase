using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimationDataModelNotifiesExtensions")]
	public partial class UAnimationDataModelNotifiesExtensions : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimationDataModelNotifiesExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FEmptyPayload GetPayload(FAnimDataModelNotifPayload Payload)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Payload?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPayload, __InBuffer, __ReturnBuffer);

				return *(FEmptyPayload*)__ReturnBuffer;
			}
		}

		public static void CopyPayload(FAnimDataModelNotifPayload Payload, UScriptStruct ExpectedStruct, ref FEmptyPayload OutPayload)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Payload?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ExpectedStruct?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutPayload?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __CopyPayload, __InBuffer, __OutBuffer);

				OutPayload = *(FEmptyPayload*)(__OutBuffer);

			}
		}

		private static uint __GetPayload = 0;

		private static uint __CopyPayload = 0;
	}
}