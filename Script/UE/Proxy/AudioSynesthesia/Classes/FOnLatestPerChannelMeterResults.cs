using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.AudioSynesthesia
{
	public class FOnLatestPerChannelMeterResults : FMulticastDelegate<Action<int, FMeterResults>>
	{
		public FOnLatestPerChannelMeterResults() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnLatestPerChannelMeterResults() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(int ChannelIndex, FMeterResults LatestMeterResults)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = ChannelIndex;

				*(nint*)(__InBuffer + 4) = LatestMeterResults?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
