using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_FindItemsWithMetadataTagArray")]
	public partial class FRigUnit_FindItemsWithMetadataTagArray : FRigUnit, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_FindItemsWithMetadataTagArray");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_FindItemsWithMetadataTagArray()
		{
		}

		public static bool operator ==(FRigUnit_FindItemsWithMetadataTagArray A, FRigUnit_FindItemsWithMetadataTagArray B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_FindItemsWithMetadataTagArray A, FRigUnit_FindItemsWithMetadataTagArray B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_FindItemsWithMetadataTagArray;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FName> Tags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Tags, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Tags, __InBuffer);
				}
			}
		}

		public TArray<FRigElementKey> Items
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Items, __ReturnBuffer);

					return *(TArray<FRigElementKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Items, __InBuffer);
				}
			}
		}

		private static uint __Tags = 0;

		private static uint __Items = 0;

	}
}