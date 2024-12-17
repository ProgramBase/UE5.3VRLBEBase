using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnUserClickedBanner : FDelegate<Action>
	{
		public FOnUserClickedBanner() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnUserClickedBanner() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute()
		{
			unsafe
			{
				FDelegateImplementation.FDelegate_GenericExecute0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
