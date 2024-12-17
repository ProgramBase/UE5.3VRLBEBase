using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.SequencerCore
{
	public class FSequencerOutlinerSelectionChanged : FMulticastDelegate<Action>
	{
		public FSequencerOutlinerSelectionChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FSequencerOutlinerSelectionChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
