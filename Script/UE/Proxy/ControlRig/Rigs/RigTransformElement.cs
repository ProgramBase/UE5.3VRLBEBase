using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigTransformElement")]
	public partial class FRigTransformElement : FRigBaseElement, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigTransformElement");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigTransformElement()
		{
		}

		public static bool operator ==(FRigTransformElement A, FRigTransformElement B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigTransformElement A, FRigTransformElement B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigTransformElement;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigCurrentAndInitialTransform Pose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Pose, __ReturnBuffer);

					return *(FRigCurrentAndInitialTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Pose, __InBuffer);
				}
			}
		}

		private static uint __Pose = 0;

	}
}