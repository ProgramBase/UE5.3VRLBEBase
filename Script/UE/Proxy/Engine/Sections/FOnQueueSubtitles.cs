using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Engine
{
	public class FOnQueueSubtitles : FDelegate<Action<TArray<FSubtitleCue>, float>>
	{
		public FOnQueueSubtitles() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnQueueSubtitles() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(TArray<FSubtitleCue> Subtitles, float CueDuration)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Subtitles?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = CueDuration;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
