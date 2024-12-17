using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowserData
{
	[PathName("/Script/ContentBrowserData.ContentBrowserCompiledVirtualFolderFilter")]
	public partial class FContentBrowserCompiledVirtualFolderFilter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ContentBrowserData.ContentBrowserCompiledVirtualFolderFilter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FContentBrowserCompiledVirtualFolderFilter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FContentBrowserCompiledVirtualFolderFilter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FContentBrowserCompiledVirtualFolderFilter A, FContentBrowserCompiledVirtualFolderFilter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FContentBrowserCompiledVirtualFolderFilter A, FContentBrowserCompiledVirtualFolderFilter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FContentBrowserCompiledVirtualFolderFilter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}