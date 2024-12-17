using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.AudioSynesthesia
{
	public class FOnLatestOverallLoudnessResults : FMulticastDelegate<Action<FLoudnessResults>>
	{
		public FOnLatestOverallLoudnessResults() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnLatestOverallLoudnessResults() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FLoudnessResults LatestOverallLoudnessResults)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LatestOverallLoudnessResults?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
