using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigInt32ArrayMetadata")]
	public partial class FRigInt32ArrayMetadata : FRigBaseMetadata, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigInt32ArrayMetadata");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigInt32ArrayMetadata()
		{
		}

		public static bool operator ==(FRigInt32ArrayMetadata A, FRigInt32ArrayMetadata B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigInt32ArrayMetadata A, FRigInt32ArrayMetadata B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigInt32ArrayMetadata;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<int> Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
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