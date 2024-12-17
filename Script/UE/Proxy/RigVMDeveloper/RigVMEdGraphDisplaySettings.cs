using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMEdGraphDisplaySettings")]
	public partial class FRigVMEdGraphDisplaySettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMEdGraphDisplaySettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMEdGraphDisplaySettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMEdGraphDisplaySettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMEdGraphDisplaySettings A, FRigVMEdGraphDisplaySettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMEdGraphDisplaySettings A, FRigVMEdGraphDisplaySettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMEdGraphDisplaySettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bShowNodeInstructionIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShowNodeInstructionIndex, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShowNodeInstructionIndex, __InBuffer);
				}
			}
		}

		public bool bShowNodeRunCounts
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShowNodeRunCounts, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShowNodeRunCounts, __InBuffer);
				}
			}
		}

		public int NodeRunLowerBound
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NodeRunLowerBound, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NodeRunLowerBound, __InBuffer);
				}
			}
		}

		public int NodeRunLimit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NodeRunLimit, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NodeRunLimit, __InBuffer);
				}
			}
		}

		public double MinMicroSeconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinMicroSeconds, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinMicroSeconds, __InBuffer);
				}
			}
		}

		public double MaxMicroSeconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxMicroSeconds, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxMicroSeconds, __InBuffer);
				}
			}
		}

		public double TotalMicroSeconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TotalMicroSeconds, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TotalMicroSeconds, __InBuffer);
				}
			}
		}

		public bool bAutoDetermineRange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAutoDetermineRange, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAutoDetermineRange, __InBuffer);
				}
			}
		}

		public double LastMinMicroSeconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LastMinMicroSeconds, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LastMinMicroSeconds, __InBuffer);
				}
			}
		}

		public double LastMaxMicroSeconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LastMaxMicroSeconds, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LastMaxMicroSeconds, __InBuffer);
				}
			}
		}

		public FLinearColor MinDurationColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinDurationColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinDurationColor, __InBuffer);
				}
			}
		}

		public FLinearColor MaxDurationColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxDurationColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxDurationColor, __InBuffer);
				}
			}
		}

		private static uint __bShowNodeInstructionIndex = 0;

		private static uint __bShowNodeRunCounts = 0;

		private static uint __NodeRunLowerBound = 0;

		private static uint __NodeRunLimit = 0;

		private static uint __MinMicroSeconds = 0;

		private static uint __MaxMicroSeconds = 0;

		private static uint __TotalMicroSeconds = 0;

		private static uint __bAutoDetermineRange = 0;

		private static uint __LastMinMicroSeconds = 0;

		private static uint __LastMaxMicroSeconds = 0;

		private static uint __MinDurationColor = 0;

		private static uint __MaxDurationColor = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}