using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FAnimDataModelModifiedDynamicEvent : FMulticastDelegate<Action<EAnimDataModelNotifyType, TScriptInterface<IAnimationDataModel>, FAnimDataModelNotifPayload>>
	{
		public FAnimDataModelModifiedDynamicEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FAnimDataModelModifiedDynamicEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(EAnimDataModelNotifyType NotifType, TScriptInterface<IAnimationDataModel> Model, FAnimDataModelNotifPayload Payload)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(byte*)(__InBuffer) = (byte)NotifType;

				*(nint*)(__InBuffer + 1) = Model?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 9) = Payload?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
