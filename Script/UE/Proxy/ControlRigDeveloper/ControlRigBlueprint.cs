using Script.CoreUObject;
using Script.RigVMDeveloper;
using Script.Engine;
using Script.ControlRig;
using Script.RigVM;
using Script.Library;

namespace Script.ControlRigDeveloper
{
	[PathName("/Script/ControlRigDeveloper.ControlRigBlueprint")]
	public partial class UControlRigBlueprint : URigVMBlueprint, IStaticClass, IInterface_PreviewMeshProvider
	{
		public FRigHierarchySettings HierarchySettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HierarchySettings, __ReturnBuffer);

					return *(FRigHierarchySettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HierarchySettings, __InBuffer);
				}
			}
		}

		public TArray<TSoftObjectPtr<UControlRigShapeLibrary>> ShapeLibraries
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShapeLibraries, __ReturnBuffer);

					return *(TArray<TSoftObjectPtr<UControlRigShapeLibrary>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShapeLibraries, __InBuffer);
				}
			}
		}

		public FRigVMDrawContainer DrawContainer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DrawContainer, __ReturnBuffer);

					return *(FRigVMDrawContainer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DrawContainer, __InBuffer);
				}
			}
		}

		public FRigInfluenceMapPerEvent Influences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Influences, __ReturnBuffer);

					return *(FRigInfluenceMapPerEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Influences, __InBuffer);
				}
			}
		}

		public URigHierarchy Hierarchy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Hierarchy, __ReturnBuffer);

					return *(URigHierarchy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Hierarchy, __InBuffer);
				}
			}
		}

		public bool bSupportsInversion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportsInversion, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportsInversion, __InBuffer);
				}
			}
		}

		public bool bSupportsControls
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportsControls, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportsControls, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewSkeletalMesh, __ReturnBuffer);

					return *(TSoftObjectPtr<USkeletalMesh>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewSkeletalMesh, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UObject> SourceHierarchyImport
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceHierarchyImport, __ReturnBuffer);

					return *(TSoftObjectPtr<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceHierarchyImport, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UObject> SourceCurveImport
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceCurveImport, __ReturnBuffer);

					return *(TSoftObjectPtr<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceCurveImport, __InBuffer);
				}
			}
		}

		public bool bExposesAnimatableControls
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bExposesAnimatableControls, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bExposesAnimatableControls, __InBuffer);
				}
			}
		}

		public UControlRigValidator Validator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Validator, __ReturnBuffer);

					return *(UControlRigValidator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Validator, __InBuffer);
				}
			}
		}

		public float DebugBoneRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DebugBoneRadius, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DebugBoneRadius, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigDeveloper.ControlRigBlueprint");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		public virtual void SetPreviewMesh(USkeletalMesh PreviewMesh, bool bMarkAsDirty = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = PreviewMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bMarkAsDirty;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPreviewMesh, __InBuffer);
			}
		}

		public virtual USkeletalMesh GetPreviewMesh()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPreviewMesh, __ReturnBuffer);

				return *(USkeletalMesh*)__ReturnBuffer;
			}
		}

		public virtual URigHierarchyController GetHierarchyController()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetHierarchyController, __ReturnBuffer);

				return *(URigHierarchyController*)__ReturnBuffer;
			}
		}

		public static TArray<UControlRigBlueprint> GetCurrentlyOpenRigBlueprints()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentlyOpenRigBlueprints, __ReturnBuffer);

				return *(TArray<UControlRigBlueprint>*)__ReturnBuffer;
			}
		}

		public virtual UClass GetControlRigClass()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetControlRigClass, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		public virtual UControlRig CreateControlRig()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __CreateControlRig, __ReturnBuffer);

				return *(UControlRig*)__ReturnBuffer;
			}
		}

		private static uint __HierarchySettings = 0;

		private static uint __ShapeLibraries = 0;

		private static uint __DrawContainer = 0;

		private static uint __Influences = 0;

		private static uint __Hierarchy = 0;

		private static uint __bSupportsInversion = 0;

		private static uint __bSupportsControls = 0;

		private static uint __PreviewSkeletalMesh = 0;

		private static uint __SourceHierarchyImport = 0;

		private static uint __SourceCurveImport = 0;

		private static uint __bExposesAnimatableControls = 0;

		private static uint __Validator = 0;

		private static uint __DebugBoneRadius = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SetPreviewMesh = 0;

		private static uint __GetPreviewMesh = 0;

		private static uint __GetHierarchyController = 0;

		private static uint __GetCurrentlyOpenRigBlueprints = 0;

		private static uint __GetControlRigClass = 0;

		private static uint __CreateControlRig = 0;
	}
}