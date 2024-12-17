using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryManager")]
	public partial class UEnvQueryManager : UAISubsystem, IStaticClass
	{
		public TArray<FEnvQueryInstanceCache> InstanceCache
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceCache, __ReturnBuffer);

					return *(TArray<FEnvQueryInstanceCache>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceCache, __InBuffer);
				}
			}
		}

		public TArray<UEnvQueryContext> LocalContexts
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LocalContexts, __ReturnBuffer);

					return *(TArray<UEnvQueryContext>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LocalContexts, __InBuffer);
				}
			}
		}

		public TArray<UEnvQueryInstanceBlueprintWrapper> GCShieldedWrappers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GCShieldedWrappers, __ReturnBuffer);

					return *(TArray<UEnvQueryInstanceBlueprintWrapper>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GCShieldedWrappers, __InBuffer);
				}
			}
		}

		public float MaxAllowedTestingTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxAllowedTestingTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxAllowedTestingTime, __InBuffer);
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

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bTestQueriesUsingBreadth, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bTestQueriesUsingBreadth, __InBuffer);
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

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __QueryCountWarningThreshold, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __QueryCountWarningThreshold, __InBuffer);
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

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __QueryCountWarningInterval, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __QueryCountWarningInterval, __InBuffer);
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

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExecutionTimeWarningSeconds, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExecutionTimeWarningSeconds, __InBuffer);
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

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HandlingResultTimeWarningSeconds, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HandlingResultTimeWarningSeconds, __InBuffer);
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

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GenerationTimeWarningSeconds, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GenerationTimeWarningSeconds, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UEnvQueryInstanceBlueprintWrapper RunEQSQuery(UObject WorldContextObject, UEnvQuery QueryTemplate, UObject Querier, EEnvQueryRunMode RunMode, TSubclassOf<UEnvQueryInstanceBlueprintWrapper> WrapperClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = QueryTemplate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Querier?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)RunMode;

				*(nint*)(__InBuffer + 25) = WrapperClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RunEQSQuery, __InBuffer, __ReturnBuffer);

				return *(UEnvQueryInstanceBlueprintWrapper*)__ReturnBuffer;
			}
		}

		private static uint __InstanceCache = 0;

		private static uint __LocalContexts = 0;

		private static uint __GCShieldedWrappers = 0;

		private static uint __MaxAllowedTestingTime = 0;

		private static uint __bTestQueriesUsingBreadth = 0;

		private static uint __QueryCountWarningThreshold = 0;

		private static uint __QueryCountWarningInterval = 0;

		private static uint __ExecutionTimeWarningSeconds = 0;

		private static uint __HandlingResultTimeWarningSeconds = 0;

		private static uint __GenerationTimeWarningSeconds = 0;

		private static uint __RunEQSQuery = 0;
	}
}