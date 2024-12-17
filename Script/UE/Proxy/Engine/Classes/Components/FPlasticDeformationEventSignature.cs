using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FPlasticDeformationEventSignature : FMulticastDelegate<Action<int>>
	{
		public FPlasticDeformationEventSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FPlasticDeformationEventSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

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
