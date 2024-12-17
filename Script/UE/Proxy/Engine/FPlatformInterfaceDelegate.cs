using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Engine
{
	public class FPlatformInterfaceDelegate : FDelegate<Action<FPlatformInterfaceDelegateResult>>
	{
		public FPlatformInterfaceDelegate() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FPlatformInterfaceDelegate() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(FPlatformInterfaceDelegateResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Result?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
