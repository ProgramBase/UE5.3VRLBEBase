using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigLinearColorArrayMetadata")]
	public partial class FRigLinearColorArrayMetadata : FRigBaseMetadata, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigLinearColorArrayMetadata");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigLinearColorArrayMetadata()
		{
		}

		public static bool operator ==(FRigLinearColorArrayMetadata A, FRigLinearColorArrayMetadata B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigLinearColorArrayMetadata A, FRigLinearColorArrayMetadata B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigLinearColorArrayMetadata;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FLinearColor> Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(TArray<FLinearColor>*)__ReturnBuffer;
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