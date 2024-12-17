using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	public class FOnControllerCaptureEndEventSynth2D : FMulticastDelegate<Action>
	{
		public FOnControllerCaptureEndEventSynth2D() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnControllerCaptureEndEventSynth2D() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
