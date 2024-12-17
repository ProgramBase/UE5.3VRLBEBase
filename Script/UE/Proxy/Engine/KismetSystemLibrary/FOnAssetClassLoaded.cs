using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine.KismetSystemLibrary
{
	public class FOnAssetClassLoaded : FDelegate<Action<TSubclassOf<UObject>>>
	{
		public FOnAssetClassLoaded() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnAssetClassLoaded() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(TSubclassOf<UObject> Loaded)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Loaded?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
