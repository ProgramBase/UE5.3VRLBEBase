﻿using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_AccumulateTransformMul")]
	public partial class FRigVMFunction_AccumulateTransformMul : FRigVMFunction_AccumulateBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_AccumulateTransformMul");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_AccumulateTransformMul()
		{
		}

		public static bool operator ==(FRigVMFunction_AccumulateTransformMul A, FRigVMFunction_AccumulateTransformMul B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_AccumulateTransformMul A, FRigVMFunction_AccumulateTransformMul B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_AccumulateTransformMul;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FTransform Multiplier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Multiplier, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Multiplier, __InBuffer);
				}
			}
		}

		public FTransform InitialValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InitialValue, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InitialValue, __InBuffer);
				}
			}
		}

		public bool bFlipOrder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bFlipOrder, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bFlipOrder, __InBuffer);
				}
			}
		}

		public bool bIntegrateDeltaTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIntegrateDeltaTime, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIntegrateDeltaTime, __InBuffer);
				}
			}
		}

		public FTransform Result
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Result, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Result, __InBuffer);
				}
			}
		}

		public FTransform AccumulatedValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AccumulatedValue, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AccumulatedValue, __InBuffer);
				}
			}
		}

		public bool bIsInitialized
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsInitialized, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsInitialized, __InBuffer);
				}
			}
		}

		private static uint __Multiplier = 0;

		private static uint __InitialValue = 0;

		private static uint __bFlipOrder = 0;

		private static uint __bIntegrateDeltaTime = 0;

		private static uint __Result = 0;

		private static uint __AccumulatedValue = 0;

		private static uint __bIsInitialized = 0;

	}
}