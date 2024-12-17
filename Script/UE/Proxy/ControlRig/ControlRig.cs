using Script.CoreUObject;
using Script.RigVM;
using Script.Engine;
using Script.Library;
using Script.AnimationCore;
using Script.ControlRig.ControlRig;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRig")]
	public partial class UControlRig : URigVMHost, IStaticClass, INodeMappingProviderInterface
	{
		public ERigExecutionType ExecutionType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExecutionType, __ReturnBuffer);

					return *(ERigExecutionType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExecutionType, __InBuffer);
				}
			}
		}

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

		public TMap<FRigElementKey, FRigControlElementCustomization> ControlCustomizations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ControlCustomizations, __ReturnBuffer);

					return *(TMap<FRigElementKey, FRigControlElementCustomization>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ControlCustomizations, __InBuffer);
				}
			}
		}

		public URigHierarchy DynamicHierarchy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DynamicHierarchy, __ReturnBuffer);

					return *(URigHierarchy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DynamicHierarchy, __InBuffer);
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

		public TMap<FString, FString> ShapeLibraryNameMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShapeLibraryNameMap, __ReturnBuffer);

					return *(TMap<FString, FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShapeLibraryNameMap, __InBuffer);
				}
			}
		}

		public UAnimationDataSourceRegistry DataSourceRegistry
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataSourceRegistry, __ReturnBuffer);

					return *(UAnimationDataSourceRegistry*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataSourceRegistry, __InBuffer);
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

		public UControlRig InteractionRig
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InteractionRig, __ReturnBuffer);

					return *(UControlRig*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InteractionRig, __InBuffer);
				}
			}
		}

		public TSubclassOf<UControlRig> InteractionRigClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InteractionRigClass, __ReturnBuffer);

					return *(TSubclassOf<UControlRig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InteractionRigClass, __InBuffer);
				}
			}
		}

		public FOnControlSelectedBP OnControlSelected_BP
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnControlSelected_BP, __ReturnBuffer);

					return *(FOnControlSelectedBP*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnControlSelected_BP, __InBuffer);
				}
			}
		}

		public bool bControlsVisible
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bControlsVisible, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bControlsVisible, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRig.ControlRig");
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

		public virtual void SetInteractionRigClass(TSubclassOf<UControlRig> InInteractionRigClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InInteractionRigClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetInteractionRigClass, __InBuffer);
			}
		}

		public virtual void SetInteractionRig(UControlRig InInteractionRig)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InInteractionRig?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetInteractionRig, __InBuffer);
			}
		}

		public virtual void SelectControl(FName InControlName, bool bSelect = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSelect;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SelectControl, __InBuffer);
			}
		}

		public virtual void RequestConstruction()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RequestConstruction);
			}
		}

		public virtual bool IsControlSelected(FName InControlName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InControlName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsControlSelected, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TSubclassOf<UControlRig> GetInteractionRigClass()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetInteractionRigClass, __ReturnBuffer);

				return *(TSubclassOf<UControlRig>*)__ReturnBuffer;
			}
		}

		public virtual UControlRig GetInteractionRig()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetInteractionRig, __ReturnBuffer);

				return *(UControlRig*)__ReturnBuffer;
			}
		}

		public virtual AActor GetHostingActor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetHostingActor, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public virtual URigHierarchy GetHierarchy()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetHierarchy, __ReturnBuffer);

				return *(URigHierarchy*)__ReturnBuffer;
			}
		}

		public static TArray<UControlRig> FindControlRigs(UObject Outer, TSubclassOf<UControlRig> OptionalClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Outer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OptionalClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindControlRigs, __InBuffer, __ReturnBuffer);

				return *(TArray<UControlRig>*)__ReturnBuffer;
			}
		}

		public virtual TArray<FName> CurrentControlSelection()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __CurrentControlSelection, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		public virtual UTransformableControlHandle CreateTransformableControlHandle(UObject Outer, FName ControlName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Outer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateTransformableControlHandle, __InBuffer, __ReturnBuffer);

				return *(UTransformableControlHandle*)__ReturnBuffer;
			}
		}

		public virtual bool ClearControlSelection()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __ClearControlSelection, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __ExecutionType = 0;

		private static uint __HierarchySettings = 0;

		private static uint __ControlCustomizations = 0;

		private static uint __DynamicHierarchy = 0;

		private static uint __ShapeLibraries = 0;

		private static uint __ShapeLibraryNameMap = 0;

		private static uint __DataSourceRegistry = 0;

		private static uint __Influences = 0;

		private static uint __InteractionRig = 0;

		private static uint __InteractionRigClass = 0;

		private static uint __OnControlSelected_BP = 0;

		private static uint __bControlsVisible = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SetInteractionRigClass = 0;

		private static uint __SetInteractionRig = 0;

		private static uint __SelectControl = 0;

		private static uint __RequestConstruction = 0;

		private static uint __IsControlSelected = 0;

		private static uint __GetInteractionRigClass = 0;

		private static uint __GetInteractionRig = 0;

		private static uint __GetHostingActor = 0;

		private static uint __GetHierarchy = 0;

		private static uint __FindControlRigs = 0;

		private static uint __CurrentControlSelection = 0;

		private static uint __CreateTransformableControlHandle = 0;

		private static uint __ClearControlSelection = 0;
	}
}