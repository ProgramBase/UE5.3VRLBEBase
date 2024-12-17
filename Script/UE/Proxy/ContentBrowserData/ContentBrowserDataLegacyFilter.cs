using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowserData
{
	[PathName("/Script/ContentBrowserData.ContentBrowserDataLegacyFilter")]
	public partial class FContentBrowserDataLegacyFilter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ContentBrowserData.ContentBrowserDataLegacyFilter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FContentBrowserDataLegacyFilter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FContentBrowserDataLegacyFilter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FContentBrowserDataLegacyFilter A, FContentBrowserDataLegacyFilter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FContentBrowserDataLegacyFilter A, FContentBrowserDataLegacyFilter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FContentBrowserDataLegacyFilter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}