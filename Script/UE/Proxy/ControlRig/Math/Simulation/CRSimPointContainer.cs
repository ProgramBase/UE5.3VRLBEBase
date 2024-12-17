using Script.CoreUObject;
using Script.Library;
using Script.RigVM;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.CRSimPointContainer")]
	public partial class FCRSimPointContainer : FCRSimContainer, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.CRSimPointContainer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCRSimPointContainer()
		{
		}

		public static bool operator ==(FCRSimPointContainer A, FCRSimPointContainer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCRSimPointContainer A, FCRSimPointContainer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCRSimPointContainer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigVMSimPoint> Points
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Points, __ReturnBuffer);

					return *(TArray<FRigVMSimPoint>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Points, __InBuffer);
				}
			}
		}

		public TArray<FCRSimLinearSpring> Springs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Springs, __ReturnBuffer);

					return *(TArray<FCRSimLinearSpring>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Springs, __InBuffer);
				}
			}
		}

		public TArray<FCRSimPointForce> Forces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Forces, __ReturnBuffer);

					return *(TArray<FCRSimPointForce>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Forces, __InBuffer);
				}
			}
		}

		public TArray<FCRSimSoftCollision> CollisionVolumes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CollisionVolumes, __ReturnBuffer);

					return *(TArray<FCRSimSoftCollision>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CollisionVolumes, __InBuffer);
				}
			}
		}

		public TArray<FCRSimPointConstraint> Constraints
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Constraints, __ReturnBuffer);

					return *(TArray<FCRSimPointConstraint>*)__ReturnBuffer;
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

		public TArray<FRigVMSimPoint> PreviousStep
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PreviousStep, __ReturnBuffer);

					return *(TArray<FRigVMSimPoint>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PreviousStep, __InBuffer);
				}
			}
		}

		private static uint __Points = 0;

		private static uint __Springs = 0;

		private static uint __Forces = 0;

		private static uint __CollisionVolumes = 0;

		private static uint __Constraints = 0;

		private static uint __PreviousStep = 0;

	}
}