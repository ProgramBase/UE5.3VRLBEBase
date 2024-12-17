using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FConstraintBrokenSignature : FMulticastDelegate<Action<int>>
	{
		public FConstraintBrokenSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FConstraintBrokenSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(int ConstraintIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = ConstraintIndex;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
