using Script.CoreUObject;
using Script.Library;

namespace Script.PBIK
{
	[PathName("/Script/PBIK.PBIKWorkData")]
	public partial class FPBIKWorkData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/PBIK.PBIKWorkData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPBIKWorkData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPBIKWorkData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPBIKWorkData A, FPBIKWorkData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPBIKWorkData A, FPBIKWorkData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPBIKWorkData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bNeedsInit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bNeedsInit, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bNeedsInit, __InBuffer);
				}
			}
		}

		public uint HashInitializedWith
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HashInitializedWith, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HashInitializedWith, __InBuffer);
				}
			}
		}

		public TArray<int> BoneSettingToSolverBoneIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneSettingToSolverBoneIndex, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneSettingToSolverBoneIndex, __InBuffer);
				}
			}
		}

		public TArray<int> SolverBoneToElementIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SolverBoneToElementIndex, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SolverBoneToElementIndex, __InBuffer);
				}
			}
		}

		public FPBIKSolver Solver
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Solver, __ReturnBuffer);

					return *(FPBIKSolver*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Solver, __InBuffer);
				}
			}
		}

		private static uint __bNeedsInit = 0;

		private static uint __HashInitializedWith = 0;

		private static uint __BoneSettingToSolverBoneIndex = 0;

		private static uint __SolverBoneToElementIndex = 0;

		private static uint __Solver = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}