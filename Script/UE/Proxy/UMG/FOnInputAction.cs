using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnInputAction : FDelegate<Action>
	{
		public FOnInputAction() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnInputAction() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute()
		{
			unsafe
			{
				FDelegateImplementation.FDelegate_GenericExecute0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
