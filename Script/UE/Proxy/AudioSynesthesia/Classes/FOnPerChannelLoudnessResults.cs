using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.AudioSynesthesia
{
	public class FOnPerChannelLoudnessResults : FMulticastDelegate<Action<int, TArray<FLoudnessResults>>>
	{
		public FOnPerChannelLoudnessResults() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnPerChannelLoudnessResults() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(int ChannelIndex, TArray<FLoudnessResults> LoudnessResults)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = ChannelIndex;

				*(nint*)(__InBuffer + 4) = LoudnessResults?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
