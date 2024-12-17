using Script.CoreUObject;
using Script.Library;
using Script.Engine;
using Script.IKRig;

namespace Script.IKRigEditor
{
	[PathName("/Script/IKRigEditor.IKRetargetBatchOperation")]
	public partial class UIKRetargetBatchOperation : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IKRigEditor.IKRetargetBatchOperation");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="AssetsToRetarget">
		/// A list of animation assets to retarget (sequences, blendspaces or montages)
		/// </param>
		/// <param name="SourceMesh">
		/// The skeletal mesh with desired proportions to playback the assets to retarget
		/// </param>
		/// <param name="TargetMesh">
		/// The skeletal mesh to retarget the animation onto.
		/// </param>
		/// <param name="IKRetargetAsset">
		/// The IK Retargeter asset with IK Rigs appropriate for the source and target skeletal mesh
		/// </param>
		/// <param name="Search">
		/// A string to search for in the file name (replaced with "Replace" string)
		/// </param>
		/// <param name="Replace">
		/// A string to replace with in the file name
		/// </param>
		/// <param name="Suffix">
		/// A string to add at the end of the new file name
		/// </param>
		/// <param name="Prefix">
		/// A string to add to the start of the new file name
		/// </param>
		/// <param name="bRemapReferencedAssets">
		/// Whether to remap existing references in the animation assets
		/// Return: list of new animation files created. */
		/// </param>
		public static TArray<FAssetData> DuplicateAndRetarget(TArray<FAssetData> AssetsToRetarget, USkeletalMesh SourceMesh, USkeletalMesh TargetMesh, UIKRetargeter IKRetargetAsset, FString Search = null, FString Replace = null, FString Prefix = null, FString Suffix = null, bool bRemapReferencedAssets = true)
		{
			unsafe
			{
				Search ??= new FString("");

				Replace ??= new FString("");

				Prefix ??= new FString("");

				Suffix ??= new FString("");

				var __InBuffer = stackalloc byte[65];

				*(nint*)(__InBuffer) = AssetsToRetarget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SourceMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = TargetMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = IKRetargetAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Search?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = Replace?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 48) = Prefix?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 56) = Suffix?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 64) = bRemapReferencedAssets;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __DuplicateAndRetarget, __InBuffer, __ReturnBuffer);

				return *(TArray<FAssetData>*)__ReturnBuffer;
			}
		}

		private static uint __DuplicateAndRetarget = 0;
	}
}