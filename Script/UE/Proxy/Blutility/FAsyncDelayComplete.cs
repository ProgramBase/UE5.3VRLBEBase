using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Blutility
{
	public class FAsyncDelayComplete : FMulticastDelegate<Action>
	{
		public FAsyncDelayComplete() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FAsyncDelayComplete() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
