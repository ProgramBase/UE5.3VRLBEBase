using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	public class FOnSamplePlaybackProgress : FMulticastDelegate<Action<float, float>>
	{
		public FOnSamplePlaybackProgress() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnSamplePlaybackProgress() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(float ProgressPercent, float ProgressTimeSeconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = ProgressPercent;

				*(float*)(__InBuffer + 4) = ProgressTimeSeconds;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
