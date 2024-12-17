using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PoseableMeshComponent")]
	public partial class UPoseableMeshComponent : USkinnedMeshComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PoseableMeshComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetBoneTransformByName(FName BoneName, FTransform InTransform, EBoneSpaces BoneSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)BoneSpace;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBoneTransformByName, __InBuffer);
			}
		}

		public virtual void SetBoneScaleByName(FName BoneName, FVector InScale3D, EBoneSpaces BoneSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InScale3D?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)BoneSpace;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBoneScaleByName, __InBuffer);
			}
		}

		public virtual void SetBoneRotationByName(FName BoneName, FRotator InRotation, EBoneSpaces BoneSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)BoneSpace;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBoneRotationByName, __InBuffer);
			}
		}

		public virtual void SetBoneLocationByName(FName BoneName, FVector InLocation, EBoneSpaces BoneSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)BoneSpace;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBoneLocationByName, __InBuffer);
			}
		}

		public virtual void ResetBoneTransformByName(FName BoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ResetBoneTransformByName, __InBuffer);
			}
		}

		public virtual FTransform GetBoneTransformByName(FName BoneName, EBoneSpaces BoneSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)BoneSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoneTransformByName, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual FVector GetBoneScaleByName(FName BoneName, EBoneSpaces BoneSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)BoneSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoneScaleByName, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FRotator GetBoneRotationByName(FName BoneName, EBoneSpaces BoneSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)BoneSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoneRotationByName, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public virtual FVector GetBoneLocationByName(FName BoneName, EBoneSpaces BoneSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)BoneSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoneLocationByName, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual void CopyPoseFromSkeletalComponent(USkeletalMeshComponent InComponentToCopy)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InComponentToCopy?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CopyPoseFromSkeletalComponent, __InBuffer);
			}
		}

		private static uint __SetBoneTransformByName = 0;

		private static uint __SetBoneScaleByName = 0;

		private static uint __SetBoneRotationByName = 0;

		private static uint __SetBoneLocationByName = 0;

		private static uint __ResetBoneTransformByName = 0;

		private static uint __GetBoneTransformByName = 0;

		private static uint __GetBoneScaleByName = 0;

		private static uint __GetBoneRotationByName = 0;

		private static uint __GetBoneLocationByName = 0;

		private static uint __CopyPoseFromSkeletalComponent = 0;
	}
}