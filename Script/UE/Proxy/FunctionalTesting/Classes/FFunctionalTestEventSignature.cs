using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.FunctionalTesting
{
	public class FFunctionalTestEventSignature : FMulticastDelegate<Action>
	{
		public FFunctionalTestEventSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FFunctionalTestEventSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
