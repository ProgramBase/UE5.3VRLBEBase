using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	public class FOAISimpleDelegate : FMulticastDelegate<Action<EPathFollowingResult>>
	{
		public FOAISimpleDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOAISimpleDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(EPathFollowingResult MovementResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)MovementResult;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
