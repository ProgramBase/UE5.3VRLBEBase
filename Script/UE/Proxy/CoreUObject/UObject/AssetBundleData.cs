using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.AssetBundleData")]
	public partial class FAssetBundleData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.AssetBundleData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAssetBundleData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAssetBundleData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAssetBundleData A, FAssetBundleData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAssetBundleData A, FAssetBundleData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAssetBundleData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FAssetBundleEntry> Bundles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Bundles, __ReturnBuffer);

					return *(TArray<FAssetBundleEntry>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Bundles, __InBuffer);
				}
			}
		}

		private static uint __Bundles = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}