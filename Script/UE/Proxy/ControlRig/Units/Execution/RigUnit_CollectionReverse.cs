using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_CollectionReverse")]
	public partial class FRigUnit_CollectionReverse : FRigUnit_CollectionBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_CollectionReverse");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_CollectionReverse()
		{
		}

		public static bool operator ==(FRigUnit_CollectionReverse A, FRigUnit_CollectionReverse B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_CollectionReverse A, FRigUnit_CollectionReverse B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_CollectionReverse;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

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

		public FRigElementKeyCollection Reversed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Reversed, __ReturnBuffer);

					return *(FRigElementKeyCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Reversed, __InBuffer);
				}
			}
		}

		private static uint __Collection = 0;

		private static uint __Reversed = 0;

	}
}