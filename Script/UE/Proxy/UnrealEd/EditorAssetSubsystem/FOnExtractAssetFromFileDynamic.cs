using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd.EditorAssetSubsystem
{
	public class FOnExtractAssetFromFileDynamic : FRefDelegate
	{
		public FOnExtractAssetFromFileDynamic() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnExtractAssetFromFileDynamic() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Bind(UObject InObject, Delegate InDelegate) => FDelegateImplementation.FDelegate_BindImplementation(GarbageCollectionHandle, InObject.GarbageCollectionHandle, InDelegate);

		public void Execute(TArray<FString> Files, ref TArray<FAssetData> AssetDataArray)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Files?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetDataArray?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FDelegateImplementation.FDelegate_GenericExecute6Implementation(GarbageCollectionHandle, __InBuffer, __OutBuffer);

				AssetDataArray = *(TArray<FAssetData>*)(__OutBuffer);

			}
		}

		public delegate void Delegate(TArray<FString> Files, ref TArray<FAssetData> AssetDataArray);
	}
}
