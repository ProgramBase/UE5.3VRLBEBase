using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_ModifyBoneTransforms")]
	public partial class FRigUnit_ModifyBoneTransforms : FRigUnit_HighlevelBaseMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_ModifyBoneTransforms");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_ModifyBoneTransforms()
		{
		}

		public static bool operator ==(FRigUnit_ModifyBoneTransforms A, FRigUnit_ModifyBoneTransforms B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_ModifyBoneTransforms A, FRigUnit_ModifyBoneTransforms B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_ModifyBoneTransforms;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigUnit_ModifyBoneTransforms_PerBone> BoneToModify
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneToModify, __ReturnBuffer);

					return *(TArray<FRigUnit_ModifyBoneTransforms_PerBone>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneToModify, __InBuffer);
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

		public float WeightMinimum
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WeightMinimum, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WeightMinimum, __InBuffer);
				}
			}
		}

		public float WeightMaximum
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WeightMaximum, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WeightMaximum, __InBuffer);
				}
			}
		}

		public EControlRigModifyBoneMode Mode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Mode, __ReturnBuffer);

					return *(EControlRigModifyBoneMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Mode, __InBuffer);
				}
			}
		}

		public FRigUnit_ModifyBoneTransforms_WorkData WorkData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WorkData, __ReturnBuffer);

					return *(FRigUnit_ModifyBoneTransforms_WorkData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WorkData, __InBuffer);
				}
			}
		}

		private static uint __BoneToModify = 0;

		private static uint __Weight = 0;

		private static uint __WeightMinimum = 0;

		private static uint __WeightMaximum = 0;

		private static uint __Mode = 0;

		private static uint __WorkData = 0;

	}
}