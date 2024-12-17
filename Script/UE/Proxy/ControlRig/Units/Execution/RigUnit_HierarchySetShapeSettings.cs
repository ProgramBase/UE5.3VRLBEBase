using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_HierarchySetShapeSettings")]
	public partial class FRigUnit_HierarchySetShapeSettings : FRigUnit_DynamicHierarchyBaseMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_HierarchySetShapeSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_HierarchySetShapeSettings()
		{
		}

		public static bool operator ==(FRigUnit_HierarchySetShapeSettings A, FRigUnit_HierarchySetShapeSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_HierarchySetShapeSettings A, FRigUnit_HierarchySetShapeSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_HierarchySetShapeSettings;

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

		public FRigUnit_HierarchyAddControl_ShapeSettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(FRigUnit_HierarchyAddControl_ShapeSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Settings, __InBuffer);
				}
			}
		}

		private static uint __Item = 0;

		private static uint __Settings = 0;

	}
}