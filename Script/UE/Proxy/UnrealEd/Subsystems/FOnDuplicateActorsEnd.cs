using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	public class FOnDuplicateActorsEnd : FMulticastDelegate<Action>
	{
		public FOnDuplicateActorsEnd() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnDuplicateActorsEnd() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
