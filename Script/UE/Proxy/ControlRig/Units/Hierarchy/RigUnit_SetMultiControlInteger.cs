using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_SetMultiControlInteger")]
	public partial class FRigUnit_SetMultiControlInteger : FRigUnitMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_SetMultiControlInteger");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_SetMultiControlInteger()
		{
		}

		public static bool operator ==(FRigUnit_SetMultiControlInteger A, FRigUnit_SetMultiControlInteger B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_SetMultiControlInteger A, FRigUnit_SetMultiControlInteger B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_SetMultiControlInteger;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigUnit_SetMultiControlInteger_Entry> Entries
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Entries, __ReturnBuffer);

					return *(TArray<FRigUnit_SetMultiControlInteger_Entry>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Entries, __InBuffer);
				}
			}
		}

		public float Weight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Weight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Weight, __InBuffer);
				}
			}
		}

		public TArray<FCachedRigElement> CachedControlIndices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CachedControlIndices, __ReturnBuffer);

					return *(TArray<FCachedRigElement>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CachedControlIndices, __InBuffer);
				}
			}
		}

		private static uint __Entries = 0;

		private static uint __Weight = 0;

		private static uint __CachedControlIndices = 0;

	}
}