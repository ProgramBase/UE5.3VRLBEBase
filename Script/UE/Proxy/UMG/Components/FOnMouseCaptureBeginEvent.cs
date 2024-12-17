using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnMouseCaptureBeginEvent : FMulticastDelegate<Action>
	{
		public FOnMouseCaptureBeginEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnMouseCaptureBeginEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
