using Script.CoreUObject;
using Script.Library;

namespace Script.AnimationCore
{
	[PathName("/Script/AnimationCore.AimConstraintDescription")]
	public partial class FAimConstraintDescription : FConstraintDescriptionEx, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimationCore.AimConstraintDescription");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAimConstraintDescription()
		{
		}

		public static bool operator ==(FAimConstraintDescription A, FAimConstraintDescription B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAimConstraintDescription A, FAimConstraintDescription B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAimConstraintDescription;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FAxis LookAt_Axis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LookAt_Axis, __ReturnBuffer);

					return *(FAxis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LookAt_Axis, __InBuffer);
				}
			}
		}

		public FAxis LookUp_Axis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LookUp_Axis, __ReturnBuffer);

					return *(FAxis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LookUp_Axis, __InBuffer);
				}
			}
		}

		public bool bUseLookUp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bUseLookUp, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bUseLookUp, __InBuffer);
				}
			}
		}

		public FVector LookUpTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LookUpTarget, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LookUpTarget, __InBuffer);
				}
			}
		}

		private static uint __LookAt_Axis = 0;

		private static uint __LookUp_Axis = 0;

		private static uint __bUseLookUp = 0;

		private static uint __LookUpTarget = 0;

	}
}