using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_SetIntAnimationChannel")]
	public partial class FRigUnit_SetIntAnimationChannel : FRigUnit_SetAnimationChannelBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_SetIntAnimationChannel");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_SetIntAnimationChannel()
		{
		}

		public static bool operator ==(FRigUnit_SetIntAnimationChannel A, FRigUnit_SetIntAnimationChannel B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_SetIntAnimationChannel A, FRigUnit_SetIntAnimationChannel B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_SetIntAnimationChannel;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

	}
}