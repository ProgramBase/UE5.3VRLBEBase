using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEdMessages
{
	[PathName("/Script/UnrealEdMessages.AssetEditorRequestOpenAsset")]
	public partial class FAssetEditorRequestOpenAsset : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEdMessages.AssetEditorRequestOpenAsset");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAssetEditorRequestOpenAsset() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAssetEditorRequestOpenAsset() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAssetEditorRequestOpenAsset A, FAssetEditorRequestOpenAsset B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAssetEditorRequestOpenAsset A, FAssetEditorRequestOpenAsset B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAssetEditorRequestOpenAsset;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString AssetName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AssetName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AssetName, __InBuffer);
				}
			}
		}

		private static uint __AssetName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}