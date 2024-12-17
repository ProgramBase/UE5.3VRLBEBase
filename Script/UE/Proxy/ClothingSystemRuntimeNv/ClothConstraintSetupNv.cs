using Script.CoreUObject;
using Script.Library;

namespace Script.ClothingSystemRuntimeNv
{
	[PathName("/Script/ClothingSystemRuntimeNv.ClothConstraintSetupNv")]
	public partial class FClothConstraintSetupNv : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ClothingSystemRuntimeNv.ClothConstraintSetupNv");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FClothConstraintSetupNv() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FClothConstraintSetupNv() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FClothConstraintSetupNv A, FClothConstraintSetupNv B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FClothConstraintSetupNv A, FClothConstraintSetupNv B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FClothConstraintSetupNv;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Stiffness
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Stiffness, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Stiffness, __InBuffer);
				}
			}
		}

		public float StiffnessMultiplier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StiffnessMultiplier, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StiffnessMultiplier, __InBuffer);
				}
			}
		}

		public float StretchLimit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StretchLimit, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StretchLimit, __InBuffer);
				}
			}
		}

		public float CompressionLimit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CompressionLimit, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CompressionLimit, __InBuffer);
				}
			}
		}

		private static uint __Stiffness = 0;

		private static uint __StiffnessMultiplier = 0;

		private static uint __StretchLimit = 0;

		private static uint __CompressionLimit = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}