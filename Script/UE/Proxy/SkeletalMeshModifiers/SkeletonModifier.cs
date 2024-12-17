using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.SkeletalMeshModifiers
{
	[PathName("/Script/SkeletalMeshModifiers.SkeletonModifier")]
	public partial class USkeletonModifier : UObject, IStaticClass
	{
		public TWeakObjectPtr<USkeletalMesh> SkeletalMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SkeletalMesh, __ReturnBuffer);

					return *(TWeakObjectPtr<USkeletalMesh>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SkeletalMesh, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SkeletalMeshModifiers.SkeletonModifier");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetSkeletalMesh(USkeletalMesh InSkeletalMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetSkeletalMesh, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InBoneName">
		/// The new bone's name that needs to be moved.
		/// </param>
		/// <param name="InNewTransform">
		/// The new local transform in the bone's parent space.
		/// </param>
		/// <param name="bMoveChildren">
		/// Propagate new transform to children
		/// </param>
		/// <c>
		/// true if the operation succeeded, false otherwise. 
		/// </c>
		/// <returns>
		/// </returns>
		public virtual bool SetBoneTransform(FName InBoneName, FTransform InNewTransform, bool bMoveChildren)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNewTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bMoveChildren;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetBoneTransform, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetBonesTransforms(TArray<FName> InBoneNames, TArray<FTransform> InNewTransforms, bool bMoveChildren)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InBoneNames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNewTransforms?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bMoveChildren;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetBonesTransforms, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RenameBones(TArray<FName> InOldBoneNames, TArray<FName> InNewBoneNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InOldBoneNames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNewBoneNames?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameBones, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InOldBoneName">
		/// The current bone's name.
		/// </param>
		/// <param name="InNewBoneName">
		/// The new bone's name.
		/// </param>
		/// <c>
		/// true if the operation succeeded, false otherwise. 
		/// </c>
		/// <returns>
		/// </returns>
		public virtual bool RenameBone(FName InOldBoneName, FName InNewBoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InOldBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNewBoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameBone, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveBones(TArray<FName> InBoneNames, bool bRemoveChildren)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InBoneNames?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bRemoveChildren;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveBones, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InBoneName">
		/// The new bone's name.
		/// </param>
		/// <param name="bRemoveChildren">
		/// Remove children recursively.
		/// </param>
		/// <c>
		/// true if the operation succeeded, false otherwise. 
		/// </c>
		/// <returns>
		/// </returns>
		public virtual bool RemoveBone(FName InBoneName, bool bRemoveChildren)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bRemoveChildren;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveBone, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool ParentBones(TArray<FName> InBoneNames, TArray<FName> InParentNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InBoneNames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParentNames?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ParentBones, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InBoneName">
		/// The current bone's name.
		/// </param>
		/// <param name="InParentName">
		/// The new parent's name (Name_NONE to unparent).
		/// </param>
		/// <c>
		/// true if the operation succeeded, false otherwise. 
		/// </c>
		/// <returns>
		/// </returns>
		public virtual bool ParentBone(FName InBoneName, FName InParentName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParentName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ParentBone, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool OrientBones(TArray<FName> InBoneNames, FOrientOptions InOptions = null)
		{
			unsafe
			{
				InOptions ??= new FOrientOptions();

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InBoneNames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __OrientBones, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InBoneName">
		/// The current bone's name.
		/// </param>
		/// <param name="InOptions">
		/// The orienting options
		/// </param>
		/// <c>
		/// true if the operation succeeded, false otherwise. 
		/// </c>
		/// <returns>
		/// </returns>
		public virtual bool OrientBone(FName InBoneName, FOrientOptions InOptions = null)
		{
			unsafe
			{
				InOptions ??= new FOrientOptions();

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __OrientBone, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool MirrorBones(TArray<FName> InBonesName, FMirrorOptions InOptions = null)
		{
			unsafe
			{
				InOptions ??= new FMirrorOptions();

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InBonesName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __MirrorBones, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InBoneName">
		/// The new bone's name.
		/// </param>
		/// <param name="InOptions">
		/// The mirroring options
		/// </param>
		/// <c>
		/// true if the operation succeeded, false otherwise. 
		/// </c>
		/// <returns>
		/// </returns>
		public virtual bool MirrorBone(FName InBoneName, FMirrorOptions InOptions = null)
		{
			unsafe
			{
				InOptions ??= new FMirrorOptions();

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __MirrorBone, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InBoneName">
		/// The current bone's name.
		/// </param>
		/// <c>
		/// The current bone's parent name 
		/// </c>
		/// <returns>
		/// </returns>
		public virtual FName GetParentName(FName InBoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetParentName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		/// <param name="InBoneName">
		/// The parent's name.
		/// </param>
		/// <param name="bRecursive">
		/// If set to true grand-children will also be added recursively
		/// </param>
		/// <c>
		/// The children names list 
		/// </c>
		/// <returns>
		/// </returns>
		public virtual TArray<FName> GetChildrenNames(FName InBoneName, bool bRecursive = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bRecursive;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetChildrenNames, __InBuffer, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		/// <param name="InBoneName">
		/// The current bone's name.
		/// </param>
		/// <param name="bGlobal">
		/// Whether it should return the parent space or global transform
		/// </param>
		/// <c>
		/// The current bone's transform 
		/// </c>
		/// <returns>
		/// </returns>
		public virtual FTransform GetBoneTransform(FName InBoneName, bool bGlobal = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bGlobal;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoneTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <c>
		/// All bone names list
		/// </c>
		/// <returns>
		/// </returns>
		public virtual TArray<FName> GetAllBoneNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAllBoneNames, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if commit succeeded.
		/// </returns>
		public virtual bool CommitSkeletonToSkeletalMesh()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __CommitSkeletonToSkeletalMesh, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool AddBones(TArray<FName> InBonesName, TArray<FName> InParentsName, TArray<FTransform> InTransforms)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InBonesName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParentsName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InTransforms?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddBones, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InBoneName">
		/// The new bone's name.
		/// </param>
		/// <param name="InParentName">
		/// The new bone parent's name. 
		/// </param>
		/// <param name="InTransform">
		/// The default local transform in the parent space.
		/// </param>
		/// <c>
		/// true if the operation succeeded, false otherwise. 
		/// </c>
		/// <returns>
		/// </returns>
		public virtual bool AddBone(FName InBoneName, FName InParentName, FTransform InTransform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParentName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InTransform?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddBone, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SkeletalMesh = 0;

		private static uint __SetSkeletalMesh = 0;

		private static uint __SetBoneTransform = 0;

		private static uint __SetBonesTransforms = 0;

		private static uint __RenameBones = 0;

		private static uint __RenameBone = 0;

		private static uint __RemoveBones = 0;

		private static uint __RemoveBone = 0;

		private static uint __ParentBones = 0;

		private static uint __ParentBone = 0;

		private static uint __OrientBones = 0;

		private static uint __OrientBone = 0;

		private static uint __MirrorBones = 0;

		private static uint __MirrorBone = 0;

		private static uint __GetParentName = 0;

		private static uint __GetChildrenNames = 0;

		private static uint __GetBoneTransform = 0;

		private static uint __GetAllBoneNames = 0;

		private static uint __CommitSkeletonToSkeletalMesh = 0;

		private static uint __AddBones = 0;

		private static uint __AddBone = 0;
	}
}