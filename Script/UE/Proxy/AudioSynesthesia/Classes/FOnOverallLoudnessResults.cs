using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.AudioSynesthesia
{
	public class FOnOverallLoudnessResults : FMulticastDelegate<Action<TArray<FLoudnessResults>>>
	{
		public FOnOverallLoudnessResults() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnOverallLoudnessResults() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(TArray<FLoudnessResults> OverallLoudnessResults)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OverallLoudnessResults?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
