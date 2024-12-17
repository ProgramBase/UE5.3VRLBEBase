using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	public class FOnMouseCaptureEndEventSynth2D : FMulticastDelegate<Action>
	{
		public FOnMouseCaptureEndEventSynth2D() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnMouseCaptureEndEventSynth2D() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
