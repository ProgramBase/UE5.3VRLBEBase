using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG.WidgetBlueprintLibrary
{
	public class FOnGameWindowCloseButtonClickedDelegate : FDelegate<Action>
	{
		public FOnGameWindowCloseButtonClickedDelegate() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnGameWindowCloseButtonClickedDelegate() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute()
		{
			unsafe
			{
				FDelegateImplementation.FDelegate_GenericExecute0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
