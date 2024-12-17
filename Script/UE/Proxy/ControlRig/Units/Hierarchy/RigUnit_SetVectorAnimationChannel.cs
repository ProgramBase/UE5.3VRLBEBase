using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_SetVectorAnimationChannel")]
	public partial class FRigUnit_SetVectorAnimationChannel : FRigUnit_SetAnimationChannelBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_SetVectorAnimationChannel");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_SetVectorAnimationChannel()
		{
		}

		public static bool operator ==(FRigUnit_SetVectorAnimationChannel A, FRigUnit_SetVectorAnimationChannel B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_SetVectorAnimationChannel A, FRigUnit_SetVectorAnimationChannel B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_SetVectorAnimationChannel;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

	}
}