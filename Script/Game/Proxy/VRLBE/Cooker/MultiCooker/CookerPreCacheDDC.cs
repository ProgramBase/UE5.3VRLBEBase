using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherCore
{
	[PathName("/Script/HotPatcherCore.CookerPreCacheDDC")]
	public partial class FCookerPreCacheDDC : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherCore.CookerPreCacheDDC");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCookerPreCacheDDC() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCookerPreCacheDDC() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCookerPreCacheDDC A, FCookerPreCacheDDC B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCookerPreCacheDDC A, FCookerPreCacheDDC B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCookerPreCacheDDC;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<UPackage> Packages
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Packages, __ReturnBuffer);

					return *(TArray<UPackage>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Packages, __InBuffer);
				}
			}
		}

		public TSet<UObject> ProcessedObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ProcessedObjects, __ReturnBuffer);

					return *(TSet<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ProcessedObjects, __InBuffer);
				}
			}
		}

		public TSet<UObject> PendingCachePlatformDataObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PendingCachePlatformDataObjects, __ReturnBuffer);

					return *(TSet<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PendingCachePlatformDataObjects, __InBuffer);
				}
			}
		}

		private static uint __Packages = 0;

		private static uint __ProcessedObjects = 0;

		private static uint __PendingCachePlatformDataObjects = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}