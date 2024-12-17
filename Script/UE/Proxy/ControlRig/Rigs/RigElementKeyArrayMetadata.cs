using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigElementKeyArrayMetadata")]
	public partial class FRigElementKeyArrayMetadata : FRigBaseMetadata, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigElementKeyArrayMetadata");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigElementKeyArrayMetadata()
		{
		}

		public static bool operator ==(FRigElementKeyArrayMetadata A, FRigElementKeyArrayMetadata B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigElementKeyArrayMetadata A, FRigElementKeyArrayMetadata B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigElementKeyArrayMetadata;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigElementKey> Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(TArray<FRigElementKey>*)__ReturnBuffer;
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