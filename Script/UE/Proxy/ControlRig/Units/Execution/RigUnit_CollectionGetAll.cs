using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_CollectionGetAll")]
	public partial class FRigUnit_CollectionGetAll : FRigUnit_CollectionBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_CollectionGetAll");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_CollectionGetAll()
		{
		}

		public static bool operator ==(FRigUnit_CollectionGetAll A, FRigUnit_CollectionGetAll B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_CollectionGetAll A, FRigUnit_CollectionGetAll B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_CollectionGetAll;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ERigElementType TypeToSearch
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TypeToSearch, __ReturnBuffer);

					return *(ERigElementType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TypeToSearch, __InBuffer);
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

		private static uint __TypeToSearch = 0;

		private static uint __Items = 0;

	}
}