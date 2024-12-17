using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowserClassDataSource
{
	[PathName("/Script/ContentBrowserClassDataSource.ContentBrowserCompiledClassDataFilter")]
	public partial class FContentBrowserCompiledClassDataFilter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ContentBrowserClassDataSource.ContentBrowserCompiledClassDataFilter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FContentBrowserCompiledClassDataFilter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FContentBrowserCompiledClassDataFilter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FContentBrowserCompiledClassDataFilter A, FContentBrowserCompiledClassDataFilter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FContentBrowserCompiledClassDataFilter A, FContentBrowserCompiledClassDataFilter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FContentBrowserCompiledClassDataFilter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSet<TSubclassOf<UObject>> ValidClasses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ValidClasses, __ReturnBuffer);

					return *(TSet<TSubclassOf<UObject>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ValidClasses, __InBuffer);
				}
			}
		}

		public TSet<FName> ValidFolders
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ValidFolders, __ReturnBuffer);

					return *(TSet<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ValidFolders, __InBuffer);
				}
			}
		}

		private static uint __ValidClasses = 0;

		private static uint __ValidFolders = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}