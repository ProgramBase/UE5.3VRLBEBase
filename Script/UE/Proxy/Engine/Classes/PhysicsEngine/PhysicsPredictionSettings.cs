using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PhysicsPredictionSettings")]
	public partial class FPhysicsPredictionSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PhysicsPredictionSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPhysicsPredictionSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPhysicsPredictionSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPhysicsPredictionSettings A, FPhysicsPredictionSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPhysicsPredictionSettings A, FPhysicsPredictionSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPhysicsPredictionSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bEnablePhysicsPrediction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEnablePhysicsPrediction, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEnablePhysicsPrediction, __InBuffer);
				}
			}
		}

		public bool bEnablePhysicsResimulation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEnablePhysicsResimulation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEnablePhysicsResimulation, __InBuffer);
				}
			}
		}

		public float ResimulationErrorThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ResimulationErrorThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ResimulationErrorThreshold, __InBuffer);
				}
			}
		}

		public float MaxSupportedLatencyPrediction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxSupportedLatencyPrediction, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxSupportedLatencyPrediction, __InBuffer);
				}
			}
		}

		private static uint __bEnablePhysicsPrediction = 0;

		private static uint __bEnablePhysicsResimulation = 0;

		private static uint __ResimulationErrorThreshold = 0;

		private static uint __MaxSupportedLatencyPrediction = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}