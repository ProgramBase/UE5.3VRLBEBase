using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	public class FOnControllerCaptureBeginEventSynth2D : FMulticastDelegate<Action>
	{
		public FOnControllerCaptureBeginEventSynth2D() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnControllerCaptureBeginEventSynth2D() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
