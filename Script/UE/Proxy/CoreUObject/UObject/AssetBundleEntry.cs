using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.AssetBundleEntry")]
	public partial class FAssetBundleEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.AssetBundleEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAssetBundleEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAssetBundleEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAssetBundleEntry A, FAssetBundleEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAssetBundleEntry A, FAssetBundleEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAssetBundleEntry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName BundleName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BundleName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BundleName, __InBuffer);
				}
			}
		}

		public TArray<FSoftObjectPath> BundleAssets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BundleAssets, __ReturnBuffer);

					return *(TArray<FSoftObjectPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BundleAssets, __InBuffer);
				}
			}
		}

		public TArray<FTopLevelAssetPath> AssetPaths
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AssetPaths, __ReturnBuffer);

					return *(TArray<FTopLevelAssetPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AssetPaths, __InBuffer);
				}
			}
		}

		private static uint __BundleName = 0;

		private static uint __BundleAssets = 0;

		private static uint __AssetPaths = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}