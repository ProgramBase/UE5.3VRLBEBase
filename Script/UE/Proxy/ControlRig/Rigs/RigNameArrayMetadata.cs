using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigNameArrayMetadata")]
	public partial class FRigNameArrayMetadata : FRigBaseMetadata, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigNameArrayMetadata");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigNameArrayMetadata()
		{
		}

		public static bool operator ==(FRigNameArrayMetadata A, FRigNameArrayMetadata B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigNameArrayMetadata A, FRigNameArrayMetadata B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigNameArrayMetadata;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FName> Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
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