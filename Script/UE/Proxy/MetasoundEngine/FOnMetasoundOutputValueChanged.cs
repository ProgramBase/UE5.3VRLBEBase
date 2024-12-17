using System;
using Script.CoreUObject;
using Script.Library;
using Script.MetasoundEngine;

namespace Script.MetasoundEngine
{
	public class FOnMetasoundOutputValueChanged : FDelegate<Action<FName, FMetaSoundOutput>>
	{
		public FOnMetasoundOutputValueChanged() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnMetasoundOutputValueChanged() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(FName OutputName, FMetaSoundOutput Output)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OutputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Output?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
