using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_HierarchyRemoveElement")]
	public partial class FRigUnit_HierarchyRemoveElement : FRigUnit_DynamicHierarchyBaseMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_HierarchyRemoveElement");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_HierarchyRemoveElement()
		{
		}

		public static bool operator ==(FRigUnit_HierarchyRemoveElement A, FRigUnit_HierarchyRemoveElement B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_HierarchyRemoveElement A, FRigUnit_HierarchyRemoveElement B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_HierarchyRemoveElement;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigElementKey Item
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Item, __ReturnBuffer);

					return *(FRigElementKey*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Item, __InBuffer);
				}
			}
		}

		public bool bSuccess
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSuccess, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSuccess, __InBuffer);
				}
			}
		}

		private static uint __Item = 0;

		private static uint __bSuccess = 0;

	}
}