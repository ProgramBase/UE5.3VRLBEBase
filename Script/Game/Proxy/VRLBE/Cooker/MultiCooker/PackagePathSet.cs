using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherCore
{
	[PathName("/Script/HotPatcherCore.PackagePathSet")]
	public partial class FPackagePathSet : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherCore.PackagePathSet");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPackagePathSet() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPackagePathSet() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPackagePathSet A, FPackagePathSet B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPackagePathSet A, FPackagePathSet B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPackagePathSet;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSet<FName> PackagePaths
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PackagePaths, __ReturnBuffer);

					return *(TSet<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PackagePaths, __InBuffer);
				}
			}
		}

		private static uint __PackagePaths = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}