using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	public class FOnEditPasteActorsBegin : FMulticastDelegate<Action>
	{
		public FOnEditPasteActorsBegin() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnEditPasteActorsBegin() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
