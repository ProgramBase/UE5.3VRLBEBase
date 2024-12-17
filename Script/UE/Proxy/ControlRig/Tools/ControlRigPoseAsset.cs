using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigPoseAsset")]
	public partial class UControlRigPoseAsset : UObject, IStaticClass
	{
		public FControlRigControlPose Pose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Pose, __ReturnBuffer);

					return *(FControlRigControlPose*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Pose, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRig.ControlRigPoseAsset");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SelectControls(UControlRig InControlRig, bool bDoMirror = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bDoMirror;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SelectControls, __InBuffer);
			}
		}

		public virtual void SavePose(UControlRig InControlRig, bool bUseAll)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bUseAll;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SavePose, __InBuffer);
			}
		}

		public virtual void ReplaceControlName(FName CurrentName, FName NewName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = CurrentName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReplaceControlName, __InBuffer);
			}
		}

		public virtual void PastePose(UControlRig InControlRig, bool bDoKey = false, bool bDoMirror = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bDoKey;

				*(bool*)(__InBuffer + 9) = bDoMirror;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __PastePose, __InBuffer);
			}
		}

		public virtual void GetCurrentPose(UControlRig InControlRig, ref FControlRigControlPose OutPose)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPose?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetCurrentPose, __InBuffer, __OutBuffer);

				OutPose = *(FControlRigControlPose*)(__OutBuffer);

			}
		}

		public virtual TArray<FName> GetControlNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetControlNames, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		public virtual bool DoesMirrorMatch(UControlRig ControlRig, FName ControlName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DoesMirrorMatch, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __Pose = 0;

		private static uint __SelectControls = 0;

		private static uint __SavePose = 0;

		private static uint __ReplaceControlName = 0;

		private static uint __PastePose = 0;

		private static uint __GetCurrentPose = 0;

		private static uint __GetControlNames = 0;

		private static uint __DoesMirrorMatch = 0;
	}
}