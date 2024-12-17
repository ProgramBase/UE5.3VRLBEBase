using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.MobilePatchingUtils
{
	public class FOnContentInstallSucceeded : FDelegate<Action>
	{
		public FOnContentInstallSucceeded() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnContentInstallSucceeded() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute()
		{
			unsafe
			{
				FDelegateImplementation.FDelegate_GenericExecute0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
