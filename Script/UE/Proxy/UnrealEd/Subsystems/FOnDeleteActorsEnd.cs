using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	public class FOnDeleteActorsEnd : FMulticastDelegate<Action>
	{
		public FOnDeleteActorsEnd() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnDeleteActorsEnd() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
