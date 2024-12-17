using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	public class FOnEditCutActorsEnd : FMulticastDelegate<Action>
	{
		public FOnEditCutActorsEnd() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnEditCutActorsEnd() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
