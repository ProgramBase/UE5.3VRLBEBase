using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Paper2D
{
	public class FFlipbookFinishedPlaySignature : FMulticastDelegate<Action>
	{
		public FFlipbookFinishedPlaySignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FFlipbookFinishedPlaySignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
