using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeEngine
{
	public class FOnObjectImportDoneDynamic : FDelegate<Action<UObject>>
	{
		public FOnObjectImportDoneDynamic() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnObjectImportDoneDynamic() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
