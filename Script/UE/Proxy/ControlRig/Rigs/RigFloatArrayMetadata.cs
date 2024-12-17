using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigFloatArrayMetadata")]
	public partial class FRigFloatArrayMetadata : FRigBaseMetadata, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigFloatArrayMetadata");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigFloatArrayMetadata()
		{
		}

		public static bool operator ==(FRigFloatArrayMetadata A, FRigFloatArrayMetadata B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigFloatArrayMetadata A, FRigFloatArrayMetadata B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigFloatArrayMetadata;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<float> Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
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