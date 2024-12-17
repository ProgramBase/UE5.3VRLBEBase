using System;
using Script.CoreUObject;
using Script.Library;
using Script.FieldNotification;

namespace Script.FieldNotification
{
	public class FFieldValueChangedDynamicDelegate : FDelegate<Action<UObject, FFieldNotificationId>>
	{
		public FFieldValueChangedDynamicDelegate() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FFieldValueChangedDynamicDelegate() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(UObject Object, FFieldNotificationId Field)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Field?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
