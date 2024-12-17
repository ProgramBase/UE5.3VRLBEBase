using Script.CoreUObject;
using Script.Library;

namespace Script.AssetDefinition
{
	[PathName("/Script/AssetDefinition.AssetFilterData")]
	public partial class FAssetFilterData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AssetDefinition.AssetFilterData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAssetFilterData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAssetFilterData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAssetFilterData A, FAssetFilterData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAssetFilterData A, FAssetFilterData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAssetFilterData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}