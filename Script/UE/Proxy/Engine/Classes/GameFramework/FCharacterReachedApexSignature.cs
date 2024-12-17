using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FCharacterReachedApexSignature : FMulticastDelegate<Action>
	{
		public FCharacterReachedApexSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FCharacterReachedApexSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
