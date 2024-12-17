using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_GetVector2DAnimationChannel")]
	public partial class FRigUnit_GetVector2DAnimationChannel : FRigUnit_GetAnimationChannelBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_GetVector2DAnimationChannel");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_GetVector2DAnimationChannel()
		{
		}

		public static bool operator ==(FRigUnit_GetVector2DAnimationChannel A, FRigUnit_GetVector2DAnimationChannel B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_GetVector2DAnimationChannel A, FRigUnit_GetVector2DAnimationChannel B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_GetVector2DAnimationChannel;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector2D Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
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