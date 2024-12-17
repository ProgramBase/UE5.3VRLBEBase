using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FWidgetAnimationDynamicEvent : FDelegate<Action>
	{
		public FWidgetAnimationDynamicEvent() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FWidgetAnimationDynamicEvent() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute()
		{
			unsafe
			{
				FDelegateImplementation.FDelegate_GenericExecute0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
