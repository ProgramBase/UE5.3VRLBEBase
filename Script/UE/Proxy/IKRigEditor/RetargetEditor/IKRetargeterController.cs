using Script.CoreUObject;
using Script.Library;
using Script.IKRig;
using Script.Engine;

namespace Script.IKRigEditor
{
	[PathName("/Script/IKRigEditor.IKRetargeterController")]
	public partial class UIKRetargeterController : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IKRigEditor.IKRetargeterController");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetSourceChain(FName SourceChainName, FName TargetChainName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SourceChainName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TargetChainName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetSourceChain, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetRotationOffsetForRetargetPoseBone(FName BoneName, FQuat RotationOffset, ERetargetSourceOrTarget SkeletonMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RotationOffset?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)SkeletonMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRotationOffsetForRetargetPoseBone, __InBuffer);
			}
		}

		public virtual void SetRootSettings(FTargetRootSettings RootSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = RootSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRootSettings, __InBuffer);
			}
		}

		public virtual void SetRootOffsetInRetargetPose(FVector TranslationOffset, ERetargetSourceOrTarget SourceOrTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = TranslationOffset?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)SourceOrTarget;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRootOffsetInRetargetPose, __InBuffer);
			}
		}

		public virtual bool SetRetargetChainSettings(FName TargetChainName, FTargetChainSettings Settings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TargetChainName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Settings?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetRetargetChainSettings, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetPreviewMesh(ERetargetSourceOrTarget SourceOrTarget, USkeletalMesh InPreviewMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)SourceOrTarget;

				*(nint*)(__InBuffer + 1) = InPreviewMesh?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPreviewMesh, __InBuffer);
			}
		}

		public virtual void SetIKRig(ERetargetSourceOrTarget SourceOrTarget, UIKRigDefinition IKRig)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)SourceOrTarget;

				*(nint*)(__InBuffer + 1) = IKRig?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIKRig, __InBuffer);
			}
		}

		public virtual void SetGlobalSettings(FRetargetGlobalSettings GlobalSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = GlobalSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGlobalSettings, __InBuffer);
			}
		}

		public virtual bool SetCurrentRetargetPose(FName CurrentPose, ERetargetSourceOrTarget SourceOrTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = CurrentPose?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)SourceOrTarget;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCurrentRetargetPose, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void ResetRetargetPose(FName PoseToReset, TArray<FName> BonesToReset, ERetargetSourceOrTarget SourceOrTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = PoseToReset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BonesToReset?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)SourceOrTarget;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ResetRetargetPose, __InBuffer);
			}
		}

		public virtual bool RenameRetargetPose(FName OldPoseName, FName NewPoseName, ERetargetSourceOrTarget SourceOrTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = OldPoseName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewPoseName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)SourceOrTarget;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameRetargetPose, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveRetargetPose(FName PoseToRemove, ERetargetSourceOrTarget SourceOrTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = PoseToRemove?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)SourceOrTarget;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveRetargetPose, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FName GetSourceChain(FName TargetChainName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TargetChainName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSourceChain, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual FQuat GetRotationOffsetForRetargetPoseBone(FName BoneName, ERetargetSourceOrTarget SourceOrTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)SourceOrTarget;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRotationOffsetForRetargetPoseBone, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		public virtual FTargetRootSettings GetRootSettings()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRootSettings, __ReturnBuffer);

				return *(FTargetRootSettings*)__ReturnBuffer;
			}
		}

		public virtual FVector GetRootOffsetInRetargetPose(ERetargetSourceOrTarget SourceOrTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)SourceOrTarget;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRootOffsetInRetargetPose, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual TMap<FName, FIKRetargetPose> GetRetargetPoses(ERetargetSourceOrTarget SourceOrTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)SourceOrTarget;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRetargetPoses, __InBuffer, __ReturnBuffer);

				return *(TMap<FName, FIKRetargetPose>*)__ReturnBuffer;
			}
		}

		public virtual FTargetChainSettings GetRetargetChainSettings(FName TargetChainName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TargetChainName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRetargetChainSettings, __InBuffer, __ReturnBuffer);

				return *(FTargetChainSettings*)__ReturnBuffer;
			}
		}

		public virtual USkeletalMesh GetPreviewMesh(ERetargetSourceOrTarget SourceOrTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)SourceOrTarget;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetPreviewMesh, __InBuffer, __ReturnBuffer);

				return *(USkeletalMesh*)__ReturnBuffer;
			}
		}

		public virtual UIKRigDefinition GetIKRig(ERetargetSourceOrTarget SourceOrTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)SourceOrTarget;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetIKRig, __InBuffer, __ReturnBuffer);

				return *(UIKRigDefinition*)__ReturnBuffer;
			}
		}

		public virtual FRetargetGlobalSettings GetGlobalSettings()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetGlobalSettings, __ReturnBuffer);

				return *(FRetargetGlobalSettings*)__ReturnBuffer;
			}
		}

		public virtual FName GetCurrentRetargetPoseName(ERetargetSourceOrTarget SourceOrTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)SourceOrTarget;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetCurrentRetargetPoseName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual FIKRetargetPose GetCurrentRetargetPose(ERetargetSourceOrTarget SourceOrTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)SourceOrTarget;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetCurrentRetargetPose, __InBuffer, __ReturnBuffer);

				return *(FIKRetargetPose*)__ReturnBuffer;
			}
		}

		public static UIKRetargeterController GetController(UIKRetargeter InRetargeterAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InRetargeterAsset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetController, __InBuffer, __ReturnBuffer);

				return *(UIKRetargeterController*)__ReturnBuffer;
			}
		}

		public virtual TArray<URetargetChainSettings> GetAllChainSettings()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAllChainSettings, __ReturnBuffer);

				return *(TArray<URetargetChainSettings>*)__ReturnBuffer;
			}
		}

		public virtual FName DuplicateRetargetPose(FName PoseToDuplicate, FName NewName, ERetargetSourceOrTarget SourceOrTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = PoseToDuplicate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)SourceOrTarget;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __DuplicateRetargetPose, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual FName CreateRetargetPose(FName NewPoseName, ERetargetSourceOrTarget SourceOrTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NewPoseName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)SourceOrTarget;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateRetargetPose, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual void AutoMapChains(EAutoMapChainType AutoMapType, bool bForceRemap)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = (byte)AutoMapType;

				*(bool*)(__InBuffer + 1) = bForceRemap;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AutoMapChains, __InBuffer);
			}
		}

		private static uint __SetSourceChain = 0;

		private static uint __SetRotationOffsetForRetargetPoseBone = 0;

		private static uint __SetRootSettings = 0;

		private static uint __SetRootOffsetInRetargetPose = 0;

		private static uint __SetRetargetChainSettings = 0;

		private static uint __SetPreviewMesh = 0;

		private static uint __SetIKRig = 0;

		private static uint __SetGlobalSettings = 0;

		private static uint __SetCurrentRetargetPose = 0;

		private static uint __ResetRetargetPose = 0;

		private static uint __RenameRetargetPose = 0;

		private static uint __RemoveRetargetPose = 0;

		private static uint __GetSourceChain = 0;

		private static uint __GetRotationOffsetForRetargetPoseBone = 0;

		private static uint __GetRootSettings = 0;

		private static uint __GetRootOffsetInRetargetPose = 0;

		private static uint __GetRetargetPoses = 0;

		private static uint __GetRetargetChainSettings = 0;

		private static uint __GetPreviewMesh = 0;

		private static uint __GetIKRig = 0;

		private static uint __GetGlobalSettings = 0;

		private static uint __GetCurrentRetargetPoseName = 0;

		private static uint __GetCurrentRetargetPose = 0;

		private static uint __GetController = 0;

		private static uint __GetAllChainSettings = 0;

		private static uint __DuplicateRetargetPose = 0;

		private static uint __CreateRetargetPose = 0;

		private static uint __AutoMapChains = 0;
	}
}