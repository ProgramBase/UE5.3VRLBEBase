using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.IKRig
{
	[PathName("/Script/IKRig.IKRetargeter")]
	public partial class UIKRetargeter : UObject, IStaticClass
	{
		public TSoftObjectPtr<UIKRigDefinition> SourceIKRigAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceIKRigAsset, __ReturnBuffer);

					return *(TSoftObjectPtr<UIKRigDefinition>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceIKRigAsset, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<USkeletalMesh> SourcePreviewMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourcePreviewMesh, __ReturnBuffer);

					return *(TSoftObjectPtr<USkeletalMesh>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourcePreviewMesh, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UIKRigDefinition> TargetIKRigAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TargetIKRigAsset, __ReturnBuffer);

					return *(TSoftObjectPtr<UIKRigDefinition>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TargetIKRigAsset, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<USkeletalMesh> TargetPreviewMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TargetPreviewMesh, __ReturnBuffer);

					return *(TSoftObjectPtr<USkeletalMesh>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TargetPreviewMesh, __InBuffer);
				}
			}
		}

		public FVector TargetMeshOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TargetMeshOffset, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TargetMeshOffset, __InBuffer);
				}
			}
		}

		public float TargetMeshScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TargetMeshScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TargetMeshScale, __InBuffer);
				}
			}
		}

		public FVector SourceMeshOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceMeshOffset, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceMeshOffset, __InBuffer);
				}
			}
		}

		public bool bDebugDraw
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDebugDraw, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDebugDraw, __InBuffer);
				}
			}
		}

		public bool bDrawFinalGoals
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawFinalGoals, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawFinalGoals, __InBuffer);
				}
			}
		}

		public bool bDrawSourceLocations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawSourceLocations, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawSourceLocations, __InBuffer);
				}
			}
		}

		public float ChainDrawSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ChainDrawSize, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ChainDrawSize, __InBuffer);
				}
			}
		}

		public float ChainDrawThickness
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ChainDrawThickness, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ChainDrawThickness, __InBuffer);
				}
			}
		}

		public float BoneDrawSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BoneDrawSize, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BoneDrawSize, __InBuffer);
				}
			}
		}

		public UObject Controller
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Controller, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Controller, __InBuffer);
				}
			}
		}

		public TSet<USkeletalMesh> MeshesAskedToFixRootHeightFor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshesAskedToFixRootHeightFor, __ReturnBuffer);

					return *(TSet<USkeletalMesh>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshesAskedToFixRootHeightFor, __InBuffer);
				}
			}
		}

		public TArray<URetargetChainSettings> ChainSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ChainSettings, __ReturnBuffer);

					return *(TArray<URetargetChainSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ChainSettings, __InBuffer);
				}
			}
		}

		public URetargetRootSettings RootSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RootSettings, __ReturnBuffer);

					return *(URetargetRootSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RootSettings, __InBuffer);
				}
			}
		}

		public UIKRetargetGlobalSettings GlobalSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GlobalSettings, __ReturnBuffer);

					return *(UIKRetargetGlobalSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GlobalSettings, __InBuffer);
				}
			}
		}

		public TMap<FName, FRetargetProfile> Profiles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Profiles, __ReturnBuffer);

					return *(TMap<FName, FRetargetProfile>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Profiles, __InBuffer);
				}
			}
		}

		public FName CurrentProfile
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentProfile, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentProfile, __InBuffer);
				}
			}
		}

		public TMap<FName, FIKRetargetPose> SourceRetargetPoses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceRetargetPoses, __ReturnBuffer);

					return *(TMap<FName, FIKRetargetPose>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceRetargetPoses, __InBuffer);
				}
			}
		}

		public TMap<FName, FIKRetargetPose> TargetRetargetPoses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TargetRetargetPoses, __ReturnBuffer);

					return *(TMap<FName, FIKRetargetPose>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TargetRetargetPoses, __InBuffer);
				}
			}
		}

		public FName CurrentSourceRetargetPose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentSourceRetargetPose, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentSourceRetargetPose, __InBuffer);
				}
			}
		}

		public FName CurrentTargetRetargetPose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentTargetRetargetPose, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentTargetRetargetPose, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IKRig.IKRetargeter");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetRootSettingsInRetargetProfile(ref FRetargetProfile RetargetProfile, FTargetRootSettings RootSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = RetargetProfile?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RootSettings?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetRootSettingsInRetargetProfile, __InBuffer, __OutBuffer);

				RetargetProfile = *(FRetargetProfile*)(__OutBuffer);

			}
		}

		public static void SetGlobalSettingsInRetargetProfile(ref FRetargetProfile RetargetProfile, FRetargetGlobalSettings GlobalSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = RetargetProfile?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = GlobalSettings?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetGlobalSettingsInRetargetProfile, __InBuffer, __OutBuffer);

				RetargetProfile = *(FRetargetProfile*)(__OutBuffer);

			}
		}

		public static void SetChainSpeedPlantSettingsInRetargetProfile(ref FRetargetProfile RetargetProfile, FTargetChainSpeedPlantSettings SpeedPlantSettings, FName TargetChainName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = RetargetProfile?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SpeedPlantSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = TargetChainName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetChainSpeedPlantSettingsInRetargetProfile, __InBuffer, __OutBuffer);

				RetargetProfile = *(FRetargetProfile*)(__OutBuffer);

			}
		}

		public static void SetChainSettingsInRetargetProfile(ref FRetargetProfile RetargetProfile, FTargetChainSettings ChainSettings, FName TargetChainName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = RetargetProfile?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ChainSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = TargetChainName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetChainSettingsInRetargetProfile, __InBuffer, __OutBuffer);

				RetargetProfile = *(FRetargetProfile*)(__OutBuffer);

			}
		}

		public static void SetChainIKSettingsInRetargetProfile(ref FRetargetProfile RetargetProfile, FTargetChainIKSettings IKSettings, FName TargetChainName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = RetargetProfile?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = IKSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = TargetChainName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetChainIKSettingsInRetargetProfile, __InBuffer, __OutBuffer);

				RetargetProfile = *(FRetargetProfile*)(__OutBuffer);

			}
		}

		public static void SetChainFKSettingsInRetargetProfile(ref FRetargetProfile RetargetProfile, FTargetChainFKSettings FKSettings, FName TargetChainName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = RetargetProfile?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FKSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = TargetChainName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetChainFKSettingsInRetargetProfile, __InBuffer, __OutBuffer);

				RetargetProfile = *(FRetargetProfile*)(__OutBuffer);

			}
		}

		public static FTargetRootSettings GetRootSettingsFromRetargetProfile(ref FRetargetProfile RetargetProfile)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = RetargetProfile?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __GetRootSettingsFromRetargetProfile, __InBuffer, __OutBuffer, __ReturnBuffer);

				RetargetProfile = *(FRetargetProfile*)(__OutBuffer);

				return *(FTargetRootSettings*)__ReturnBuffer;
			}
		}

		public static void GetRootSettingsFromRetargetAsset(UIKRetargeter RetargetAsset, FName OptionalProfileName, ref FTargetRootSettings OutSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = RetargetAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OptionalProfileName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutSettings?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetRootSettingsFromRetargetAsset, __InBuffer, __OutBuffer);

				OutSettings = *(FTargetRootSettings*)(__OutBuffer);

			}
		}

		public static FRetargetGlobalSettings GetGlobalSettingsFromRetargetProfile(ref FRetargetProfile RetargetProfile)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = RetargetProfile?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __GetGlobalSettingsFromRetargetProfile, __InBuffer, __OutBuffer, __ReturnBuffer);

				RetargetProfile = *(FRetargetProfile*)(__OutBuffer);

				return *(FRetargetGlobalSettings*)__ReturnBuffer;
			}
		}

		public static void GetGlobalSettingsFromRetargetAsset(UIKRetargeter RetargetAsset, FName OptionalProfileName, ref FRetargetGlobalSettings OutSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = RetargetAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OptionalProfileName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutSettings?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetGlobalSettingsFromRetargetAsset, __InBuffer, __OutBuffer);

				OutSettings = *(FRetargetGlobalSettings*)(__OutBuffer);

			}
		}

		public static FTargetChainSettings GetChainUsingGoalFromRetargetAsset(UIKRetargeter RetargetAsset, FName IKGoalName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = RetargetAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = IKGoalName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetChainUsingGoalFromRetargetAsset, __InBuffer, __ReturnBuffer);

				return *(FTargetChainSettings*)__ReturnBuffer;
			}
		}

		public static FTargetChainSettings GetChainSettingsFromRetargetProfile(ref FRetargetProfile RetargetProfile, FName TargetChainName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = RetargetProfile?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TargetChainName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __GetChainSettingsFromRetargetProfile, __InBuffer, __OutBuffer, __ReturnBuffer);

				RetargetProfile = *(FRetargetProfile*)(__OutBuffer);

				return *(FTargetChainSettings*)__ReturnBuffer;
			}
		}

		public static FTargetChainSettings GetChainSettingsFromRetargetAsset(UIKRetargeter RetargetAsset, FName TargetChainName, FName OptionalProfileName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = RetargetAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TargetChainName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OptionalProfileName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetChainSettingsFromRetargetAsset, __InBuffer, __ReturnBuffer);

				return *(FTargetChainSettings*)__ReturnBuffer;
			}
		}

		private static uint __SourceIKRigAsset = 0;

		private static uint __SourcePreviewMesh = 0;

		private static uint __TargetIKRigAsset = 0;

		private static uint __TargetPreviewMesh = 0;

		private static uint __TargetMeshOffset = 0;

		private static uint __TargetMeshScale = 0;

		private static uint __SourceMeshOffset = 0;

		private static uint __bDebugDraw = 0;

		private static uint __bDrawFinalGoals = 0;

		private static uint __bDrawSourceLocations = 0;

		private static uint __ChainDrawSize = 0;

		private static uint __ChainDrawThickness = 0;

		private static uint __BoneDrawSize = 0;

		private static uint __Controller = 0;

		private static uint __MeshesAskedToFixRootHeightFor = 0;

		private static uint __ChainSettings = 0;

		private static uint __RootSettings = 0;

		private static uint __GlobalSettings = 0;

		private static uint __Profiles = 0;

		private static uint __CurrentProfile = 0;

		private static uint __SourceRetargetPoses = 0;

		private static uint __TargetRetargetPoses = 0;

		private static uint __CurrentSourceRetargetPose = 0;

		private static uint __CurrentTargetRetargetPose = 0;

		private static uint __SetRootSettingsInRetargetProfile = 0;

		private static uint __SetGlobalSettingsInRetargetProfile = 0;

		private static uint __SetChainSpeedPlantSettingsInRetargetProfile = 0;

		private static uint __SetChainSettingsInRetargetProfile = 0;

		private static uint __SetChainIKSettingsInRetargetProfile = 0;

		private static uint __SetChainFKSettingsInRetargetProfile = 0;

		private static uint __GetRootSettingsFromRetargetProfile = 0;

		private static uint __GetRootSettingsFromRetargetAsset = 0;

		private static uint __GetGlobalSettingsFromRetargetProfile = 0;

		private static uint __GetGlobalSettingsFromRetargetAsset = 0;

		private static uint __GetChainUsingGoalFromRetargetAsset = 0;

		private static uint __GetChainSettingsFromRetargetProfile = 0;

		private static uint __GetChainSettingsFromRetargetAsset = 0;
	}
}