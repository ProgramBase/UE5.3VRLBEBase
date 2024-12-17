using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowserData
{
	[PathName("/Script/ContentBrowserData.ContentBrowserDataFilter")]
	public partial class FContentBrowserDataFilter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ContentBrowserData.ContentBrowserDataFilter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FContentBrowserDataFilter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FContentBrowserDataFilter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FContentBrowserDataFilter A, FContentBrowserDataFilter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FContentBrowserDataFilter A, FContentBrowserDataFilter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FContentBrowserDataFilter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bRecursivePaths
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bRecursivePaths, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bRecursivePaths, __InBuffer);
				}
			}
		}

		public EContentBrowserItemTypeFilter ItemTypeFilter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ItemTypeFilter, __ReturnBuffer);

					return *(EContentBrowserItemTypeFilter*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ItemTypeFilter, __InBuffer);
				}
			}
		}

		public EContentBrowserItemCategoryFilter ItemCategoryFilter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ItemCategoryFilter, __ReturnBuffer);

					return *(EContentBrowserItemCategoryFilter*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ItemCategoryFilter, __InBuffer);
				}
			}
		}

		public EContentBrowserItemAttributeFilter ItemAttributeFilter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ItemAttributeFilter, __ReturnBuffer);

					return *(EContentBrowserItemAttributeFilter*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ItemAttributeFilter, __InBuffer);
				}
			}
		}

		private static uint __bRecursivePaths = 0;

		private static uint __ItemTypeFilter = 0;

		private static uint __ItemCategoryFilter = 0;

		private static uint __ItemAttributeFilter = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}