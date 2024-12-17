using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AudioMixer
{
	public class FOnSoundLoadComplete : FDelegate<Action<USoundWave, bool>>
	{
		public FOnSoundLoadComplete() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnSoundLoadComplete() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(USoundWave LoadedSoundWave, bool WasCancelled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = LoadedSoundWave?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = WasCancelled;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
