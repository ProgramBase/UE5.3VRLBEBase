using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeEngine
{
	public class FOnImportDoneDynamic : FDelegate<Action<TArray<UObject>>>
	{
		public FOnImportDoneDynamic() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnImportDoneDynamic() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(TArray<UObject> Objects)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Objects?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
