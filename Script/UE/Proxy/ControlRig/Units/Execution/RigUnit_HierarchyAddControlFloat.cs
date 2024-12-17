using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_HierarchyAddControlFloat")]
	public partial class FRigUnit_HierarchyAddControlFloat : FRigUnit_HierarchyAddControlElement, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_HierarchyAddControlFloat");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_HierarchyAddControlFloat()
		{
		}

		public static bool operator ==(FRigUnit_HierarchyAddControlFloat A, FRigUnit_HierarchyAddControlFloat B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_HierarchyAddControlFloat A, FRigUnit_HierarchyAddControlFloat B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_HierarchyAddControlFloat;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float InitialValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InitialValue, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InitialValue, __InBuffer);
				}
			}
		}

		public FRigUnit_HierarchyAddControlFloat_Settings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(FRigUnit_HierarchyAddControlFloat_Settings*)__ReturnBuffer;
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

		private static uint __InitialValue = 0;

		private static uint __Settings = 0;

	}
}