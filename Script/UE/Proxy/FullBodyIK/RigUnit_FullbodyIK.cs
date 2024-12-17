using Script.CoreUObject;
using Script.Library;
using Script.ControlRig;

namespace Script.FullBodyIK
{
	[PathName("/Script/FullBodyIK.RigUnit_FullbodyIK")]
	public partial class FRigUnit_FullbodyIK : FRigUnit_HighlevelBaseMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/FullBodyIK.RigUnit_FullbodyIK");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_FullbodyIK()
		{
		}

		public static bool operator ==(FRigUnit_FullbodyIK A, FRigUnit_FullbodyIK B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_FullbodyIK A, FRigUnit_FullbodyIK B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_FullbodyIK;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigElementKey Root
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Root, __ReturnBuffer);

					return *(FRigElementKey*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Root, __InBuffer);
				}
			}
		}

		public TArray<FFBIKEndEffector> Effectors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Effectors, __ReturnBuffer);

					return *(TArray<FFBIKEndEffector>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Effectors, __InBuffer);
				}
			}
		}

		public TArray<FFBIKConstraintOption> Constraints
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Constraints, __ReturnBuffer);

					return *(TArray<FFBIKConstraintOption>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Constraints, __InBuffer);
				}
			}
		}

		public FSolverInput SolverProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SolverProperty, __ReturnBuffer);

					return *(FSolverInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SolverProperty, __InBuffer);
				}
			}
		}

		public FMotionProcessInput MotionProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MotionProperty, __ReturnBuffer);

					return *(FMotionProcessInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MotionProperty, __InBuffer);
				}
			}
		}

		public bool bPropagateToChildren
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bPropagateToChildren, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bPropagateToChildren, __InBuffer);
				}
			}
		}

		public FFBIKDebugOption DebugOption
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DebugOption, __ReturnBuffer);

					return *(FFBIKDebugOption*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DebugOption, __InBuffer);
				}
			}
		}

		public FRigUnit_FullbodyIK_WorkData WorkData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WorkData, __ReturnBuffer);

					return *(FRigUnit_FullbodyIK_WorkData*)__ReturnBuffer;
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

		private static uint __Root = 0;

		private static uint __Effectors = 0;

		private static uint __Constraints = 0;

		private static uint __SolverProperty = 0;

		private static uint __MotionProperty = 0;

		private static uint __bPropagateToChildren = 0;

		private static uint __DebugOption = 0;

		private static uint __WorkData = 0;

	}
}