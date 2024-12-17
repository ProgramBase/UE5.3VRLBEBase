using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowserData
{
	[PathName("/Script/ContentBrowserData.ContentBrowserDataCollectionFilter")]
	public partial class FContentBrowserDataCollectionFilter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ContentBrowserData.ContentBrowserDataCollectionFilter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FContentBrowserDataCollectionFilter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FContentBrowserDataCollectionFilter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FContentBrowserDataCollectionFilter A, FContentBrowserDataCollectionFilter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FContentBrowserDataCollectionFilter A, FContentBrowserDataCollectionFilter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FContentBrowserDataCollectionFilter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bIncludeChildCollections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIncludeChildCollections, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIncludeChildCollections, __InBuffer);
				}
			}
		}

		private static uint __bIncludeChildCollections = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}