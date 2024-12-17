using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowserFileDataSource
{
	[PathName("/Script/ContentBrowserFileDataSource.ContentBrowserCompiledFileDataFilter")]
	public partial class FContentBrowserCompiledFileDataFilter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ContentBrowserFileDataSource.ContentBrowserCompiledFileDataFilter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FContentBrowserCompiledFileDataFilter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FContentBrowserCompiledFileDataFilter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FContentBrowserCompiledFileDataFilter A, FContentBrowserCompiledFileDataFilter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FContentBrowserCompiledFileDataFilter A, FContentBrowserCompiledFileDataFilter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FContentBrowserCompiledFileDataFilter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}