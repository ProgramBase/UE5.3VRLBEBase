using System;
using Script.CoreUObject;
using Script.Library;
using Script.MetasoundEngine;

namespace Script.MetasoundEngine
{
	public class FOnCreateAuditionGeneratorHandleDelegate : FDelegate<Action<UMetasoundGeneratorHandle>>
	{
		public FOnCreateAuditionGeneratorHandleDelegate() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnCreateAuditionGeneratorHandleDelegate() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(UMetasoundGeneratorHandle GeneratorHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = GeneratorHandle?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
