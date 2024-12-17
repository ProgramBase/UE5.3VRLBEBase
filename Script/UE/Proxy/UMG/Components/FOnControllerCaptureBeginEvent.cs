using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnControllerCaptureBeginEvent : FMulticastDelegate<Action>
	{
		public FOnControllerCaptureBeginEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnControllerCaptureBeginEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
