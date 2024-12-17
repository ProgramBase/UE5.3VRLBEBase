using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnSubmixEnvelopeBP : FDelegate<Action<TArray<float>>>
	{
		public FOnSubmixEnvelopeBP() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnSubmixEnvelopeBP() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(TArray<float> Envelope)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Envelope?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
