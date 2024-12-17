using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.AudioSynesthesia
{
	public class FOnSpectrumResults : FMulticastDelegate<Action<int, TArray<FSynesthesiaSpectrumResults>>>
	{
		public FOnSpectrumResults() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnSpectrumResults() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(int ChannelIndex, TArray<FSynesthesiaSpectrumResults> SpectrumResults)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = ChannelIndex;

				*(nint*)(__InBuffer + 4) = SpectrumResults?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
