using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine.KismetSystemLibrary
{
	public class FOnAssetLoaded : FDelegate<Action<UObject>>
	{
		public FOnAssetLoaded() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnAssetLoaded() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(UObject Loaded)
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
