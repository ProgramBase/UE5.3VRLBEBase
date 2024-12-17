using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_AddParent")]
	public partial class FRigUnit_AddParent : FRigUnit_DynamicHierarchyBaseMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_AddParent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_AddParent()
		{
		}

		public static bool operator ==(FRigUnit_AddParent A, FRigUnit_AddParent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_AddParent A, FRigUnit_AddParent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_AddParent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigElementKey Child
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Child, __ReturnBuffer);

					return *(FRigElementKey*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Child, __InBuffer);
				}
			}
		}

		public FRigElementKey Parent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Parent, __ReturnBuffer);

					return *(FRigElementKey*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Parent, __InBuffer);
				}
			}
		}

		private static uint __Child = 0;

		private static uint __Parent = 0;

	}
}