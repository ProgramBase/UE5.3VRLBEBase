using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnUserClosedAdvertisement : FDelegate<Action>
	{
		public FOnUserClosedAdvertisement() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnUserClosedAdvertisement() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute()
		{
			unsafe
			{
				FDelegateImplementation.FDelegate_GenericExecute0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
