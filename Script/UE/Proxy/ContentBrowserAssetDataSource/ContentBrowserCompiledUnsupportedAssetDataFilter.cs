using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowserAssetDataSource
{
	[PathName("/Script/ContentBrowserAssetDataSource.ContentBrowserCompiledUnsupportedAssetDataFilter")]
	public partial class FContentBrowserCompiledUnsupportedAssetDataFilter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ContentBrowserAssetDataSource.ContentBrowserCompiledUnsupportedAssetDataFilter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FContentBrowserCompiledUnsupportedAssetDataFilter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FContentBrowserCompiledUnsupportedAssetDataFilter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FContentBrowserCompiledUnsupportedAssetDataFilter A, FContentBrowserCompiledUnsupportedAssetDataFilter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FContentBrowserCompiledUnsupportedAssetDataFilter A, FContentBrowserCompiledUnsupportedAssetDataFilter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FContentBrowserCompiledUnsupportedAssetDataFilter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}