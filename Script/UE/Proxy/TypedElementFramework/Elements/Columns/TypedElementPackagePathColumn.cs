using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementPackagePathColumn")]
	public partial class FTypedElementPackagePathColumn : FTypedElementDataStorageColumn, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementPackagePathColumn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementPackagePathColumn()
		{
		}

		public static bool operator ==(FTypedElementPackagePathColumn A, FTypedElementPackagePathColumn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementPackagePathColumn A, FTypedElementPackagePathColumn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementPackagePathColumn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Path
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Path, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Path, __InBuffer);
				}
			}
		}

		private static uint __Path = 0;

	}
}