using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigTransformMetadata")]
	public partial class FRigTransformMetadata : FRigBaseMetadata, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigTransformMetadata");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigTransformMetadata()
		{
		}

		public static bool operator ==(FRigTransformMetadata A, FRigTransformMetadata B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigTransformMetadata A, FRigTransformMetadata B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigTransformMetadata;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FTransform Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
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