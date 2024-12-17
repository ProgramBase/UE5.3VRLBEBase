using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.AudioSynesthesia
{
	public class FOnLatestPerChannelLoudnessResults : FMulticastDelegate<Action<int, FLoudnessResults>>
	{
		public FOnLatestPerChannelLoudnessResults() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnLatestPerChannelLoudnessResults() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(int ChannelIndex, FLoudnessResults LatestLoudnessResults)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = ChannelIndex;

				*(nint*)(__InBuffer + 4) = LatestLoudnessResults?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
