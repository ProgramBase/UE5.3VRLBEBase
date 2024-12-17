using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.AudioMixer
{
	public class FOnMainAudioOutputDeviceObtained : FDelegate<Action<FString>>
	{
		public FOnMainAudioOutputDeviceObtained() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnMainAudioOutputDeviceObtained() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(FString CurrentDevice)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = CurrentDevice?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
