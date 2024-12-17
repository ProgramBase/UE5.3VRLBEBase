using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_HierarchySetParentWeights")]
	public partial class FRigUnit_HierarchySetParentWeights : FRigUnit_DynamicHierarchyBaseMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_HierarchySetParentWeights");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_HierarchySetParentWeights()
		{
		}

		public static bool operator ==(FRigUnit_HierarchySetParentWeights A, FRigUnit_HierarchySetParentWeights B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_HierarchySetParentWeights A, FRigUnit_HierarchySetParentWeights B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_HierarchySetParentWeights;

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

		public TArray<FRigElementWeight> Weights
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Weights, __ReturnBuffer);

					return *(TArray<FRigElementWeight>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Weights, __InBuffer);
				}
			}
		}

		private static uint __Child = 0;

		private static uint __Weights = 0;

	}
}