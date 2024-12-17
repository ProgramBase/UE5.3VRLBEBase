using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimMontage")]
	public partial class UAnimMontage : UAnimCompositeBase, IStaticClass
	{
		public EMontageBlendMode BlendModeIn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlendModeIn, __ReturnBuffer);

					return *(EMontageBlendMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlendModeIn, __InBuffer);
				}
			}
		}

		public EMontageBlendMode BlendModeOut
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlendModeOut, __ReturnBuffer);

					return *(EMontageBlendMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlendModeOut, __InBuffer);
				}
			}
		}

		public FAlphaBlend BlendIn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlendIn, __ReturnBuffer);

					return *(FAlphaBlend*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlendIn, __InBuffer);
				}
			}
		}

		public FAlphaBlend BlendOut
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlendOut, __ReturnBuffer);

					return *(FAlphaBlend*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlendOut, __InBuffer);
				}
			}
		}

		public float BlendOutTriggerTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlendOutTriggerTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlendOutTriggerTime, __InBuffer);
				}
			}
		}

		public FName SyncGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SyncGroup, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SyncGroup, __InBuffer);
				}
			}
		}

		public int SyncSlotIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SyncSlotIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SyncSlotIndex, __InBuffer);
				}
			}
		}

		public FMarkerSyncData MarkerData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MarkerData, __ReturnBuffer);

					return *(FMarkerSyncData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MarkerData, __InBuffer);
				}
			}
		}

		public TArray<FCompositeSection> CompositeSections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CompositeSections, __ReturnBuffer);

					return *(TArray<FCompositeSection>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CompositeSections, __InBuffer);
				}
			}
		}

		public TArray<FSlotAnimationTrack> SlotAnimTracks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SlotAnimTracks, __ReturnBuffer);

					return *(TArray<FSlotAnimationTrack>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SlotAnimTracks, __InBuffer);
				}
			}
		}

		public bool bEnableRootMotionTranslation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableRootMotionTranslation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableRootMotionTranslation, __InBuffer);
				}
			}
		}

		public bool bEnableRootMotionRotation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableRootMotionRotation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableRootMotionRotation, __InBuffer);
				}
			}
		}

		public bool bEnableAutoBlendOut
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableAutoBlendOut, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableAutoBlendOut, __InBuffer);
				}
			}
		}

		public UBlendProfile BlendProfileIn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlendProfileIn, __ReturnBuffer);

					return *(UBlendProfile*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlendProfileIn, __InBuffer);
				}
			}
		}

		public UBlendProfile BlendProfileOut
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlendProfileOut, __ReturnBuffer);

					return *(UBlendProfile*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlendProfileOut, __InBuffer);
				}
			}
		}

		public ERootMotionRootLock RootMotionRootLock
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RootMotionRootLock, __ReturnBuffer);

					return *(ERootMotionRootLock*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RootMotionRootLock, __InBuffer);
				}
			}
		}

		public UAnimSequence PreviewBasePose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewBasePose, __ReturnBuffer);

					return *(UAnimSequence*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewBasePose, __InBuffer);
				}
			}
		}

		public TArray<FBranchingPointMarker> BranchingPointMarkers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BranchingPointMarkers, __ReturnBuffer);

					return *(TArray<FBranchingPointMarker>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BranchingPointMarkers, __InBuffer);
				}
			}
		}

		public TArray<int> BranchingPointStateNotifyIndices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BranchingPointStateNotifyIndices, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BranchingPointStateNotifyIndices, __InBuffer);
				}
			}
		}

		public FTimeStretchCurve TimeStretchCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TimeStretchCurve, __ReturnBuffer);

					return *(FTimeStretchCurve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TimeStretchCurve, __InBuffer);
				}
			}
		}

		public FName TimeStretchCurveName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TimeStretchCurveName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TimeStretchCurveName, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimMontage");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <returns>
		/// true if valid section */
		/// </returns>
		public virtual bool IsValidSectionName(FName InSectionName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSectionName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsValidSectionName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsValidAdditiveSlot(FName SlotNodeName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SlotNodeName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsValidAdditiveSlot, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FName GetSectionName(int SectionIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = SectionIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSectionName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual int GetSectionIndex(FName InSectionName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSectionName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetSectionIndex, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumSections()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumSections, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual FName GetGroupName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetGroupName, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual float GetDefaultBlendOutTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDefaultBlendOutTime, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetDefaultBlendInTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDefaultBlendInTime, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FAlphaBlendArgs GetBlendOutArgs()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetBlendOutArgs, __ReturnBuffer);

				return *(FAlphaBlendArgs*)__ReturnBuffer;
			}
		}

		public virtual FAlphaBlendArgs GetBlendInArgs()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetBlendInArgs, __ReturnBuffer);

				return *(FAlphaBlendArgs*)__ReturnBuffer;
			}
		}

		public static UAnimMontage CreateSlotAnimationAsDynamicMontage_WithBlendSettings(UAnimSequenceBase Asset, FName SlotNodeName, FMontageBlendSettings BlendInSettings, FMontageBlendSettings BlendOutSettings, float InPlayRate = 1.000000f, int LoopCount = 1, float InBlendOutTriggerTime = -1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[44];

				*(nint*)(__InBuffer) = Asset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SlotNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BlendInSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = BlendOutSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = InPlayRate;

				*(int*)(__InBuffer + 36) = LoopCount;

				*(float*)(__InBuffer + 40) = InBlendOutTriggerTime;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateSlotAnimationAsDynamicMontage_WithBlendSettings, __InBuffer, __ReturnBuffer);

				return *(UAnimMontage*)__ReturnBuffer;
			}
		}

		private static uint __BlendModeIn = 0;

		private static uint __BlendModeOut = 0;

		private static uint __BlendIn = 0;

		private static uint __BlendOut = 0;

		private static uint __BlendOutTriggerTime = 0;

		private static uint __SyncGroup = 0;

		private static uint __SyncSlotIndex = 0;

		private static uint __MarkerData = 0;

		private static uint __CompositeSections = 0;

		private static uint __SlotAnimTracks = 0;

		private static uint __bEnableRootMotionTranslation = 0;

		private static uint __bEnableRootMotionRotation = 0;

		private static uint __bEnableAutoBlendOut = 0;

		private static uint __BlendProfileIn = 0;

		private static uint __BlendProfileOut = 0;

		private static uint __RootMotionRootLock = 0;

		private static uint __PreviewBasePose = 0;

		private static uint __BranchingPointMarkers = 0;

		private static uint __BranchingPointStateNotifyIndices = 0;

		private static uint __TimeStretchCurve = 0;

		private static uint __TimeStretchCurveName = 0;

		private static uint __IsValidSectionName = 0;

		private static uint __IsValidAdditiveSlot = 0;

		private static uint __GetSectionName = 0;

		private static uint __GetSectionIndex = 0;

		private static uint __GetNumSections = 0;

		private static uint __GetGroupName = 0;

		private static uint __GetDefaultBlendOutTime = 0;

		private static uint __GetDefaultBlendInTime = 0;

		private static uint __GetBlendOutArgs = 0;

		private static uint __GetBlendInArgs = 0;

		private static uint __CreateSlotAnimationAsDynamicMontage_WithBlendSettings = 0;
	}
}