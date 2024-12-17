using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnSubmixSpectralAnalysisBP : FDelegate<Action<TArray<float>>>
	{
		public FOnSubmixSpectralAnalysisBP() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnSubmixSpectralAnalysisBP() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(TArray<float> Magnitude)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Magnitude?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
