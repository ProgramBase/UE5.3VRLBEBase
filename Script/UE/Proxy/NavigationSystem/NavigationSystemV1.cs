using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavigationSystemV1")]
	public partial class UNavigationSystemV1 : UNavigationSystemBase, IStaticClass
	{
		public ANavigationData MainNavData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MainNavData, __ReturnBuffer);

					return *(ANavigationData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MainNavData, __InBuffer);
				}
			}
		}

		public ANavigationData AbstractNavData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AbstractNavData, __ReturnBuffer);

					return *(ANavigationData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AbstractNavData, __InBuffer);
				}
			}
		}

		public FName DefaultAgentName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultAgentName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultAgentName, __InBuffer);
				}
			}
		}

		public TSoftClassPtr<UCrowdManagerBase> CrowdManagerClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CrowdManagerClass, __ReturnBuffer);

					return *(TSoftClassPtr<UCrowdManagerBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CrowdManagerClass, __InBuffer);
				}
			}
		}

		public bool bAutoCreateNavigationData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoCreateNavigationData, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoCreateNavigationData, __InBuffer);
				}
			}
		}

		public bool bSpawnNavDataInNavBoundsLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSpawnNavDataInNavBoundsLevel, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSpawnNavDataInNavBoundsLevel, __InBuffer);
				}
			}
		}

		public bool bAllowClientSideNavigation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowClientSideNavigation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowClientSideNavigation, __InBuffer);
				}
			}
		}

		public bool bShouldDiscardSubLevelNavData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldDiscardSubLevelNavData, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldDiscardSubLevelNavData, __InBuffer);
				}
			}
		}

		public bool bTickWhilePaused
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bTickWhilePaused, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bTickWhilePaused, __InBuffer);
				}
			}
		}

		public bool bSupportRebuilding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportRebuilding, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportRebuilding, __InBuffer);
				}
			}
		}

		public bool bInitialBuildingLocked
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bInitialBuildingLocked, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bInitialBuildingLocked, __InBuffer);
				}
			}
		}

		public bool bSkipAgentHeightCheckWhenPickingNavData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSkipAgentHeightCheckWhenPickingNavData, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSkipAgentHeightCheckWhenPickingNavData, __InBuffer);
				}
			}
		}

		public int GeometryExportTriangleCountWarningThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GeometryExportTriangleCountWarningThreshold, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GeometryExportTriangleCountWarningThreshold, __InBuffer);
				}
			}
		}

		public bool bGenerateNavigationOnlyAroundNavigationInvokers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bGenerateNavigationOnlyAroundNavigationInvokers, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bGenerateNavigationOnlyAroundNavigationInvokers, __InBuffer);
				}
			}
		}

		public float ActiveTilesUpdateInterval
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveTilesUpdateInterval, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveTilesUpdateInterval, __InBuffer);
				}
			}
		}

		public ENavDataGatheringModeConfig DataGatheringMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataGatheringMode, __ReturnBuffer);

					return *(ENavDataGatheringModeConfig*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataGatheringMode, __InBuffer);
				}
			}
		}

		public float DirtyAreaWarningSizeThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DirtyAreaWarningSizeThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DirtyAreaWarningSizeThreshold, __InBuffer);
				}
			}
		}

		public float GatheringNavModifiersWarningLimitTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GatheringNavModifiersWarningLimitTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GatheringNavModifiersWarningLimitTime, __InBuffer);
				}
			}
		}

		public TArray<FNavDataConfig> SupportedAgents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SupportedAgents, __ReturnBuffer);

					return *(TArray<FNavDataConfig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SupportedAgents, __InBuffer);
				}
			}
		}

		public FNavAgentSelector SupportedAgentsMask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SupportedAgentsMask, __ReturnBuffer);

					return *(FNavAgentSelector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SupportedAgentsMask, __InBuffer);
				}
			}
		}

		public FBox BuildBounds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BuildBounds, __ReturnBuffer);

					return *(FBox*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BuildBounds, __InBuffer);
				}
			}
		}

		public TArray<ANavigationData> NavDataSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NavDataSet, __ReturnBuffer);

					return *(TArray<ANavigationData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NavDataSet, __InBuffer);
				}
			}
		}

		public TArray<ANavigationData> NavDataRegistrationQueue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NavDataRegistrationQueue, __ReturnBuffer);

					return *(TArray<ANavigationData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NavDataRegistrationQueue, __InBuffer);
				}
			}
		}

		public FOnNavDataGenericEvent OnNavDataRegisteredEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnNavDataRegisteredEvent, __ReturnBuffer);

					return *(FOnNavDataGenericEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnNavDataRegisteredEvent, __InBuffer);
				}
			}
		}

		public FOnNavDataGenericEvent OnNavigationGenerationFinishedDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnNavigationGenerationFinishedDelegate, __ReturnBuffer);

					return *(FOnNavDataGenericEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnNavigationGenerationFinishedDelegate, __InBuffer);
				}
			}
		}

		public FNavigationSystemRunMode OperationMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OperationMode, __ReturnBuffer);

					return *(FNavigationSystemRunMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OperationMode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.NavigationSystemV1");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <see>
		/// RegisterNavigationInvoker for more details */
		/// </see>
		public virtual void UnregisterNavigationInvoker(AActor Invoker)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Invoker?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnregisterNavigationInvoker, __InBuffer);
			}
		}

		/// <param name="MaxNumberOfJobs">
		/// gets trimmed to be at least 1. You cannot use this function to pause navmesh generation */
		/// </param>
		public virtual void SetMaxSimultaneousTileGenerationJobsCount(int MaxNumberOfJobs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = MaxNumberOfJobs;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMaxSimultaneousTileGenerationJobsCount, __InBuffer);
			}
		}

		public virtual void SetGeometryGatheringMode(ENavDataGatheringModeConfig NewMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGeometryGatheringMode, __InBuffer);
			}
		}

		public virtual void ResetMaxSimultaneousTileGenerationJobsCount()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetMaxSimultaneousTileGenerationJobsCount);
			}
		}

		/// <note>
		/// : you need NavigationSystem's GenerateNavigationOnlyAroundNavigationInvokers to be set to true
		/// to take advantage of this feature
		/// </note>
		public virtual void RegisterNavigationInvoker(AActor Invoker, float TileGenerationRadius = 3000.000000f, float TileRemovalRadius = 5000.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Invoker?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = TileGenerationRadius;

				*(float*)(__InBuffer + 12) = TileRemovalRadius;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RegisterNavigationInvoker, __InBuffer);
			}
		}

		/// <todo>
		/// document
		/// </todo>
		public virtual void OnNavigationBoundsUpdated(ANavMeshBoundsVolume NavVolume)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NavVolume?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnNavigationBoundsUpdated, __InBuffer);
			}
		}

		/// <param name="Querier">
		/// if not passed default navigation data will be used
		/// </param>
		/// <param name="HitLocation">
		/// if line was obstructed this will be set to hit location. Otherwise it contains SegmentEnd
		/// </param>
		/// <returns>
		/// true if line from RayStart to RayEnd was obstructed. Also, true when no navigation data present */
		/// </returns>
		public static bool NavigationRaycast(UObject WorldContextObject, FVector RayStart, FVector RayEnd, ref FVector HitLocation, TSubclassOf<UNavigationQueryFilter> FilterClass, AController Querier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[48];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RayStart?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = RayEnd?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = HitLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = FilterClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = Querier?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __NavigationRaycast, __InBuffer, __OutBuffer, __ReturnBuffer);

				HitLocation = *(FVector*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool K2_ReplaceAreaInOctreeData(UObject Object, TSubclassOf<UNavArea> OldArea, TSubclassOf<UNavArea> NewArea)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OldArea?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewArea?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __K2_ReplaceAreaInOctreeData, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool K2_ProjectPointToNavigation(UObject WorldContextObject, FVector Point, ref FVector ProjectedLocation, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass, FVector QueryExtent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[48];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Point?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ProjectedLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = NavData?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = FilterClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = QueryExtent?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __K2_ProjectPointToNavigation, __InBuffer, __OutBuffer, __ReturnBuffer);

				ProjectedLocation = *(FVector*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Return Value represents if the call was successful */
		/// </returns>
		public static bool K2_GetRandomReachablePointInRadius(UObject WorldContextObject, FVector Origin, ref FVector RandomLocation, float Radius, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[44];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = RandomLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Radius;

				*(nint*)(__InBuffer + 28) = NavData?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = FilterClass?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __K2_GetRandomReachablePointInRadius, __InBuffer, __OutBuffer, __ReturnBuffer);

				RandomLocation = *(FVector*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool K2_GetRandomPointInNavigableRadius(UObject WorldContextObject, FVector Origin, ref FVector RandomLocation, float Radius, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[44];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = RandomLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Radius;

				*(nint*)(__InBuffer + 28) = NavData?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = FilterClass?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __K2_GetRandomPointInNavigableRadius, __InBuffer, __OutBuffer, __ReturnBuffer);

				RandomLocation = *(FVector*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Return Value represents if the call was successful */
		/// </returns>
		public static bool K2_GetRandomLocationInNavigableRadius(UObject WorldContextObject, FVector Origin, ref FVector RandomLocation, float Radius, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[44];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = RandomLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Radius;

				*(nint*)(__InBuffer + 28) = NavData?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = FilterClass?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __K2_GetRandomLocationInNavigableRadius, __InBuffer, __OutBuffer, __ReturnBuffer);

				RandomLocation = *(FVector*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsNavigationBeingBuiltOrLocked(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsNavigationBeingBuiltOrLocked, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsNavigationBeingBuilt(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsNavigationBeingBuilt, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static ENavigationQueryResult GetPathLength(UObject WorldContextObject, FVector PathStart, FVector PathEnd, ref double PathLength, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[48];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PathStart?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PathEnd?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 24) = PathLength;

				*(nint*)(__InBuffer + 32) = NavData?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = FilterClass?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetPathLength, __InBuffer, __OutBuffer, __ReturnBuffer);

				PathLength = *(double*)(__OutBuffer);

				return *(ENavigationQueryResult*)__ReturnBuffer;
			}
		}

		public static ENavigationQueryResult GetPathCost(UObject WorldContextObject, FVector PathStart, FVector PathEnd, ref double PathCost, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[48];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PathStart?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PathEnd?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 24) = PathCost;

				*(nint*)(__InBuffer + 32) = NavData?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = FilterClass?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetPathCost, __InBuffer, __OutBuffer, __ReturnBuffer);

				PathCost = *(double*)(__OutBuffer);

				return *(ENavigationQueryResult*)__ReturnBuffer;
			}
		}

		public static UNavigationSystemV1 GetNavigationSystem(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNavigationSystem, __InBuffer, __ReturnBuffer);

				return *(UNavigationSystemV1*)__ReturnBuffer;
			}
		}

		/// <param name="PathfindingContext">
		/// could be one of following: NavigationData (like Navmesh actor), Pawn or Controller. This parameter determines parameters of specific pathfinding query */
		/// </param>
		public static UNavigationPath FindPathToLocationSynchronously(UObject WorldContextObject, FVector PathStart, FVector PathEnd, AActor PathfindingContext = null, TSubclassOf<UNavigationQueryFilter> FilterClass = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PathStart?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PathEnd?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = PathfindingContext?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = FilterClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindPathToLocationSynchronously, __InBuffer, __ReturnBuffer);

				return *(UNavigationPath*)__ReturnBuffer;
			}
		}

		/// <param name="PathfindingContext">
		/// could be one of following: NavigationData (like Navmesh actor), Pawn or Controller. This parameter determines parameters of specific pathfinding query */
		/// </param>
		public static UNavigationPath FindPathToActorSynchronously(UObject WorldContextObject, FVector PathStart, AActor GoalActor, float TetherDistance = 50.000000f, AActor PathfindingContext = null, TSubclassOf<UNavigationQueryFilter> FilterClass = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[44];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PathStart?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = GoalActor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = TetherDistance;

				*(nint*)(__InBuffer + 28) = PathfindingContext?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = FilterClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindPathToActorSynchronously, __InBuffer, __ReturnBuffer);

				return *(UNavigationPath*)__ReturnBuffer;
			}
		}

		private static uint __MainNavData = 0;

		private static uint __AbstractNavData = 0;

		private static uint __DefaultAgentName = 0;

		private static uint __CrowdManagerClass = 0;

		private static uint __bAutoCreateNavigationData = 0;

		private static uint __bSpawnNavDataInNavBoundsLevel = 0;

		private static uint __bAllowClientSideNavigation = 0;

		private static uint __bShouldDiscardSubLevelNavData = 0;

		private static uint __bTickWhilePaused = 0;

		private static uint __bSupportRebuilding = 0;

		private static uint __bInitialBuildingLocked = 0;

		private static uint __bSkipAgentHeightCheckWhenPickingNavData = 0;

		private static uint __GeometryExportTriangleCountWarningThreshold = 0;

		private static uint __bGenerateNavigationOnlyAroundNavigationInvokers = 0;

		private static uint __ActiveTilesUpdateInterval = 0;

		private static uint __DataGatheringMode = 0;

		private static uint __DirtyAreaWarningSizeThreshold = 0;

		private static uint __GatheringNavModifiersWarningLimitTime = 0;

		private static uint __SupportedAgents = 0;

		private static uint __SupportedAgentsMask = 0;

		private static uint __BuildBounds = 0;

		private static uint __NavDataSet = 0;

		private static uint __NavDataRegistrationQueue = 0;

		private static uint __OnNavDataRegisteredEvent = 0;

		private static uint __OnNavigationGenerationFinishedDelegate = 0;

		private static uint __OperationMode = 0;

		private static uint __UnregisterNavigationInvoker = 0;

		private static uint __SetMaxSimultaneousTileGenerationJobsCount = 0;

		private static uint __SetGeometryGatheringMode = 0;

		private static uint __ResetMaxSimultaneousTileGenerationJobsCount = 0;

		private static uint __RegisterNavigationInvoker = 0;

		private static uint __OnNavigationBoundsUpdated = 0;

		private static uint __NavigationRaycast = 0;

		private static uint __K2_ReplaceAreaInOctreeData = 0;

		private static uint __K2_ProjectPointToNavigation = 0;

		private static uint __K2_GetRandomReachablePointInRadius = 0;

		private static uint __K2_GetRandomPointInNavigableRadius = 0;

		private static uint __K2_GetRandomLocationInNavigableRadius = 0;

		private static uint __IsNavigationBeingBuiltOrLocked = 0;

		private static uint __IsNavigationBeingBuilt = 0;

		private static uint __GetPathLength = 0;

		private static uint __GetPathCost = 0;

		private static uint __GetNavigationSystem = 0;

		private static uint __FindPathToLocationSynchronously = 0;

		private static uint __FindPathToActorSynchronously = 0;
	}
}