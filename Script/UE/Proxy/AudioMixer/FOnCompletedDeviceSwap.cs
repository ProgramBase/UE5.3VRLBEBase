using System;
using Script.CoreUObject;
using Script.Library;
using Script.AudioMixer;

namespace Script.AudioMixer
{
	public class FOnCompletedDeviceSwap : FDelegate<Action<FSwapAudioOutputResult>>
	{
		public FOnCompletedDeviceSwap() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnCompletedDeviceSwap() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(FSwapAudioOutputResult SwapResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SwapResult?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
