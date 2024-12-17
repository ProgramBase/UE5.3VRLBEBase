using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_SetFloatAnimationChannel")]
	public partial class FRigUnit_SetFloatAnimationChannel : FRigUnit_SetAnimationChannelBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_SetFloatAnimationChannel");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_SetFloatAnimationChannel()
		{
		}

		public static bool operator ==(FRigUnit_SetFloatAnimationChannel A, FRigUnit_SetFloatAnimationChannel B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_SetFloatAnimationChannel A, FRigUnit_SetFloatAnimationChannel B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_SetFloatAnimationChannel;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

	}
}