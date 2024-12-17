using Script.CoreUObject;
using Script.Library;
using Script.RigVM;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_EndProfilingTimer")]
	public partial class FRigUnit_EndProfilingTimer : FRigVMFunction_DebugBaseMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_EndProfilingTimer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_EndProfilingTimer()
		{
		}

		public static bool operator ==(FRigUnit_EndProfilingTimer A, FRigUnit_EndProfilingTimer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_EndProfilingTimer A, FRigUnit_EndProfilingTimer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_EndProfilingTimer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int NumberOfMeasurements
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumberOfMeasurements, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumberOfMeasurements, __InBuffer);
				}
			}
		}

		public FString Prefix
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Prefix, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Prefix, __InBuffer);
				}
			}
		}

		public float AccumulatedTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AccumulatedTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AccumulatedTime, __InBuffer);
				}
			}
		}

		public int MeasurementsLeft
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MeasurementsLeft, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MeasurementsLeft, __InBuffer);
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

		private static uint __NumberOfMeasurements = 0;

		private static uint __Prefix = 0;

		private static uint __AccumulatedTime = 0;

		private static uint __MeasurementsLeft = 0;

		private static uint __bIsInitialized = 0;

	}
}