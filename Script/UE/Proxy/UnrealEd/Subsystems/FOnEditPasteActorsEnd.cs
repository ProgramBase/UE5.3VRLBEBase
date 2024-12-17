using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	public class FOnEditPasteActorsEnd : FMulticastDelegate<Action>
	{
		public FOnEditPasteActorsEnd() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnEditPasteActorsEnd() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
