using Script.CoreUObject;
using Script.Library;
using Script.RigVM;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_DistributeRotationForItemArray")]
	public partial class FRigUnit_DistributeRotationForItemArray : FRigUnit_HighlevelBaseMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_DistributeRotationForItemArray");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_DistributeRotationForItemArray()
		{
		}

		public static bool operator ==(FRigUnit_DistributeRotationForItemArray A, FRigUnit_DistributeRotationForItemArray B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_DistributeRotationForItemArray A, FRigUnit_DistributeRotationForItemArray B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_DistributeRotationForItemArray;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigElementKey> Items
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Items, __ReturnBuffer);

					return *(TArray<FRigElementKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Items, __InBuffer);
				}
			}
		}

		public TArray<FRigUnit_DistributeRotation_Rotation> Rotations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Rotations, __ReturnBuffer);

					return *(TArray<FRigUnit_DistributeRotation_Rotation>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Rotations, __InBuffer);
				}
			}
		}

		public ERigVMAnimEasingType RotationEaseType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RotationEaseType, __ReturnBuffer);

					return *(ERigVMAnimEasingType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RotationEaseType, __InBuffer);
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

		public FRigUnit_DistributeRotation_WorkData WorkData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WorkData, __ReturnBuffer);

					return *(FRigUnit_DistributeRotation_WorkData*)__ReturnBuffer;
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

		private static uint __Items = 0;

		private static uint __Rotations = 0;

		private static uint __RotationEaseType = 0;

		private static uint __Weight = 0;

		private static uint __WorkData = 0;

	}
}