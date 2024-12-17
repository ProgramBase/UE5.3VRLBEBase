using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	public class FMoveTaskCompletedSignature : FMulticastDelegate<Action<EPathFollowingResult, AAIController>>
	{
		public FMoveTaskCompletedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FMoveTaskCompletedSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(EPathFollowingResult Result, AAIController AIController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)Result;

				*(nint*)(__InBuffer + 1) = AIController?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
