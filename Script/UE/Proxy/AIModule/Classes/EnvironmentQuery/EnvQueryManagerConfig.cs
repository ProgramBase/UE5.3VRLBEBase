using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryManagerConfig")]
	public partial class FEnvQueryManagerConfig : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.EnvQueryManagerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEnvQueryManagerConfig() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEnvQueryManagerConfig() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEnvQueryManagerConfig A, FEnvQueryManagerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEnvQueryManagerConfig A, FEnvQueryManagerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEnvQueryManagerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float MaxAllowedTestingTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxAllowedTestingTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxAllowedTestingTime, __InBuffer);
				}
			}
		}

		public bool bTestQueriesUsingBreadth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bTestQueriesUsingBreadth, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bTestQueriesUsingBreadth, __InBuffer);
				}
			}
		}

		public int QueryCountWarningThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __QueryCountWarningThreshold, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __QueryCountWarningThreshold, __InBuffer);
				}
			}
		}

		public double QueryCountWarningInterval
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __QueryCountWarningInterval, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __QueryCountWarningInterval, __InBuffer);
				}
			}
		}

		public double ExecutionTimeWarningSeconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExecutionTimeWarningSeconds, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExecutionTimeWarningSeconds, __InBuffer);
				}
			}
		}

		public double HandlingResultTimeWarningSeconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HandlingResultTimeWarningSeconds, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HandlingResultTimeWarningSeconds, __InBuffer);
				}
			}
		}

		public double GenerationTimeWarningSeconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GenerationTimeWarningSeconds, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GenerationTimeWarningSeconds, __InBuffer);
				}
			}
		}

		private static uint __MaxAllowedTestingTime = 0;

		private static uint __bTestQueriesUsingBreadth = 0;

		private static uint __QueryCountWarningThreshold = 0;

		private static uint __QueryCountWarningInterval = 0;

		private static uint __ExecutionTimeWarningSeconds = 0;

		private static uint __HandlingResultTimeWarningSeconds = 0;

		private static uint __GenerationTimeWarningSeconds = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}