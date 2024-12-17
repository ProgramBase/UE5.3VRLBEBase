using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Blutility
{
	public class FOnExportImageAsyncComplete : FMulticastDelegate<Action<bool>>
	{
		public FOnExportImageAsyncComplete() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnExportImageAsyncComplete() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

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
