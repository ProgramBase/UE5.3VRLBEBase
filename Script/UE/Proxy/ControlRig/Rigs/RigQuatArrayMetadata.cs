using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigQuatArrayMetadata")]
	public partial class FRigQuatArrayMetadata : FRigBaseMetadata, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigQuatArrayMetadata");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigQuatArrayMetadata()
		{
		}

		public static bool operator ==(FRigQuatArrayMetadata A, FRigQuatArrayMetadata B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigQuatArrayMetadata A, FRigQuatArrayMetadata B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigQuatArrayMetadata;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FQuat> Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(TArray<FQuat>*)__ReturnBuffer;
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