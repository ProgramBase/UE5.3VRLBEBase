using Script.CoreUObject;
using Script.Library;
using Script.FieldNotification;

namespace Script.Engine
{
	[PathName("/Script/Engine.FieldNotificationLibrary")]
	public partial class UFieldNotificationLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.FieldNotificationLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool SetPropertyValueAndBroadcastFields(bool NewValueByRef, int OldValue, int NewValue, UObject Object, UObject NetOwner, bool bHasLocalRepNotify, bool bShouldFlushDormancyOnSet, bool bIsNetProperty, TArray<FFieldNotificationId> ExtraFieldIds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(bool*)(__InBuffer) = NewValueByRef;

				*(int*)(__InBuffer + 1) = OldValue;

				*(int*)(__InBuffer + 5) = NewValue;

				*(nint*)(__InBuffer + 9) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = NetOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 25) = bHasLocalRepNotify;

				*(bool*)(__InBuffer + 26) = bShouldFlushDormancyOnSet;

				*(bool*)(__InBuffer + 27) = bIsNetProperty;

				*(nint*)(__InBuffer + 28) = ExtraFieldIds?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetPropertyValueAndBroadcastFields, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool SetPropertyValueAndBroadcast(bool NewValueByRef, int OldValue, int NewValue, UObject Object, UObject NetOwner, bool bHasLocalRepNotify, bool bShouldFlushDormancyOnSet, bool bIsNetProperty)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(bool*)(__InBuffer) = NewValueByRef;

				*(int*)(__InBuffer + 1) = OldValue;

				*(int*)(__InBuffer + 5) = NewValue;

				*(nint*)(__InBuffer + 9) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = NetOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 25) = bHasLocalRepNotify;

				*(bool*)(__InBuffer + 26) = bShouldFlushDormancyOnSet;

				*(bool*)(__InBuffer + 27) = bIsNetProperty;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetPropertyValueAndBroadcast, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void BroadcastFieldValueChanged(UObject Object, FFieldNotificationId FieldId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FieldId?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __BroadcastFieldValueChanged, __InBuffer);
			}
		}

		public static void BroadcastFieldsValueChanged(UObject Object, TArray<FFieldNotificationId> FieldIds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FieldIds?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __BroadcastFieldsValueChanged, __InBuffer);
			}
		}

		private static uint __SetPropertyValueAndBroadcastFields = 0;

		private static uint __SetPropertyValueAndBroadcast = 0;

		private static uint __BroadcastFieldValueChanged = 0;

		private static uint __BroadcastFieldsValueChanged = 0;
	}
}