using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.ImageWriteQueue
{
	public class FOnImageWriteComplete : FDelegate<Action<bool>>
	{
		public FOnImageWriteComplete() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnImageWriteComplete() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(bool bSuccess)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bSuccess;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
