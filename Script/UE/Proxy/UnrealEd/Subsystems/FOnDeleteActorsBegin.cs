using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	public class FOnDeleteActorsBegin : FMulticastDelegate<Action>
	{
		public FOnDeleteActorsBegin() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnDeleteActorsBegin() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
