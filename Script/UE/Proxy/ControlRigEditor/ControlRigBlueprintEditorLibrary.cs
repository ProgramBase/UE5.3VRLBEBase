using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.ControlRigDeveloper;
using Script.RigVMDeveloper;
using Script.ControlRig;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary")]
	public partial class UControlRigBlueprintEditorLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigEditor.ControlRigBlueprintEditorLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetupAllEditorMenus()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __SetupAllEditorMenus);
			}
		}

		public static void SetPreviewMesh(UControlRigBlueprint InRigBlueprint, USkeletalMesh PreviewMesh, bool bMarkAsDirty = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InRigBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PreviewMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bMarkAsDirty;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetPreviewMesh, __InBuffer);
			}
		}

		public static void RequestControlRigInit(UControlRigBlueprint InRigBlueprint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InRigBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RequestControlRigInit, __InBuffer);
			}
		}

		public static void RequestAutoVMRecompilation(UControlRigBlueprint InRigBlueprint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InRigBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RequestAutoVMRecompilation, __InBuffer);
			}
		}

		public static void RecompileVMIfRequired(UControlRigBlueprint InRigBlueprint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InRigBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RecompileVMIfRequired, __InBuffer);
			}
		}

		public static void RecompileVM(UControlRigBlueprint InRigBlueprint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InRigBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RecompileVM, __InBuffer);
			}
		}

		public static USkeletalMesh GetPreviewMesh(UControlRigBlueprint InRigBlueprint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InRigBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPreviewMesh, __InBuffer, __ReturnBuffer);

				return *(USkeletalMesh*)__ReturnBuffer;
			}
		}

		public static URigVMGraph GetModel(UControlRigBlueprint InRigBlueprint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InRigBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetModel, __InBuffer, __ReturnBuffer);

				return *(URigVMGraph*)__ReturnBuffer;
			}
		}

		public static URigHierarchyController GetHierarchyController(UControlRigBlueprint InRigBlueprint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InRigBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetHierarchyController, __InBuffer, __ReturnBuffer);

				return *(URigHierarchyController*)__ReturnBuffer;
			}
		}

		public static URigHierarchy GetHierarchy(UControlRigBlueprint InRigBlueprint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InRigBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetHierarchy, __InBuffer, __ReturnBuffer);

				return *(URigHierarchy*)__ReturnBuffer;
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

		public static URigVMController GetController(UControlRigBlueprint InRigBlueprint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InRigBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetController, __InBuffer, __ReturnBuffer);

				return *(URigVMController*)__ReturnBuffer;
			}
		}

		public static TArray<UStruct> GetAvailableRigUnits()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetAvailableRigUnits, __ReturnBuffer);

				return *(TArray<UStruct>*)__ReturnBuffer;
			}
		}

		public static void CastToControlRigBlueprint(UObject Object, ref ECastToControlRigBlueprintCases Branches, ref UControlRigBlueprint AsControlRigBlueprint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Branches;

				*(nint*)(__InBuffer + 9) = AsControlRigBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __CastToControlRigBlueprint, __InBuffer, __OutBuffer);

				Branches = *(ECastToControlRigBlueprintCases*)(__OutBuffer);

				AsControlRigBlueprint = *(UControlRigBlueprint*)(__OutBuffer + 1);

			}
		}

		private static uint __SetupAllEditorMenus = 0;

		private static uint __SetPreviewMesh = 0;

		private static uint __RequestControlRigInit = 0;

		private static uint __RequestAutoVMRecompilation = 0;

		private static uint __RecompileVMIfRequired = 0;

		private static uint __RecompileVM = 0;

		private static uint __GetPreviewMesh = 0;

		private static uint __GetModel = 0;

		private static uint __GetHierarchyController = 0;

		private static uint __GetHierarchy = 0;

		private static uint __GetCurrentlyOpenRigBlueprints = 0;

		private static uint __GetController = 0;

		private static uint __GetAvailableRigUnits = 0;

		private static uint __CastToControlRigBlueprint = 0;
	}
}