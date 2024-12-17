using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigLinearColorMetadata")]
	public partial class FRigLinearColorMetadata : FRigBaseMetadata, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigLinearColorMetadata");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigLinearColorMetadata()
		{
		}

		public static bool operator ==(FRigLinearColorMetadata A, FRigLinearColorMetadata B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigLinearColorMetadata A, FRigLinearColorMetadata B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigLinearColorMetadata;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FLinearColor Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
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