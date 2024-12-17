using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	public class FOnMouseCaptureBeginEventSynth2D : FMulticastDelegate<Action>
	{
		public FOnMouseCaptureBeginEventSynth2D() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnMouseCaptureBeginEventSynth2D() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
