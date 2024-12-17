using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnControllerCaptureEndEvent : FMulticastDelegate<Action>
	{
		public FOnControllerCaptureEndEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnControllerCaptureEndEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
