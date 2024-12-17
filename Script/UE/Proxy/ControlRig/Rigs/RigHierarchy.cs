using Script.CoreUObject;
using Script.Library;
using Script.AnimationCore;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigHierarchy")]
	public partial class URigHierarchy : UObject, IStaticClass
	{
		public FRigHierarchyModifiedDynamicEvent ModifiedEventDynamic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ModifiedEventDynamic, __ReturnBuffer);

					return *(FRigHierarchyModifiedDynamicEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ModifiedEventDynamic, __InBuffer);
				}
			}
		}

		public ushort TopologyVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TopologyVersion, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TopologyVersion, __InBuffer);
				}
			}
		}

		public ushort MetadataVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MetadataVersion, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MetadataVersion, __InBuffer);
				}
			}
		}

		public ushort MetadataTagVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MetadataTagVersion, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MetadataTagVersion, __InBuffer);
				}
			}
		}

		public bool bEnableDirtyPropagation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableDirtyPropagation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableDirtyPropagation, __InBuffer);
				}
			}
		}

		public int TransformStackIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TransformStackIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TransformStackIndex, __InBuffer);
				}
			}
		}

		public URigHierarchyController HierarchyController
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HierarchyController, __ReturnBuffer);

					return *(URigHierarchyController*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HierarchyController, __InBuffer);
				}
			}
		}

		public TMap<FRigElementKey, FRigElementKey> PreviousNameMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviousNameMap, __ReturnBuffer);

					return *(TMap<FRigElementKey, FRigElementKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviousNameMap, __InBuffer);
				}
			}
		}

		public URigHierarchy HierarchyForCacheValidation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HierarchyForCacheValidation, __ReturnBuffer);

					return *(URigHierarchy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HierarchyForCacheValidation, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRig.RigHierarchy");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InElementIndex">
		/// The index of the element to set the value for
		/// </param>
		/// <param name="InValue">
		/// The value to set on the curve
		/// </param>
		/// <param name="bSetupUndo">
		/// If true the transform stack will be setup for undo / redo
		/// </param>
		public virtual void UnsetCurveValueByIndex(int InElementIndex, bool bSetupUndo = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = InElementIndex;

				*(bool*)(__InBuffer + 4) = bSetupUndo;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnsetCurveValueByIndex, __InBuffer);
			}
		}

		/// <param name="InKey">
		/// The key of the element to set the value for
		/// </param>
		/// <param name="InValue">
		/// The value to set on the curve
		/// </param>
		/// <param name="bSetupUndo">
		/// If true the transform stack will be setup for undo / redo
		/// </param>
		public virtual void UnsetCurveValue(FRigElementKey InKey, bool bSetupUndo = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndo;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnsetCurveValue, __InBuffer);
			}
		}

		/// <param name="InChild">
		/// The key of the multi parented element
		/// </param>
		/// <param name="bInitial">
		/// If true the initial weights will be used
		/// </param>
		/// <param name="bAffectChildren">
		/// If set to false children will not move (maintain global).
		/// </param>
		/// <returns>
		/// Returns true if changing the weight was successful
		/// </returns>
		public virtual bool SwitchToWorldSpace(FRigElementKey InChild, bool bInitial = false, bool bAffectChildren = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InChild?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bInitial;

				*(bool*)(__InBuffer + 9) = bAffectChildren;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SwitchToWorldSpace, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InChild">
		/// The key of the multi parented element
		/// </param>
		/// <param name="InParent">
		/// The key of the parent to look up the weight for
		/// </param>
		/// <param name="bInitial">
		/// If true the initial weights will be used
		/// </param>
		/// <param name="bAffectChildren">
		/// If set to false children will not move (maintain global).
		/// </param>
		/// <returns>
		/// Returns true if changing the weight was successful
		/// </returns>
		public virtual bool SwitchToParent(FRigElementKey InChild, FRigElementKey InParent, bool bInitial = false, bool bAffectChildren = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InChild?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParent?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInitial;

				*(bool*)(__InBuffer + 17) = bAffectChildren;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SwitchToParent, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InChild">
		/// The key of the multi parented element
		/// </param>
		/// <param name="bInitial">
		/// If true the initial weights will be used
		/// </param>
		/// <param name="bAffectChildren">
		/// If set to false children will not move (maintain global).
		/// </param>
		/// <returns>
		/// Returns true if changing the weight was successful
		/// </returns>
		public virtual bool SwitchToDefaultParent(FRigElementKey InChild, bool bInitial = false, bool bAffectChildren = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InChild?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bInitial;

				*(bool*)(__InBuffer + 9) = bAffectChildren;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SwitchToDefaultParent, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InKeys">
		/// The keys to sort
		/// </param>
		/// <returns>
		/// The sorted keys
		/// </returns>
		public virtual TArray<FRigElementKey> SortKeys(TArray<FRigElementKey> InKeys)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKeys?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SortKeys, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetVectorMetadata(FRigElementKey InItem, FName InMetadataName, FVector InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetVectorMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetVectorArrayMetadata(FRigElementKey InItem, FName InMetadataName, TArray<FVector> InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetVectorArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetTransformMetadata(FRigElementKey InItem, FName InMetadataName, FTransform InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetTransformMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetTransformArrayMetadata(FRigElementKey InItem, FName InMetadataName, TArray<FTransform> InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetTransformArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The item to set the tag for
		/// </param>
		/// <param name="InTag">
		/// The tag to set
		/// </param>
		public virtual bool SetTag(FRigElementKey InItem, FName InTag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTag?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetTag, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetRotatorMetadata(FRigElementKey InItem, FName InMetadataName, FRotator InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetRotatorMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetRotatorArrayMetadata(FRigElementKey InItem, FName InMetadataName, TArray<FRotator> InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetRotatorArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetRigElementKeyMetadata(FRigElementKey InItem, FName InMetadataName, FRigElementKey InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetRigElementKeyMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetRigElementKeyArrayMetadata(FRigElementKey InItem, FName InMetadataName, TArray<FRigElementKey> InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetRigElementKeyArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetQuatMetadata(FRigElementKey InItem, FName InMetadataName, FQuat InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetQuatMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetQuatArrayMetadata(FRigElementKey InItem, FName InMetadataName, TArray<FQuat> InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetQuatArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InPose">
		/// The pose to set on the hierarchy
		/// </param>
		public virtual void SetPose_ForBlueprint(FRigPose InPose)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPose?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPose_ForBlueprint, __InBuffer);
			}
		}

		/// <param name="InChild">
		/// The key of the multi parented element
		/// </param>
		/// <param name="InWeights">
		/// The new weights to set for the parents
		/// </param>
		/// <param name="bInitial">
		/// If true the initial weights will be used
		/// </param>
		/// <param name="bAffectChildren">
		/// If set to false children will not move (maintain global).
		/// </param>
		/// <returns>
		/// Returns true if changing the weight was successful
		/// </returns>
		public virtual bool SetParentWeightArray(FRigElementKey InChild, TArray<FRigElementWeight> InWeights, bool bInitial = false, bool bAffectChildren = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InChild?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InWeights?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInitial;

				*(bool*)(__InBuffer + 17) = bAffectChildren;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetParentWeightArray, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InChild">
		/// The key of the multi parented element
		/// </param>
		/// <param name="InParent">
		/// The key of the parent to look up the weight for
		/// </param>
		/// <param name="InWeight">
		/// The new weight to set for the parent
		/// </param>
		/// <param name="bInitial">
		/// If true the initial weights will be used
		/// </param>
		/// <param name="bAffectChildren">
		/// If set to false children will not move (maintain global).
		/// </param>
		/// <returns>
		/// Returns true if changing the weight was successful
		/// </returns>
		public virtual bool SetParentWeight(FRigElementKey InChild, FRigElementKey InParent, FRigElementWeight InWeight, bool bInitial = false, bool bAffectChildren = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InChild?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InWeight?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bInitial;

				*(bool*)(__InBuffer + 25) = bAffectChildren;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetParentWeight, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetNameMetadata(FRigElementKey InItem, FName InMetadataName, FName InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetNameMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetNameArrayMetadata(FRigElementKey InItem, FName InMetadataName, TArray<FName> InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetNameArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InElementIndex">
		/// The index of the element to set the transform for
		/// </param>
		/// <param name="InTransform">
		/// The new transform value to set
		/// </param>
		/// <param name="bInitial">
		/// If true the initial transform will be used
		/// </param>
		/// <param name="bSetupUndo">
		/// If true the transform stack will be setup for undo / redo
		/// </param>
		/// <param name="bAffectChildren">
		/// If set to false children will not move (maintain global).
		/// </param>
		public virtual void SetLocalTransformByIndex(int InElementIndex, FTransform InTransform, bool bInitial = false, bool bAffectChildren = true, bool bSetupUndo = false, bool bPrintPythonCommands = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = InElementIndex;

				*(nint*)(__InBuffer + 4) = InTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 12) = bInitial;

				*(bool*)(__InBuffer + 13) = bAffectChildren;

				*(bool*)(__InBuffer + 14) = bSetupUndo;

				*(bool*)(__InBuffer + 15) = bPrintPythonCommands;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLocalTransformByIndex, __InBuffer);
			}
		}

		/// <param name="InKey">
		/// The key to set the transform for
		/// </param>
		/// <param name="InTransform">
		/// The new transform value to set
		/// </param>
		/// <param name="bInitial">
		/// If true the initial transform will be used
		/// </param>
		/// <param name="bSetupUndo">
		/// If true the transform stack will be setup for undo / redo
		/// </param>
		/// <param name="bAffectChildren">
		/// If set to false children will not move (maintain global).
		/// </param>
		public virtual void SetLocalTransform(FRigElementKey InKey, FTransform InTransform, bool bInitial = false, bool bAffectChildren = true, bool bSetupUndo = false, bool bPrintPythonCommands = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInitial;

				*(bool*)(__InBuffer + 17) = bAffectChildren;

				*(bool*)(__InBuffer + 18) = bSetupUndo;

				*(bool*)(__InBuffer + 19) = bPrintPythonCommands;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLocalTransform, __InBuffer);
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetLinearColorMetadata(FRigElementKey InItem, FName InMetadataName, FLinearColor InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetLinearColorMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetLinearColorArrayMetadata(FRigElementKey InItem, FName InMetadataName, TArray<FLinearColor> InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetLinearColorArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetInt32Metadata(FRigElementKey InItem, FName InMetadataName, int InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = InValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetInt32Metadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetInt32ArrayMetadata(FRigElementKey InItem, FName InMetadataName, TArray<int> InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetInt32ArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InElementIndex">
		/// The index of the element to set the transform for
		/// </param>
		/// <param name="InTransform">
		/// The new transform value to set
		/// </param>
		/// <param name="bInitial">
		/// If true the initial transform will be used
		/// </param>
		/// <param name="bAffectChildren">
		/// If set to false children will not move (maintain global).
		/// </param>
		/// <param name="bSetupUndo">
		/// If true the transform stack will be setup for undo / redo
		/// </param>
		public virtual void SetGlobalTransformByIndex(int InElementIndex, FTransform InTransform, bool bInitial = false, bool bAffectChildren = true, bool bSetupUndo = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = InElementIndex;

				*(nint*)(__InBuffer + 4) = InTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 12) = bInitial;

				*(bool*)(__InBuffer + 13) = bAffectChildren;

				*(bool*)(__InBuffer + 14) = bSetupUndo;

				*(bool*)(__InBuffer + 15) = bPrintPythonCommand;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGlobalTransformByIndex, __InBuffer);
			}
		}

		/// <param name="InKey">
		/// The key to set the transform for
		/// </param>
		/// <param name="InTransform">
		/// The new transform value to set
		/// </param>
		/// <param name="bInitial">
		/// If true the initial transform will be used
		/// </param>
		/// <param name="bAffectChildren">
		/// If set to false children will not move (maintain global).
		/// </param>
		/// <param name="bSetupUndo">
		/// If true the transform stack will be setup for undo / redo
		/// </param>
		public virtual void SetGlobalTransform(FRigElementKey InKey, FTransform InTransform, bool bInitial = false, bool bAffectChildren = true, bool bSetupUndo = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInitial;

				*(bool*)(__InBuffer + 17) = bAffectChildren;

				*(bool*)(__InBuffer + 18) = bSetupUndo;

				*(bool*)(__InBuffer + 19) = bPrintPythonCommand;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGlobalTransform, __InBuffer);
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetFloatMetadata(FRigElementKey InItem, FName InMetadataName, float InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = InValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetFloatMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetFloatArrayMetadata(FRigElementKey InItem, FName InMetadataName, TArray<float> InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetFloatArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InElementIndex">
		/// The index of the element to set the value for
		/// </param>
		/// <param name="InValue">
		/// The value to set on the curve
		/// </param>
		/// <param name="bSetupUndo">
		/// If true the transform stack will be setup for undo / redo
		/// </param>
		public virtual void SetCurveValueByIndex(int InElementIndex, float InValue, bool bSetupUndo = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(int*)(__InBuffer) = InElementIndex;

				*(float*)(__InBuffer + 4) = InValue;

				*(bool*)(__InBuffer + 8) = bSetupUndo;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCurveValueByIndex, __InBuffer);
			}
		}

		/// <param name="InKey">
		/// The key of the element to set the value for
		/// </param>
		/// <param name="InValue">
		/// The value to set on the curve
		/// </param>
		/// <param name="bSetupUndo">
		/// If true the transform stack will be setup for undo / redo
		/// </param>
		public virtual void SetCurveValue(FRigElementKey InKey, float InValue, bool bSetupUndo = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InValue;

				*(bool*)(__InBuffer + 12) = bSetupUndo;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCurveValue, __InBuffer);
			}
		}

		/// <param name="InElementIndex">
		/// The index of the element to set the visibility for
		/// </param>
		/// <param name="bVisibility">
		/// The visibility to set on the control
		/// </param>
		public virtual void SetControlVisibilityByIndex(int InElementIndex, bool bVisibility)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = InElementIndex;

				*(bool*)(__InBuffer + 4) = bVisibility;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlVisibilityByIndex, __InBuffer);
			}
		}

		/// <param name="InKey">
		/// The key of the element to set the visibility for
		/// </param>
		/// <param name="bVisibility">
		/// The visibility to set on the control
		/// </param>
		public virtual void SetControlVisibility(FRigElementKey InKey, bool bVisibility)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bVisibility;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlVisibility, __InBuffer);
			}
		}

		/// <param name="InElementIndex">
		/// The index of the element to set the current value for
		/// </param>
		/// <param name="InValue">
		/// The value to set on the control
		/// </param>
		/// <param name="InValueType">
		/// The type of value to set
		/// </param>
		/// <param name="bSetupUndo">
		/// If true the transform stack will be setup for undo / redo
		/// </param>
		public virtual void SetControlValueByIndex(int InElementIndex, FRigControlValue InValue, ERigControlValueType InValueType = ERigControlValueType.Current, bool bSetupUndo = false, bool bPrintPythonCommands = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[15];

				*(int*)(__InBuffer) = InElementIndex;

				*(nint*)(__InBuffer + 4) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 12) = (byte)InValueType;

				*(bool*)(__InBuffer + 13) = bSetupUndo;

				*(bool*)(__InBuffer + 14) = bPrintPythonCommands;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlValueByIndex, __InBuffer);
			}
		}

		/// <param name="InKey">
		/// The key of the element to set the current value for
		/// </param>
		/// <param name="InValue">
		/// The value to set on the control
		/// </param>
		/// <param name="InValueType">
		/// The type of value to set
		/// </param>
		/// <param name="bSetupUndo">
		/// If true the transform stack will be setup for undo / redo
		/// </param>
		public virtual void SetControlValue(FRigElementKey InKey, FRigControlValue InValue, ERigControlValueType InValueType = ERigControlValueType.Current, bool bSetupUndo = false, bool bPrintPythonCommands = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)InValueType;

				*(bool*)(__InBuffer + 17) = bSetupUndo;

				*(bool*)(__InBuffer + 18) = bPrintPythonCommands;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlValue, __InBuffer);
			}
		}

		/// <param name="InElementIndex">
		/// The index of the control element to set the shape transform for
		/// </param>
		/// <param name="InTransform">
		/// The new local shape transform value to set
		/// </param>
		/// <param name="bInitial">
		/// If true the initial value will be used
		/// </param>
		/// <param name="bSetupUndo">
		/// If true the transform stack will be setup for undo / redo
		/// </param>
		public virtual void SetControlShapeTransformByIndex(int InElementIndex, FTransform InTransform, bool bInitial = false, bool bSetupUndo = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[14];

				*(int*)(__InBuffer) = InElementIndex;

				*(nint*)(__InBuffer + 4) = InTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 12) = bInitial;

				*(bool*)(__InBuffer + 13) = bSetupUndo;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlShapeTransformByIndex, __InBuffer);
			}
		}

		/// <param name="InKey">
		/// The key of the control element to set the shape transform for
		/// </param>
		/// <param name="InTransform">
		/// The new shape transform value to set
		/// </param>
		/// <param name="bInitial">
		/// If true the initial value will be used
		/// </param>
		/// <param name="bSetupUndo">
		/// If true the transform stack will be setup for undo / redo
		/// </param>
		public virtual void SetControlShapeTransform(FRigElementKey InKey, FTransform InTransform, bool bInitial = false, bool bSetupUndo = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInitial;

				*(bool*)(__InBuffer + 17) = bSetupUndo;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlShapeTransform, __InBuffer);
			}
		}

		/// <param name="InElementIndex">
		/// The index of the control element to set the settings for
		/// </param>
		/// <param name="InSettings">
		/// The new control settings value to set
		/// </param>
		/// <param name="bSetupUndo">
		/// If true the transform stack will be setup for undo / redo
		/// </param>
		public virtual void SetControlSettingsByIndex(int InElementIndex, FRigControlSettings InSettings, bool bSetupUndo = false, bool bForce = false, bool bPrintPythonCommands = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[15];

				*(int*)(__InBuffer) = InElementIndex;

				*(nint*)(__InBuffer + 4) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 12) = bSetupUndo;

				*(bool*)(__InBuffer + 13) = bForce;

				*(bool*)(__InBuffer + 14) = bPrintPythonCommands;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlSettingsByIndex, __InBuffer);
			}
		}

		/// <param name="InKey">
		/// The key of the control element to set the settings for
		/// </param>
		/// <param name="InSettings">
		/// The new control settings value to set
		/// </param>
		/// <param name="bSetupUndo">
		/// If true the transform stack will be setup for undo / redo
		/// </param>
		public virtual void SetControlSettings(FRigElementKey InKey, FRigControlSettings InSettings, bool bSetupUndo = false, bool bForce = false, bool bPrintPythonCommands = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndo;

				*(bool*)(__InBuffer + 17) = bForce;

				*(bool*)(__InBuffer + 18) = bPrintPythonCommands;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlSettings, __InBuffer);
			}
		}

		/// <param name="InElementIndex">
		/// The element index to look up
		/// </param>
		/// <param name="InRotator">
		/// The new preferred rotator to set
		/// </param>
		/// <param name="bInitial">
		/// If true we'll return the preferred rotator for the initial - otherwise current transform
		/// </param>
		/// <param name="bFixEulerFlips">
		/// If true the new rotator value will use the shortest path
		/// </param>
		public virtual void SetControlPreferredRotatorByIndex(int InElementIndex, FRotator InRotator, bool bInitial = false, bool bFixEulerFlips = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[14];

				*(int*)(__InBuffer) = InElementIndex;

				*(nint*)(__InBuffer + 4) = InRotator?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 12) = bInitial;

				*(bool*)(__InBuffer + 13) = bFixEulerFlips;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlPreferredRotatorByIndex, __InBuffer);
			}
		}

		/// <param name="InKey">
		/// The key of the element to retrieve the current value for
		/// </param>
		/// <param name="InRotator">
		/// The new preferred rotator to set
		/// </param>
		/// <param name="bInitial">
		/// If true we'll return the preferred rotator for the initial - otherwise current transform
		/// </param>
		/// <param name="bFixEulerFlips">
		/// If true the new rotator value will use the shortest path
		/// </param>
		public virtual void SetControlPreferredRotator(FRigElementKey InKey, FRotator InRotator, bool bInitial = false, bool bFixEulerFlips = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InRotator?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInitial;

				*(bool*)(__InBuffer + 17) = bFixEulerFlips;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlPreferredRotator, __InBuffer);
			}
		}

		/// <param name="InElementIndex">
		/// The element index to look up
		/// </param>
		/// <param name="InRotationOrder">
		/// The rotation order to use when setting the euler angles
		/// </param>
		public virtual void SetControlPreferredRotationOrderByIndex(int InElementIndex, EEulerRotationOrder InRotationOrder)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = InElementIndex;

				*(byte*)(__InBuffer + 4) = (byte)InRotationOrder;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlPreferredRotationOrderByIndex, __InBuffer);
			}
		}

		/// <param name="InKey">
		/// The key of the element to retrieve the current value for
		/// </param>
		/// <param name="InRotationOrder">
		/// The rotation order to use when setting the euler angles
		/// </param>
		public virtual void SetControlPreferredRotationOrder(FRigElementKey InKey, EEulerRotationOrder InRotationOrder)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InRotationOrder;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlPreferredRotationOrder, __InBuffer);
			}
		}

		/// <param name="InElementIndex">
		/// The element index to look up
		/// </param>
		/// <param name="InEulerAngles">
		/// The new preferred euler angles to set
		/// </param>
		/// <param name="InRotationOrder">
		/// The rotation order to use when setting the euler angles
		/// </param>
		/// <param name="bInitial">
		/// If true we'll return the preferred euler angles for the initial - otherwise current transform
		/// </param>
		/// <param name="bFixEulerFlips">
		/// If true the new euler angles value will use the shortest path
		/// </param>
		public virtual void SetControlPreferredEulerAnglesByIndex(int InElementIndex, FVector InEulerAngles, EEulerRotationOrder InRotationOrder, bool bInitial = false, bool bFixEulerFlips = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[15];

				*(int*)(__InBuffer) = InElementIndex;

				*(nint*)(__InBuffer + 4) = InEulerAngles?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 12) = (byte)InRotationOrder;

				*(bool*)(__InBuffer + 13) = bInitial;

				*(bool*)(__InBuffer + 14) = bFixEulerFlips;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlPreferredEulerAnglesByIndex, __InBuffer);
			}
		}

		/// <param name="InKey">
		/// The key of the element to retrieve the current value for
		/// </param>
		/// <param name="InEulerAngles">
		/// The new preferred euler angles to set
		/// </param>
		/// <param name="InRotationOrder">
		/// The rotation order to use when setting the euler angles
		/// </param>
		/// <param name="bInitial">
		/// If true we'll return the preferred euler angles for the initial - otherwise current transform
		/// </param>
		/// <param name="bFixEulerFlips">
		/// If true the new euler angles value will use the shortest path
		/// </param>
		public virtual void SetControlPreferredEulerAngles(FRigElementKey InKey, FVector InEulerAngles, EEulerRotationOrder InRotationOrder, bool bInitial = false, bool bFixEulerFlips = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InEulerAngles?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)InRotationOrder;

				*(bool*)(__InBuffer + 17) = bInitial;

				*(bool*)(__InBuffer + 18) = bFixEulerFlips;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlPreferredEulerAngles, __InBuffer);
			}
		}

		/// <param name="InElementIndex">
		/// The index of the control element to set the offset transform for
		/// </param>
		/// <param name="InTransform">
		/// The new local offset transform value to set
		/// </param>
		/// <param name="bInitial">
		/// If true the initial value will be used
		/// </param>
		/// <param name="bAffectChildren">
		/// If set to false children will not move (maintain global).
		/// </param>
		/// <param name="bSetupUndo">
		/// If true the transform stack will be setup for undo / redo
		/// </param>
		public virtual void SetControlOffsetTransformByIndex(int InElementIndex, FTransform InTransform, bool bInitial = false, bool bAffectChildren = true, bool bSetupUndo = false, bool bPrintPythonCommands = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = InElementIndex;

				*(nint*)(__InBuffer + 4) = InTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 12) = bInitial;

				*(bool*)(__InBuffer + 13) = bAffectChildren;

				*(bool*)(__InBuffer + 14) = bSetupUndo;

				*(bool*)(__InBuffer + 15) = bPrintPythonCommands;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlOffsetTransformByIndex, __InBuffer);
			}
		}

		/// <param name="InKey">
		/// The key of the control element to set the offset transform for
		/// </param>
		/// <param name="InTransform">
		/// The new offset transform value to set
		/// </param>
		/// <param name="bInitial">
		/// If true the initial value will be used
		/// </param>
		/// <param name="bAffectChildren">
		/// If set to false children will not move (maintain global).
		/// </param>
		/// <param name="bSetupUndo">
		/// If true the transform stack will be setup for undo / redo
		/// </param>
		public virtual void SetControlOffsetTransform(FRigElementKey InKey, FTransform InTransform, bool bInitial = false, bool bAffectChildren = true, bool bSetupUndo = false, bool bPrintPythonCommands = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInitial;

				*(bool*)(__InBuffer + 17) = bAffectChildren;

				*(bool*)(__InBuffer + 18) = bSetupUndo;

				*(bool*)(__InBuffer + 19) = bPrintPythonCommands;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlOffsetTransform, __InBuffer);
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetBoolMetadata(FRigElementKey InItem, FName InMetadataName, bool InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = InValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetBoolMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to set the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to set
		/// </param>
		/// <param name="InValue">
		/// The value to set
		/// </param>
		/// <returns>
		/// Returns true if setting the metadata was successful
		/// </returns>
		public virtual bool SetBoolArrayMetadata(FRigElementKey InItem, FName InMetadataName, TArray<bool> InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetBoolArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InElement">
		/// The element to send the autokey for
		/// </param>
		/// <param name="InOffsetInSeconds">
		/// The time offset in seconds
		/// </param>
		/// <param name="bAsynchronous">
		/// If set to true the event will go on a thread safe queue
		/// </param>
		public virtual void SendAutoKeyEvent(FRigElementKey InElement, float InOffsetInSeconds = 0.000000f, bool bAsynchronous = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = InElement?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InOffsetInSeconds;

				*(bool*)(__InBuffer + 12) = bAsynchronous;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SendAutoKeyEvent, __InBuffer);
			}
		}

		public virtual void ResetToDefault()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetToDefault);
			}
		}

		public virtual void ResetPoseToInitial(ERigElementType InTypeFilter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InTypeFilter;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ResetPoseToInitial, __InBuffer);
			}
		}

		public virtual void ResetCurveValues()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetCurveValues);
			}
		}

		public virtual void Reset()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Reset);
			}
		}

		/// <param name="InItem">
		/// The element key to search under
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to remove
		/// </param>
		public virtual bool RemoveMetadata(FRigElementKey InItem, FName InMetadataName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to search under
		/// </param>
		public virtual bool RemoveAllMetadata(FRigElementKey InItem)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveAllMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The number of elements in the Hierarchy
		/// </returns>
		public virtual int Num()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __Num, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="InValue">
		/// The value to create the rig control value from
		/// </param>
		/// <returns>
		/// The converted control rig val ue
		/// </returns>
		public static FRigControlValue MakeControlValueFromVector2D(FVector2D InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeControlValueFromVector2D, __InBuffer, __ReturnBuffer);

				return *(FRigControlValue*)__ReturnBuffer;
			}
		}

		/// <param name="InValue">
		/// The value to create the rig control value from
		/// </param>
		/// <returns>
		/// The converted control rig val ue
		/// </returns>
		public static FRigControlValue MakeControlValueFromVector(FVector InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeControlValueFromVector, __InBuffer, __ReturnBuffer);

				return *(FRigControlValue*)__ReturnBuffer;
			}
		}

		/// <param name="InValue">
		/// The value to create the rig control value from
		/// </param>
		/// <returns>
		/// The converted control rig val ue
		/// </returns>
		public static FRigControlValue MakeControlValueFromTransformNoScale(FTransformNoScale InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeControlValueFromTransformNoScale, __InBuffer, __ReturnBuffer);

				return *(FRigControlValue*)__ReturnBuffer;
			}
		}

		/// <param name="InValue">
		/// The value to create the rig control value from
		/// </param>
		/// <returns>
		/// The converted control rig val ue
		/// </returns>
		public static FRigControlValue MakeControlValueFromTransform(FTransform InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeControlValueFromTransform, __InBuffer, __ReturnBuffer);

				return *(FRigControlValue*)__ReturnBuffer;
			}
		}

		/// <param name="InValue">
		/// The value to create the rig control value from
		/// </param>
		/// <returns>
		/// The converted control rig val ue
		/// </returns>
		public static FRigControlValue MakeControlValueFromRotator(FRotator InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeControlValueFromRotator, __InBuffer, __ReturnBuffer);

				return *(FRigControlValue*)__ReturnBuffer;
			}
		}

		/// <param name="InValue">
		/// The value to create the rig control value from
		/// </param>
		/// <returns>
		/// The converted control rig val ue
		/// </returns>
		public static FRigControlValue MakeControlValueFromInt(int InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InValue;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeControlValueFromInt, __InBuffer, __ReturnBuffer);

				return *(FRigControlValue*)__ReturnBuffer;
			}
		}

		/// <param name="InValue">
		/// The value to create the rig control value from
		/// </param>
		/// <returns>
		/// The converted control rig val ue
		/// </returns>
		public static FRigControlValue MakeControlValueFromFloat(float InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InValue;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeControlValueFromFloat, __InBuffer, __ReturnBuffer);

				return *(FRigControlValue*)__ReturnBuffer;
			}
		}

		/// <param name="InValue">
		/// The value to create the rig control value from
		/// </param>
		/// <returns>
		/// The converted control rig val ue
		/// </returns>
		public static FRigControlValue MakeControlValueFromEulerTransform(FEulerTransform InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeControlValueFromEulerTransform, __InBuffer, __ReturnBuffer);

				return *(FRigControlValue*)__ReturnBuffer;
			}
		}

		/// <param name="InValue">
		/// The value to create the rig control value from
		/// </param>
		/// <returns>
		/// The converted control rig val ue
		/// </returns>
		public static FRigControlValue MakeControlValueFromBool(bool InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InValue;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeControlValueFromBool, __InBuffer, __ReturnBuffer);

				return *(FRigControlValue*)__ReturnBuffer;
			}
		}

		/// <param name="InElementIndex">
		/// The index to validate
		/// </param>
		/// <returns>
		/// Returns true if the provided element index is valid
		/// </returns>
		public virtual bool IsValidIndex(int InElementIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InElementIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsValidIndex, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InIndex">
		/// The index to check
		/// </param>
		/// <returns>
		/// true if a given element is selected
		/// </returns>
		public virtual bool IsSelectedByIndex(int InIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsSelectedByIndex, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key to check
		/// </param>
		/// <returns>
		/// true if a given element is selected
		/// </returns>
		public virtual bool IsSelected(FRigElementKey InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsSelected, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key to validate
		/// </param>
		/// <returns>
		/// Returns true if the element is procedural
		/// </returns>
		public virtual bool IsProcedural(FRigElementKey InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsProcedural, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InChild">
		/// The key of the child element to check for a parent
		/// </param>
		/// <param name="InParent">
		/// The key of the parent element to check for
		/// </param>
		/// <returns>
		/// True if the given parent and given child have a parent-child relationship
		/// </returns>
		public virtual bool IsParentedTo(FRigElementKey InChild, FRigElementKey InParent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InChild?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsParentedTo, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InElementIndex">
		/// The index of the element to retrieve the value for
		/// </param>
		/// <returns>
		/// Returns true if the value is set, false otherwise.
		/// </returns>
		public virtual bool IsCurveValueSetByIndex(int InElementIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InElementIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsCurveValueSetByIndex, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the element to retrieve the value for
		/// </param>
		/// <returns>
		/// Returns true if the value is set, false otherwise.
		/// </returns>
		public virtual bool IsCurveValueSet(FRigElementKey InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsCurveValueSet, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsControllerAvailable()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsControllerAvailable, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The item to return the tags for
		/// </param>
		/// <param name="InTag">
		/// The tag to check
		/// </param>
		public virtual bool HasTag(FRigElementKey InItem, FName InTag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTag?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasTag, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		/// <param name="DefaultValue">
		/// The default value to fall back on
		/// </param>
		public virtual FVector GetVectorMetadata(FRigElementKey InItem, FName InMetadataName, FVector DefaultValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVectorMetadata, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="InValue">
		/// The Rig Control value to convert from
		/// </param>
		/// <returns>
		/// The converted FVector value
		/// </returns>
		public static FVector GetVectorFromControlValue(FRigControlValue InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetVectorFromControlValue, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		public virtual TArray<FVector> GetVectorArrayMetadata(FRigElementKey InItem, FName InMetadataName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVectorArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(TArray<FVector>*)__ReturnBuffer;
			}
		}

		/// <param name="InValue">
		/// The Rig Control value to convert from
		/// </param>
		/// <returns>
		/// The converted FVector2D value
		/// </returns>
		public static FVector2D GetVector2DFromControlValue(FRigControlValue InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetVector2DFromControlValue, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		/// <param name="InValue">
		/// The Rig Control value to convert from
		/// </param>
		/// <returns>
		/// The converted FTransformNoScale value
		/// </returns>
		public static FTransformNoScale GetTransformNoScaleFromControlValue(FRigControlValue InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTransformNoScaleFromControlValue, __InBuffer, __ReturnBuffer);

				return *(FTransformNoScale*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		/// <param name="DefaultValue">
		/// The default value to fall back on
		/// </param>
		public virtual FTransform GetTransformMetadata(FRigElementKey InItem, FName InMetadataName, FTransform DefaultValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTransformMetadata, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="InValue">
		/// The Rig Control value to convert from
		/// </param>
		/// <returns>
		/// The converted FTransform value
		/// </returns>
		public static FTransform GetTransformFromControlValue(FRigControlValue InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTransformFromControlValue, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		public virtual TArray<FTransform> GetTransformArrayMetadata(FRigElementKey InItem, FName InMetadataName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTransformArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(TArray<FTransform>*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The item to return the tags for
		/// </param>
		public virtual TArray<FName> GetTags(FRigElementKey InItem)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTags, __InBuffer, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		/// <InTypeFilter>
		/// The types to retrieve the selection for
		/// </InTypeFilter>
		/// <returns>
		/// An array of the currently selected elements
		/// </returns>
		public virtual TArray<FRigElementKey> GetSelectedKeys(ERigElementType InTypeFilter = ERigElementType.All)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InTypeFilter;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSelectedKeys, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		/// <param name="DefaultValue">
		/// The default value to fall back on
		/// </param>
		public virtual FRotator GetRotatorMetadata(FRigElementKey InItem, FName InMetadataName, FRotator DefaultValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRotatorMetadata, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <param name="InValue">
		/// The Rig Control value to convert from
		/// </param>
		/// <returns>
		/// The converted FRotator value
		/// </returns>
		public static FRotator GetRotatorFromControlValue(FRigControlValue InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetRotatorFromControlValue, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		public virtual TArray<FRotator> GetRotatorArrayMetadata(FRigElementKey InItem, FName InMetadataName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRotatorArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(TArray<FRotator>*)__ReturnBuffer;
			}
		}

		public virtual TArray<FRigElementKey> GetRootElementKeys()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRootElementKeys, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="bTraverse">
		/// Returns the elements in order of a depth first traversal
		/// </param>
		public virtual TArray<FRigElementKey> GetRigidBodyKeys(bool bTraverse = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bTraverse;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRigidBodyKeys, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		/// <param name="DefaultValue">
		/// The default value to fall back on
		/// </param>
		public virtual FRigElementKey GetRigElementKeyMetadata(FRigElementKey InItem, FName InMetadataName, FRigElementKey DefaultValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRigElementKeyMetadata, __InBuffer, __ReturnBuffer);

				return *(FRigElementKey*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		public virtual TArray<FRigElementKey> GetRigElementKeyArrayMetadata(FRigElementKey InItem, FName InMetadataName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRigElementKeyArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="bTraverse">
		/// Returns the elements in order of a depth first traversal
		/// </param>
		public virtual TArray<FRigElementKey> GetReferenceKeys(bool bTraverse = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bTraverse;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetReferenceKeys, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		/// <param name="DefaultValue">
		/// The default value to fall back on
		/// </param>
		public virtual FQuat GetQuatMetadata(FRigElementKey InItem, FName InMetadataName, FQuat DefaultValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetQuatMetadata, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		public virtual TArray<FQuat> GetQuatArrayMetadata(FRigElementKey InItem, FName InMetadataName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetQuatArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(TArray<FQuat>*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the element to request the old parent  for
		/// </param>
		public virtual FRigElementKey GetPreviousParent(FRigElementKey InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetPreviousParent, __InBuffer, __ReturnBuffer);

				return *(FRigElementKey*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the element to request the old name for
		/// </param>
		public virtual FName GetPreviousName(FRigElementKey InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetPreviousName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		/// <param name="bInitial">
		/// If set to true the initial pose will be returned
		/// </param>
		/// <returns>
		/// The pose of the hierarchy
		/// </returns>
		public virtual FRigPose GetPose(bool bInitial = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInitial;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetPose, __InBuffer, __ReturnBuffer);

				return *(FRigPose*)__ReturnBuffer;
			}
		}

		/// <param name="InChild">
		/// The key of the multi parented element
		/// </param>
		/// <param name="bInitial">
		/// If true the initial weights will be used
		/// </param>
		/// <returns>
		/// Returns the weight of a parent below a multi parent element, or FLT_MAX if the parent is invalid
		/// </returns>
		public virtual TArray<FRigElementWeight> GetParentWeightArray(FRigElementKey InChild, bool bInitial = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InChild?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bInitial;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetParentWeightArray, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementWeight>*)__ReturnBuffer;
			}
		}

		/// <param name="InChild">
		/// The key of the multi parented element
		/// </param>
		/// <param name="InParent">
		/// The key of the parent to look up the weight for
		/// </param>
		/// <param name="bInitial">
		/// If true the initial weights will be used
		/// </param>
		/// <returns>
		/// Returns the weight of a parent below a multi parent element, or FLT_MAX if the parent is invalid
		/// </returns>
		public virtual FRigElementWeight GetParentWeight(FRigElementKey InChild, FRigElementKey InParent, bool bInitial = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InChild?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParent?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInitial;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetParentWeight, __InBuffer, __ReturnBuffer);

				return *(FRigElementWeight*)__ReturnBuffer;
			}
		}

		/// <param name="InElementIndex">
		/// The index of the element to retrieve the transform for
		/// </param>
		/// <param name="bInitial">
		/// If true the initial transform will be used
		/// </param>
		/// <returns>
		/// The element's parent's global current or initial transform's value.
		/// </returns>
		public virtual FTransform GetParentTransformByIndex(int InElementIndex, bool bInitial = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = InElementIndex;

				*(bool*)(__InBuffer + 4) = bInitial;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetParentTransformByIndex, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the element to retrieve the transform for
		/// </param>
		/// <param name="bInitial">
		/// If true the initial transform will be used
		/// </param>
		/// <returns>
		/// The element's parent's global current or initial transform's value.
		/// </returns>
		public virtual FTransform GetParentTransform(FRigElementKey InKey, bool bInitial = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bInitial;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetParentTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the element to retrieve the parents for
		/// </param>
		/// <param name="bRecursive">
		/// If set to true parents of parents will also be returned
		/// </param>
		/// <returns>
		/// Returns the parent elements
		/// </returns>
		public virtual TArray<FRigElementKey> GetParents(FRigElementKey InKey, bool bRecursive = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bRecursive;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetParents, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the element to retrieve the number of parents for
		/// </param>
		/// <returns>
		/// Returns the number of parents of an element
		/// </returns>
		public virtual int GetNumberOfParents(FRigElementKey InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumberOfParents, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="bTraverse">
		/// Returns the elements in order of a depth first traversal
		/// </param>
		public virtual TArray<FRigElementKey> GetNullKeys(bool bTraverse = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bTraverse;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetNullKeys, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		/// <param name="DefaultValue">
		/// The default value to fall back on
		/// </param>
		public virtual FName GetNameMetadata(FRigElementKey InItem, FName InMetadataName, FName DefaultValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetNameMetadata, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		public virtual TArray<FName> GetNameArrayMetadata(FRigElementKey InItem, FName InMetadataName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetNameArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata type for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to return the type for
		/// </param>
		public virtual ERigMetadataType GetMetadataType(FRigElementKey InItem, FName InMetadataName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetMetadataType, __InBuffer, __ReturnBuffer);

				return *(ERigMetadataType*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata keys for
		/// </param>
		public virtual TArray<FName> GetMetadataNames(FRigElementKey InItem)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetMetadataNames, __InBuffer, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		/// <param name="InElementIndex">
		/// The index to retrieve the transform for
		/// </param>
		/// <param name="bInitial">
		/// If true the initial transform will be used
		/// </param>
		/// <returns>
		/// The local current or initial transform's value.
		/// </returns>
		public virtual FTransform GetLocalTransformByIndex(int InElementIndex, bool bInitial = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = InElementIndex;

				*(bool*)(__InBuffer + 4) = bInitial;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLocalTransformByIndex, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key to retrieve the transform for
		/// </param>
		/// <param name="bInitial">
		/// If true the initial transform will be used
		/// </param>
		/// <returns>
		/// The local current or initial transform's value.
		/// </returns>
		public virtual FTransform GetLocalTransform(FRigElementKey InKey, bool bInitial = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bInitial;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLocalTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the element to retrieve the index for
		/// </param>
		/// <returns>
		/// The index of the element or INDEX_NONE
		/// </returns>
		public virtual int GetLocalIndex_ForBlueprint(FRigElementKey InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetLocalIndex_ForBlueprint, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="InElementIndex">
		/// The index of the control to retrieve the transform for
		/// </param>
		/// <param name="bInitial">
		/// If true the initial transform will be used
		/// </param>
		/// <returns>
		/// The local shape transform
		/// </returns>
		public virtual FTransform GetLocalControlShapeTransformByIndex(int InElementIndex, bool bInitial = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = InElementIndex;

				*(bool*)(__InBuffer + 4) = bInitial;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLocalControlShapeTransformByIndex, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the control to retrieve the transform for
		/// </param>
		/// <param name="bInitial">
		/// If true the initial transform will be used
		/// </param>
		/// <returns>
		/// The local shape transform
		/// </returns>
		public virtual FTransform GetLocalControlShapeTransform(FRigElementKey InKey, bool bInitial = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bInitial;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLocalControlShapeTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		/// <param name="DefaultValue">
		/// The default value to fall back on
		/// </param>
		public virtual FLinearColor GetLinearColorMetadata(FRigElementKey InItem, FName InMetadataName, FLinearColor DefaultValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLinearColorMetadata, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		public virtual TArray<FLinearColor> GetLinearColorArrayMetadata(FRigElementKey InItem, FName InMetadataName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLinearColorArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(TArray<FLinearColor>*)__ReturnBuffer;
			}
		}

		/// <param name="InElementIndices">
		/// The indices to retrieve the keys for
		/// </param>
		/// <returns>
		/// The keys of the elements given the indices
		/// </returns>
		public virtual TArray<FRigElementKey> GetKeys(TArray<int> InElementIndices)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InElementIndices?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetKeys, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="InElementIndex">
		/// The index of the element to retrieve the key for
		/// </param>
		/// <returns>
		/// The key of an element given its index
		/// </returns>
		public virtual FRigElementKey GetKey(int InElementIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InElementIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetKey, __InBuffer, __ReturnBuffer);

				return *(FRigElementKey*)__ReturnBuffer;
			}
		}

		/// <param name="InValue">
		/// The Rig Control value to convert from
		/// </param>
		/// <returns>
		/// The converted int32 value
		/// </returns>
		public static int GetIntFromControlValue(FRigControlValue InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetIntFromControlValue, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		/// <param name="DefaultValue">
		/// The default value to fall back on
		/// </param>
		public virtual int GetInt32Metadata(FRigElementKey InItem, FName InMetadataName, int DefaultValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = DefaultValue;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInt32Metadata, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		public virtual TArray<int> GetInt32ArrayMetadata(FRigElementKey InItem, FName InMetadataName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetInt32ArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(TArray<int>*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the element to retrieve the index for
		/// </param>
		/// <returns>
		/// The index of the element or INDEX_NONE
		/// </returns>
		public virtual int GetIndex_ForBlueprint(FRigElementKey InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetIndex_ForBlueprint, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="InElementIndex">
		/// The index to retrieve the transform for
		/// </param>
		/// <param name="bInitial">
		/// If true the initial transform will be used
		/// </param>
		/// <returns>
		/// The global current or initial transform's value.
		/// </returns>
		public virtual FTransform GetGlobalTransformByIndex(int InElementIndex, bool bInitial = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = InElementIndex;

				*(bool*)(__InBuffer + 4) = bInitial;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetGlobalTransformByIndex, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key to retrieve the transform for
		/// </param>
		/// <param name="bInitial">
		/// If true the initial transform will be used
		/// </param>
		/// <returns>
		/// The global current or initial transform's value.
		/// </returns>
		public virtual FTransform GetGlobalTransform(FRigElementKey InKey, bool bInitial = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bInitial;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetGlobalTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="InElementIndex">
		/// The index of the control to retrieve the transform for
		/// </param>
		/// <param name="bInitial">
		/// If true the initial transform will be used
		/// </param>
		/// <returns>
		/// The global shape transform
		/// </returns>
		public virtual FTransform GetGlobalControlShapeTransformByIndex(int InElementIndex, bool bInitial = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = InElementIndex;

				*(bool*)(__InBuffer + 4) = bInitial;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetGlobalControlShapeTransformByIndex, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the control to retrieve the transform for
		/// </param>
		/// <param name="bInitial">
		/// If true the initial transform will be used
		/// </param>
		/// <returns>
		/// The global shape transform
		/// </returns>
		public virtual FTransform GetGlobalControlShapeTransform(FRigElementKey InKey, bool bInitial = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bInitial;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetGlobalControlShapeTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="InElementIndex">
		/// The index of the control to retrieve the transform for
		/// </param>
		/// <param name="bInitial">
		/// If true the initial transform will be used
		/// </param>
		/// <returns>
		/// The global offset transform
		/// </returns>
		public virtual FTransform GetGlobalControlOffsetTransformByIndex(int InElementIndex, bool bInitial = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = InElementIndex;

				*(bool*)(__InBuffer + 4) = bInitial;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetGlobalControlOffsetTransformByIndex, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the control to retrieve the transform for
		/// </param>
		/// <param name="bInitial">
		/// If true the initial transform will be used
		/// </param>
		/// <returns>
		/// The global offset transform
		/// </returns>
		public virtual FTransform GetGlobalControlOffsetTransform(FRigElementKey InKey, bool bInitial = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bInitial;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetGlobalControlOffsetTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		/// <param name="DefaultValue">
		/// The default value to fall back on
		/// </param>
		public virtual float GetFloatMetadata(FRigElementKey InItem, FName InMetadataName, float DefaultValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = DefaultValue;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetFloatMetadata, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="InValue">
		/// The Rig Control value to convert from
		/// </param>
		/// <returns>
		/// The converted float value
		/// </returns>
		public static float GetFloatFromControlValue(FRigControlValue InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetFloatFromControlValue, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		public virtual TArray<float> GetFloatArrayMetadata(FRigElementKey InItem, FName InMetadataName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetFloatArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(TArray<float>*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the element to retrieve the parents for
		/// </param>
		/// <returns>
		/// Returns the first parent element
		/// </returns>
		public virtual FRigElementKey GetFirstParent(FRigElementKey InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetFirstParent, __InBuffer, __ReturnBuffer);

				return *(FRigElementKey*)__ReturnBuffer;
			}
		}

		/// <param name="InValue">
		/// The Rig Control value to convert from
		/// </param>
		/// <returns>
		/// The converted FEulerTransform value
		/// </returns>
		public static FEulerTransform GetEulerTransformFromControlValue(FRigControlValue InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetEulerTransformFromControlValue, __InBuffer, __ReturnBuffer);

				return *(FEulerTransform*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the element to retrieve the parent for
		/// </param>
		/// <returns>
		/// Returns the default parent element key
		/// </returns>
		public virtual FRigElementKey GetDefaultParent(FRigElementKey InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDefaultParent, __InBuffer, __ReturnBuffer);

				return *(FRigElementKey*)__ReturnBuffer;
			}
		}

		/// <param name="InElementIndex">
		/// The index of the element to retrieve the value for
		/// </param>
		/// <returns>
		/// Returns the value of the curve
		/// </returns>
		public virtual float GetCurveValueByIndex(int InElementIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InElementIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetCurveValueByIndex, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the element to retrieve the value for
		/// </param>
		/// <returns>
		/// Returns the value of the curve
		/// </returns>
		public virtual float GetCurveValue(FRigElementKey InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetCurveValue, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual TArray<FRigElementKey> GetCurveKeys()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCurveKeys, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="InElementIndex">
		/// The index of the element to retrieve the current value for
		/// </param>
		/// <param name="InValueType">
		/// The type of value to return
		/// </param>
		/// <returns>
		/// Returns the current value of the control
		/// </returns>
		public virtual FRigControlValue GetControlValueByIndex(int InElementIndex, ERigControlValueType InValueType = ERigControlValueType.Current)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = InElementIndex;

				*(byte*)(__InBuffer + 4) = (byte)InValueType;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetControlValueByIndex, __InBuffer, __ReturnBuffer);

				return *(FRigControlValue*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the element to retrieve the current value for
		/// </param>
		/// <param name="InValueType">
		/// The type of value to return
		/// </param>
		/// <returns>
		/// Returns the current value of the control
		/// </returns>
		public virtual FRigControlValue GetControlValue(FRigElementKey InKey, ERigControlValueType InValueType = ERigControlValueType.Current)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InValueType;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetControlValue, __InBuffer, __ReturnBuffer);

				return *(FRigControlValue*)__ReturnBuffer;
			}
		}

		/// <param name="InElementIndex">
		/// The element index to look up
		/// </param>
		/// <param name="bInitial">
		/// If true we'll return the preferred rotator for the initial - otherwise current transform
		/// </param>
		/// <returns>
		/// Returns the current preferred rotator
		/// </returns>
		public virtual FRotator GetControlPreferredRotatorByIndex(int InElementIndex, bool bInitial = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = InElementIndex;

				*(bool*)(__InBuffer + 4) = bInitial;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetControlPreferredRotatorByIndex, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the element to retrieve the current value for
		/// </param>
		/// <param name="bInitial">
		/// If true we'll return the preferred rotator for the initial - otherwise current transform
		/// </param>
		/// <returns>
		/// Returns the current preferred rotator
		/// </returns>
		public virtual FRotator GetControlPreferredRotator(FRigElementKey InKey, bool bInitial = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bInitial;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetControlPreferredRotator, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <param name="InElementIndex">
		/// The element index to look up
		/// </param>
		/// <param name="bFromSettings">
		/// If true the rotation order will be looked up from the control's settings, otherwise from the currently set animation value
		/// </param>
		/// <returns>
		/// Returns the current preferred euler rotation order
		/// </returns>
		public virtual EEulerRotationOrder GetControlPreferredEulerRotationOrderByIndex(int InElementIndex, bool bFromSettings = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = InElementIndex;

				*(bool*)(__InBuffer + 4) = bFromSettings;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetControlPreferredEulerRotationOrderByIndex, __InBuffer, __ReturnBuffer);

				return *(EEulerRotationOrder*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the element to retrieve the current value for
		/// </param>
		/// <param name="bFromSettings">
		/// If true the rotation order will be looked up from the control's settings, otherwise from the currently set animation value
		/// </param>
		/// <returns>
		/// Returns the current preferred euler rotation order
		/// </returns>
		public virtual EEulerRotationOrder GetControlPreferredEulerRotationOrder(FRigElementKey InKey, bool bFromSettings = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bFromSettings;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetControlPreferredEulerRotationOrder, __InBuffer, __ReturnBuffer);

				return *(EEulerRotationOrder*)__ReturnBuffer;
			}
		}

		/// <param name="InElementIndex">
		/// The element index to look up
		/// </param>
		/// <param name="InRotationOrder">
		/// The rotation order to use when retrieving the euler angles
		/// </param>
		/// <param name="bInitial">
		/// If true we'll return the preferred euler angles for the initial - otherwise current transform
		/// </param>
		/// <returns>
		/// Returns the current preferred euler angles
		/// </returns>
		public virtual FVector GetControlPreferredEulerAnglesByIndex(int InElementIndex, EEulerRotationOrder InRotationOrder, bool bInitial = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[6];

				*(int*)(__InBuffer) = InElementIndex;

				*(byte*)(__InBuffer + 4) = (byte)InRotationOrder;

				*(bool*)(__InBuffer + 5) = bInitial;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetControlPreferredEulerAnglesByIndex, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the element to retrieve the current value for
		/// </param>
		/// <param name="InRotationOrder">
		/// The rotation order to use when retrieving the euler angles
		/// </param>
		/// <param name="bInitial">
		/// If true we'll return the preferred euler angles for the initial - otherwise current transform
		/// </param>
		/// <returns>
		/// Returns the current preferred euler angles
		/// </returns>
		public virtual FVector GetControlPreferredEulerAngles(FRigElementKey InKey, EEulerRotationOrder InRotationOrder, bool bInitial = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InRotationOrder;

				*(bool*)(__InBuffer + 9) = bInitial;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetControlPreferredEulerAngles, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="bCreateIfNeeded">
		/// Creates a controller if needed
		/// </param>
		/// <returns>
		/// The Controller for this hierarchy
		/// </returns>
		public virtual URigHierarchyController GetController(bool bCreateIfNeeded = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bCreateIfNeeded;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetController, __InBuffer, __ReturnBuffer);

				return *(URigHierarchyController*)__ReturnBuffer;
			}
		}

		/// <param name="bTraverse">
		/// Returns the elements in order of a depth first traversal
		/// </param>
		public virtual TArray<FRigElementKey> GetControlKeys(bool bTraverse = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bTraverse;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetControlKeys, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the element to retrieve the children for
		/// </param>
		/// <param name="bRecursive">
		/// If set to true grand-children will also be returned etc
		/// </param>
		/// <returns>
		/// Returns the child elements
		/// </returns>
		public virtual TArray<FRigElementKey> GetChildren(FRigElementKey InKey, bool bRecursive = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bRecursive;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetChildren, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		/// <param name="DefaultValue">
		/// The default value to fall back on
		/// </param>
		public virtual bool GetBoolMetadata(FRigElementKey InItem, FName InMetadataName, bool DefaultValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = DefaultValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetBoolMetadata, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InItem">
		/// The element key to return the metadata for
		/// </param>
		/// <param name="InMetadataName">
		/// The name of the metadata to query
		/// </param>
		public virtual TArray<bool> GetBoolArrayMetadata(FRigElementKey InItem, FName InMetadataName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InItem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMetadataName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoolArrayMetadata, __InBuffer, __ReturnBuffer);

				return *(TArray<bool>*)__ReturnBuffer;
			}
		}

		/// <param name="bTraverse">
		/// Returns the elements in order of a depth first traversal
		/// </param>
		public virtual TArray<FRigElementKey> GetBoneKeys(bool bTraverse = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bTraverse;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoneKeys, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="bTraverse">
		/// If set to true the keys will be returned by depth first traversal
		/// </param>
		/// <returns>
		/// The keys of all elements
		/// </returns>
		public virtual TArray<FRigElementKey> GetAllKeys_ForBlueprint(bool bTraverse = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bTraverse;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetAllKeys_ForBlueprint, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the null element to retrieve. 
		/// </param>
		public virtual FRigNullElement FindNull_ForBlueprintOnly(FRigElementKey InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindNull_ForBlueprintOnly, __InBuffer, __ReturnBuffer);

				return *(FRigNullElement*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the control element to retrieve. 
		/// </param>
		public virtual FRigControlElement FindControl_ForBlueprintOnly(FRigElementKey InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindControl_ForBlueprintOnly, __InBuffer, __ReturnBuffer);

				return *(FRigControlElement*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the bone element to retrieve. 
		/// </param>
		public virtual FRigBoneElement FindBone_ForBlueprintOnly(FRigElementKey InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindBone_ForBlueprintOnly, __InBuffer, __ReturnBuffer);

				return *(FRigBoneElement*)__ReturnBuffer;
			}
		}

		public virtual void CopyPose(URigHierarchy InHierarchy, bool bCurrent, bool bInitial, bool bWeights, bool bMatchPoseInGlobalIfNeeded = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InHierarchy?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bCurrent;

				*(bool*)(__InBuffer + 9) = bInitial;

				*(bool*)(__InBuffer + 10) = bWeights;

				*(bool*)(__InBuffer + 11) = bMatchPoseInGlobalIfNeeded;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CopyPose, __InBuffer);
			}
		}

		public virtual void CopyHierarchy(URigHierarchy InHierarchy)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InHierarchy?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CopyHierarchy, __InBuffer);
			}
		}

		/// <param name="InKey">
		/// The key to validate
		/// </param>
		/// <returns>
		/// Returns true if the provided element key is valid
		/// </returns>
		public virtual bool Contains_ForBlueprint(FRigElementKey InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Contains_ForBlueprint, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __ModifiedEventDynamic = 0;

		private static uint __TopologyVersion = 0;

		private static uint __MetadataVersion = 0;

		private static uint __MetadataTagVersion = 0;

		private static uint __bEnableDirtyPropagation = 0;

		private static uint __TransformStackIndex = 0;

		private static uint __HierarchyController = 0;

		private static uint __PreviousNameMap = 0;

		private static uint __HierarchyForCacheValidation = 0;

		private static uint __UnsetCurveValueByIndex = 0;

		private static uint __UnsetCurveValue = 0;

		private static uint __SwitchToWorldSpace = 0;

		private static uint __SwitchToParent = 0;

		private static uint __SwitchToDefaultParent = 0;

		private static uint __SortKeys = 0;

		private static uint __SetVectorMetadata = 0;

		private static uint __SetVectorArrayMetadata = 0;

		private static uint __SetTransformMetadata = 0;

		private static uint __SetTransformArrayMetadata = 0;

		private static uint __SetTag = 0;

		private static uint __SetRotatorMetadata = 0;

		private static uint __SetRotatorArrayMetadata = 0;

		private static uint __SetRigElementKeyMetadata = 0;

		private static uint __SetRigElementKeyArrayMetadata = 0;

		private static uint __SetQuatMetadata = 0;

		private static uint __SetQuatArrayMetadata = 0;

		private static uint __SetPose_ForBlueprint = 0;

		private static uint __SetParentWeightArray = 0;

		private static uint __SetParentWeight = 0;

		private static uint __SetNameMetadata = 0;

		private static uint __SetNameArrayMetadata = 0;

		private static uint __SetLocalTransformByIndex = 0;

		private static uint __SetLocalTransform = 0;

		private static uint __SetLinearColorMetadata = 0;

		private static uint __SetLinearColorArrayMetadata = 0;

		private static uint __SetInt32Metadata = 0;

		private static uint __SetInt32ArrayMetadata = 0;

		private static uint __SetGlobalTransformByIndex = 0;

		private static uint __SetGlobalTransform = 0;

		private static uint __SetFloatMetadata = 0;

		private static uint __SetFloatArrayMetadata = 0;

		private static uint __SetCurveValueByIndex = 0;

		private static uint __SetCurveValue = 0;

		private static uint __SetControlVisibilityByIndex = 0;

		private static uint __SetControlVisibility = 0;

		private static uint __SetControlValueByIndex = 0;

		private static uint __SetControlValue = 0;

		private static uint __SetControlShapeTransformByIndex = 0;

		private static uint __SetControlShapeTransform = 0;

		private static uint __SetControlSettingsByIndex = 0;

		private static uint __SetControlSettings = 0;

		private static uint __SetControlPreferredRotatorByIndex = 0;

		private static uint __SetControlPreferredRotator = 0;

		private static uint __SetControlPreferredRotationOrderByIndex = 0;

		private static uint __SetControlPreferredRotationOrder = 0;

		private static uint __SetControlPreferredEulerAnglesByIndex = 0;

		private static uint __SetControlPreferredEulerAngles = 0;

		private static uint __SetControlOffsetTransformByIndex = 0;

		private static uint __SetControlOffsetTransform = 0;

		private static uint __SetBoolMetadata = 0;

		private static uint __SetBoolArrayMetadata = 0;

		private static uint __SendAutoKeyEvent = 0;

		private static uint __ResetToDefault = 0;

		private static uint __ResetPoseToInitial = 0;

		private static uint __ResetCurveValues = 0;

		private static uint __Reset = 0;

		private static uint __RemoveMetadata = 0;

		private static uint __RemoveAllMetadata = 0;

		private static uint __Num = 0;

		private static uint __MakeControlValueFromVector2D = 0;

		private static uint __MakeControlValueFromVector = 0;

		private static uint __MakeControlValueFromTransformNoScale = 0;

		private static uint __MakeControlValueFromTransform = 0;

		private static uint __MakeControlValueFromRotator = 0;

		private static uint __MakeControlValueFromInt = 0;

		private static uint __MakeControlValueFromFloat = 0;

		private static uint __MakeControlValueFromEulerTransform = 0;

		private static uint __MakeControlValueFromBool = 0;

		private static uint __IsValidIndex = 0;

		private static uint __IsSelectedByIndex = 0;

		private static uint __IsSelected = 0;

		private static uint __IsProcedural = 0;

		private static uint __IsParentedTo = 0;

		private static uint __IsCurveValueSetByIndex = 0;

		private static uint __IsCurveValueSet = 0;

		private static uint __IsControllerAvailable = 0;

		private static uint __HasTag = 0;

		private static uint __GetVectorMetadata = 0;

		private static uint __GetVectorFromControlValue = 0;

		private static uint __GetVectorArrayMetadata = 0;

		private static uint __GetVector2DFromControlValue = 0;

		private static uint __GetTransformNoScaleFromControlValue = 0;

		private static uint __GetTransformMetadata = 0;

		private static uint __GetTransformFromControlValue = 0;

		private static uint __GetTransformArrayMetadata = 0;

		private static uint __GetTags = 0;

		private static uint __GetSelectedKeys = 0;

		private static uint __GetRotatorMetadata = 0;

		private static uint __GetRotatorFromControlValue = 0;

		private static uint __GetRotatorArrayMetadata = 0;

		private static uint __GetRootElementKeys = 0;

		private static uint __GetRigidBodyKeys = 0;

		private static uint __GetRigElementKeyMetadata = 0;

		private static uint __GetRigElementKeyArrayMetadata = 0;

		private static uint __GetReferenceKeys = 0;

		private static uint __GetQuatMetadata = 0;

		private static uint __GetQuatArrayMetadata = 0;

		private static uint __GetPreviousParent = 0;

		private static uint __GetPreviousName = 0;

		private static uint __GetPose = 0;

		private static uint __GetParentWeightArray = 0;

		private static uint __GetParentWeight = 0;

		private static uint __GetParentTransformByIndex = 0;

		private static uint __GetParentTransform = 0;

		private static uint __GetParents = 0;

		private static uint __GetNumberOfParents = 0;

		private static uint __GetNullKeys = 0;

		private static uint __GetNameMetadata = 0;

		private static uint __GetNameArrayMetadata = 0;

		private static uint __GetMetadataType = 0;

		private static uint __GetMetadataNames = 0;

		private static uint __GetLocalTransformByIndex = 0;

		private static uint __GetLocalTransform = 0;

		private static uint __GetLocalIndex_ForBlueprint = 0;

		private static uint __GetLocalControlShapeTransformByIndex = 0;

		private static uint __GetLocalControlShapeTransform = 0;

		private static uint __GetLinearColorMetadata = 0;

		private static uint __GetLinearColorArrayMetadata = 0;

		private static uint __GetKeys = 0;

		private static uint __GetKey = 0;

		private static uint __GetIntFromControlValue = 0;

		private static uint __GetInt32Metadata = 0;

		private static uint __GetInt32ArrayMetadata = 0;

		private static uint __GetIndex_ForBlueprint = 0;

		private static uint __GetGlobalTransformByIndex = 0;

		private static uint __GetGlobalTransform = 0;

		private static uint __GetGlobalControlShapeTransformByIndex = 0;

		private static uint __GetGlobalControlShapeTransform = 0;

		private static uint __GetGlobalControlOffsetTransformByIndex = 0;

		private static uint __GetGlobalControlOffsetTransform = 0;

		private static uint __GetFloatMetadata = 0;

		private static uint __GetFloatFromControlValue = 0;

		private static uint __GetFloatArrayMetadata = 0;

		private static uint __GetFirstParent = 0;

		private static uint __GetEulerTransformFromControlValue = 0;

		private static uint __GetDefaultParent = 0;

		private static uint __GetCurveValueByIndex = 0;

		private static uint __GetCurveValue = 0;

		private static uint __GetCurveKeys = 0;

		private static uint __GetControlValueByIndex = 0;

		private static uint __GetControlValue = 0;

		private static uint __GetControlPreferredRotatorByIndex = 0;

		private static uint __GetControlPreferredRotator = 0;

		private static uint __GetControlPreferredEulerRotationOrderByIndex = 0;

		private static uint __GetControlPreferredEulerRotationOrder = 0;

		private static uint __GetControlPreferredEulerAnglesByIndex = 0;

		private static uint __GetControlPreferredEulerAngles = 0;

		private static uint __GetController = 0;

		private static uint __GetControlKeys = 0;

		private static uint __GetChildren = 0;

		private static uint __GetBoolMetadata = 0;

		private static uint __GetBoolArrayMetadata = 0;

		private static uint __GetBoneKeys = 0;

		private static uint __GetAllKeys_ForBlueprint = 0;

		private static uint __FindNull_ForBlueprintOnly = 0;

		private static uint __FindControl_ForBlueprintOnly = 0;

		private static uint __FindBone_ForBlueprintOnly = 0;

		private static uint __CopyPose = 0;

		private static uint __CopyHierarchy = 0;

		private static uint __Contains_ForBlueprint = 0;
	}
}