using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	public class FAIMoveCompletedSignature : FMulticastDelegate<Action<FAIRequestID, EPathFollowingResult>>
	{
		public FAIMoveCompletedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FAIMoveCompletedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FAIRequestID RequestID, EPathFollowingResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = RequestID?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
