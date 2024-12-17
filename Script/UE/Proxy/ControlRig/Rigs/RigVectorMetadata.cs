using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigVectorMetadata")]
	public partial class FRigVectorMetadata : FRigBaseMetadata, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigVectorMetadata");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVectorMetadata()
		{
		}

		public static bool operator ==(FRigVectorMetadata A, FRigVectorMetadata B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVectorMetadata A, FRigVectorMetadata B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVectorMetadata;

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