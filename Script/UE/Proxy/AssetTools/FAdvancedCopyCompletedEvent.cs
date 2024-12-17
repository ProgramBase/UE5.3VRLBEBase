using System;
using Script.CoreUObject;
using Script.Library;
using Script.AssetTools;

namespace Script.AssetTools
{
	public class FAdvancedCopyCompletedEvent : FDelegate<Action<bool, TArray<FAssetRenameData>>>
	{
		public FAdvancedCopyCompletedEvent() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FAdvancedCopyCompletedEvent() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(bool bSuccess, TArray<FAssetRenameData> AllCopiedAssets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(bool*)(__InBuffer) = bSuccess;

				*(nint*)(__InBuffer + 1) = AllCopiedAssets?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
