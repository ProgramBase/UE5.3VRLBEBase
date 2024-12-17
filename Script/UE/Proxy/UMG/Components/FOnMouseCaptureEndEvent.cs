using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnMouseCaptureEndEvent : FMulticastDelegate<Action>
	{
		public FOnMouseCaptureEndEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnMouseCaptureEndEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
