using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_CollectionNameSearch")]
	public partial class FRigUnit_CollectionNameSearch : FRigUnit_CollectionBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_CollectionNameSearch");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_CollectionNameSearch()
		{
		}

		public static bool operator ==(FRigUnit_CollectionNameSearch A, FRigUnit_CollectionNameSearch B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_CollectionNameSearch A, FRigUnit_CollectionNameSearch B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_CollectionNameSearch;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName PartialName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PartialName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PartialName, __InBuffer);
				}
			}
		}

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

		public FRigElementKeyCollection Collection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Collection, __ReturnBuffer);

					return *(FRigElementKeyCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Collection, __InBuffer);
				}
			}
		}

		private static uint __PartialName = 0;

		private static uint __TypeToSearch = 0;

		private static uint __Collection = 0;

	}
}