using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Engine
{
	public class FOnQuartzMetronomeEventBP : FDelegate<Action<FName, EQuartzCommandQuantization, int, int, float>>
	{
		public FOnQuartzMetronomeEventBP() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnQuartzMetronomeEventBP() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(FName ClockName, EQuartzCommandQuantization QuantizationType, int NumBars, int Beat, float BeatFraction)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = ClockName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)QuantizationType;

				*(int*)(__InBuffer + 9) = NumBars;

				*(int*)(__InBuffer + 13) = Beat;

				*(float*)(__InBuffer + 17) = BeatFraction;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
