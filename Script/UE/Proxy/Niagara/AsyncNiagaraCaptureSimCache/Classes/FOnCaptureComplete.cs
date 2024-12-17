using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara.AsyncNiagaraCaptureSimCache
{
	public class FOnCaptureComplete : FMulticastDelegate<Action<bool>>
	{
		public FOnCaptureComplete() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnCaptureComplete() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(bool bSuccess)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bSuccess;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
