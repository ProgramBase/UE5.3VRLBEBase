using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_HierarchyAddAnimationChannelVector")]
	public partial class FRigUnit_HierarchyAddAnimationChannelVector : FRigUnit_HierarchyAddElement, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_HierarchyAddAnimationChannelVector");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_HierarchyAddAnimationChannelVector()
		{
		}

		public static bool operator ==(FRigUnit_HierarchyAddAnimationChannelVector A, FRigUnit_HierarchyAddAnimationChannelVector B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_HierarchyAddAnimationChannelVector A, FRigUnit_HierarchyAddAnimationChannelVector B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_HierarchyAddAnimationChannelVector;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector InitialValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InitialValue, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InitialValue, __InBuffer);
				}
			}
		}

		public FVector MinimumValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinimumValue, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinimumValue, __InBuffer);
				}
			}
		}

		public FVector MaximumValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaximumValue, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaximumValue, __InBuffer);
				}
			}
		}

		private static uint __InitialValue = 0;

		private static uint __MinimumValue = 0;

		private static uint __MaximumValue = 0;

	}
}