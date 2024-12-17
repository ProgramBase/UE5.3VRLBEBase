using Script.CoreUObject;
using Script.Library;
using Script.RigVM;
using Script.Engine;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigHierarchyController")]
	public partial class URigHierarchyController : UObject, IStaticClass
	{
		public bool bReportWarningsAndErrors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bReportWarningsAndErrors, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bReportWarningsAndErrors, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<URigHierarchy> Hierarchy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Hierarchy, __ReturnBuffer);

					return *(TWeakObjectPtr<URigHierarchy>*)__ReturnBuffer;
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

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRig.RigHierarchyController");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InKeys">
		/// The array of keys of the elements to select
		/// </param>
		/// <returns>
		/// Returns true if the selection was applied
		/// </returns>
		public virtual bool SetSelection(TArray<FRigElementKey> InKeys, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InKeys?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetSelection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InChild">
		/// The key of the element to set the parent for
		/// </param>
		/// <param name="InParent">
		/// The key of the new parent to set
		/// </param>
		/// <param name="bMaintainGlobalTransform">
		/// If set to true the child will stay in the same place spatially, otherwise it will maintain it's local transform (and potential move).
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <param name="bPrintPythonCommand">
		/// If set to true a python command equivalent to this call will be printed out
		/// </param>
		/// <returns>
		/// Returns true if successful.
		/// </returns>
		public virtual bool SetParent(FRigElementKey InChild, FRigElementKey InParent, bool bMaintainGlobalTransform = true, bool bSetupUndo = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InChild?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParent?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bMaintainGlobalTransform;

				*(bool*)(__InBuffer + 17) = bSetupUndo;

				*(bool*)(__InBuffer + 18) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetParent, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetHierarchy(URigHierarchy InHierarchy)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InHierarchy?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetHierarchy, __InBuffer);
			}
		}

		/// <param name="InControl">
		/// The key of the control to change the display name for
		/// </param>
		/// <param name="InDisplayName">
		/// The new display name to set for the control
		/// </param>
		/// <param name="bRenameElement">
		/// True if the control should also be renamed
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <param name="bPrintPythonCommand">
		/// If set to true a python command equivalent to this call will be printed out
		/// </param>
		/// <returns>
		/// Returns the new display name used for the control
		/// </returns>
		public virtual FName SetDisplayName(FRigElementKey InControl, FName InDisplayName, bool bRenameElement = false, bool bSetupUndo = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InControl?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InDisplayName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bRenameElement;

				*(bool*)(__InBuffer + 17) = bSetupUndo;

				*(bool*)(__InBuffer + 18) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SetDisplayName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the control to set the settings for
		/// </param>
		/// <param name="The">
		/// settings to set
		/// </param>
		/// <returns>
		/// Returns true if the settings have been set correctly
		/// </returns>
		public virtual bool SetControlSettings(FRigElementKey InKey, FRigControlSettings InSettings, bool bSetupUndo = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndo;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetControlSettings, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the element to select
		/// </param>
		/// <param name="bSelect">
		/// If set to false the element will be deselected
		/// </param>
		/// <returns>
		/// Returns true if the selection was applied
		/// </returns>
		public virtual bool SelectElement(FRigElementKey InKey, bool bSelect = true, bool bClearSelection = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSelect;

				*(bool*)(__InBuffer + 9) = bClearSelection;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SelectElement, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InElement">
		/// The key of the element to rename
		/// </param>
		/// <param name="InIndex">
		/// The new index of the element to take within its default parent (or the top level)
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <param name="bPrintPythonCommand">
		/// If set to true a python command equivalent to this call will be printed out
		/// </param>
		/// <returns>
		/// Returns true if the element has been reordered accordingly
		/// </returns>
		public virtual bool ReorderElement(FRigElementKey InElement, int InIndex, bool bSetupUndo = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[14];

				*(nint*)(__InBuffer) = InElement?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InIndex;

				*(bool*)(__InBuffer + 12) = bSetupUndo;

				*(bool*)(__InBuffer + 13) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ReorderElement, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InElement">
		/// The key of the element to rename
		/// </param>
		/// <param name="InName">
		/// The new name to set for the element
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <param name="bPrintPythonCommand">
		/// If set to true a python command equivalent to this call will be printed out
		/// </param>
		/// <param name="bClearSelection">
		/// True if the selection should be cleared after a rename
		/// </param>
		/// <returns>
		/// Returns the new element key used for the element
		/// </returns>
		public virtual FRigElementKey RenameElement(FRigElementKey InElement, FName InName, bool bSetupUndo = false, bool bPrintPythonCommand = false, bool bClearSelection = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InElement?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndo;

				*(bool*)(__InBuffer + 17) = bPrintPythonCommand;

				*(bool*)(__InBuffer + 18) = bClearSelection;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __RenameElement, __InBuffer, __ReturnBuffer);

				return *(FRigElementKey*)__ReturnBuffer;
			}
		}

		/// <param name="InChild">
		/// The key of the element to remove the parent for
		/// </param>
		/// <param name="InParent">
		/// The key of the parent to remove
		/// </param>
		/// <param name="bMaintainGlobalTransform">
		/// If set to true the child will stay in the same place spatially, otherwise it will maintain it's local transform (and potential move).
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <param name="bPrintPythonCommand">
		/// If set to true a python command equivalent to this call will be printed out
		/// </param>
		/// <returns>
		/// Returns true if successful.
		/// </returns>
		public virtual bool RemoveParent(FRigElementKey InChild, FRigElementKey InParent, bool bMaintainGlobalTransform = true, bool bSetupUndo = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InChild?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParent?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bMaintainGlobalTransform;

				*(bool*)(__InBuffer + 17) = bSetupUndo;

				*(bool*)(__InBuffer + 18) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveParent, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InElement">
		/// The key of the element to remove
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <param name="bPrintPythonCommand">
		/// If set to true a python command equivalent to this call will be printed out
		/// </param>
		/// <returns>
		/// Returns true if successful.
		/// </returns>
		public virtual bool RemoveElement(FRigElementKey InElement, bool bSetupUndo = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InElement?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveElement, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InChild">
		/// The key of the element to remove all parents for
		/// </param>
		/// <param name="bMaintainGlobalTransform">
		/// If set to true the child will stay in the same place spatially, otherwise it will maintain it's local transform (and potential move).
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <param name="bPrintPythonCommand">
		/// If set to true a python command equivalent to this call will be printed out
		/// </param>
		/// <returns>
		/// Returns true if successful.
		/// </returns>
		public virtual bool RemoveAllParents(FRigElementKey InChild, bool bMaintainGlobalTransform = true, bool bSetupUndo = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = InChild?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bMaintainGlobalTransform;

				*(bool*)(__InBuffer + 9) = bSetupUndo;

				*(bool*)(__InBuffer + 10) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveAllParents, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InKeys">
		/// The keys of the elements to mirror
		/// </param>
		/// <param name="InSettings">
		/// The settings to use for the mirror operation
		/// </param>
		/// <param name="bSelectNewElements">
		/// If set to true the new elements will be selected
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <param name="bPrintPythonCommand">
		/// If set to true a python command equivalent to this call will be printed out
		/// </param>
		/// <returns>
		/// The keys of the mirrored items
		/// </returns>
		public virtual TArray<FRigElementKey> MirrorElements(TArray<FRigElementKey> InKeys, FRigVMMirrorSettings InSettings, bool bSelectNewElements = true, bool bSetupUndo = false, bool bPrintPythonCommands = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InKeys?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSelectNewElements;

				*(bool*)(__InBuffer + 17) = bSetupUndo;

				*(bool*)(__InBuffer + 18) = bPrintPythonCommands;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __MirrorElements, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="InContent">
		/// The string buffer representing the content to import
		/// </param>
		/// <param name="bReplaceExistingElements">
		/// If set to true existing items will be replaced / updated with the content in the buffer
		/// </param>
		/// <param name="bSelectNewElements">
		/// If set to true the new elements will be selected
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <param name="bPrintPythonCommand">
		/// If set to true a python command equivalent to this call will be printed out
		/// </param>
		public virtual TArray<FRigElementKey> ImportFromText(FString InContent, bool bReplaceExistingElements = false, bool bSelectNewElements = true, bool bSetupUndo = false, bool bPrintPythonCommands = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InContent?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bReplaceExistingElements;

				*(bool*)(__InBuffer + 9) = bSelectNewElements;

				*(bool*)(__InBuffer + 10) = bSetupUndo;

				*(bool*)(__InBuffer + 11) = bPrintPythonCommands;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ImportFromText, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="InAssetPath">
		/// The path to the uasset to import from
		/// </param>
		/// <param name="InNameSpace">
		/// The namespace to prefix the bone names with
		/// </param>
		/// <param name="bSelectCurves">
		/// If true the curves will be selected upon import
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <returns>
		/// The keys of the imported elements
		/// </returns>
		public virtual TArray<FRigElementKey> ImportCurvesFromAsset(FString InAssetPath, FName InNameSpace = null, bool bSelectCurves = false, bool bSetupUndo = false)
		{
			unsafe
			{
				InNameSpace ??= new FName("None");

				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InAssetPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNameSpace?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSelectCurves;

				*(bool*)(__InBuffer + 17) = bSetupUndo;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ImportCurvesFromAsset, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="InSkeleton">
		/// The skeleton to import the curves from
		/// </param>
		/// <param name="InNameSpace">
		/// The namespace to prefix the bone names with
		/// </param>
		/// <param name="bSelectCurves">
		/// If true the curves will be selected upon import
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <returns>
		/// The keys of the imported elements
		/// </returns>
		public virtual TArray<FRigElementKey> ImportCurves(USkeleton InSkeleton, FName InNameSpace = null, bool bSelectCurves = false, bool bSetupUndo = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InNameSpace ??= new FName("None");

				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InSkeleton?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNameSpace?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSelectCurves;

				*(bool*)(__InBuffer + 17) = bSetupUndo;

				*(bool*)(__InBuffer + 18) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ImportCurves, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="InAssetPath">
		/// The path to the uasset to import from
		/// </param>
		/// <param name="InNameSpace">
		/// The namespace to prefix the bone names with
		/// </param>
		/// <param name="bReplaceExistingBones">
		/// If true existing bones will be removed
		/// </param>
		/// <param name="bRemoveObsoleteBones">
		/// If true bones non-existent in the skeleton will be removed from the hierarchy
		/// </param>
		/// <param name="bSelectBones">
		/// If true the bones will be selected upon import
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <returns>
		/// The keys of the imported elements
		/// </returns>
		public virtual TArray<FRigElementKey> ImportBonesFromAsset(FString InAssetPath, FName InNameSpace = null, bool bReplaceExistingBones = true, bool bRemoveObsoleteBones = true, bool bSelectBones = false, bool bSetupUndo = false)
		{
			unsafe
			{
				InNameSpace ??= new FName("None");

				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InAssetPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNameSpace?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bReplaceExistingBones;

				*(bool*)(__InBuffer + 17) = bRemoveObsoleteBones;

				*(bool*)(__InBuffer + 18) = bSelectBones;

				*(bool*)(__InBuffer + 19) = bSetupUndo;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ImportBonesFromAsset, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="InSkeleton">
		/// The skeleton to import
		/// </param>
		/// <param name="InNameSpace">
		/// The namespace to prefix the bone names with
		/// </param>
		/// <param name="bReplaceExistingBones">
		/// If true existing bones will be removed
		/// </param>
		/// <param name="bRemoveObsoleteBones">
		/// If true bones non-existent in the skeleton will be removed from the hierarchy
		/// </param>
		/// <param name="bSelectBones">
		/// If true the bones will be selected upon import
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <param name="bPrintPythonCommand">
		/// If set to true a python command equivalent to this call will be printed out
		/// </param>
		/// <returns>
		/// The keys of the imported elements
		/// </returns>
		public virtual TArray<FRigElementKey> ImportBones(USkeleton InSkeleton, FName InNameSpace = null, bool bReplaceExistingBones = true, bool bRemoveObsoleteBones = true, bool bSelectBones = false, bool bSetupUndo = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InNameSpace ??= new FName("None");

				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = InSkeleton?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNameSpace?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bReplaceExistingBones;

				*(bool*)(__InBuffer + 17) = bRemoveObsoleteBones;

				*(bool*)(__InBuffer + 18) = bSelectBones;

				*(bool*)(__InBuffer + 19) = bSetupUndo;

				*(bool*)(__InBuffer + 20) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ImportBones, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
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

		/// <param name="InKey">
		/// The key of the control to receive the settings for
		/// </param>
		/// <returns>
		/// The settings of the given control
		/// </returns>
		public virtual FRigControlSettings GetControlSettings(FRigElementKey InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetControlSettings, __InBuffer, __ReturnBuffer);

				return *(FRigControlSettings*)__ReturnBuffer;
			}
		}

		public virtual TArray<FString> GeneratePythonCommands()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GeneratePythonCommands, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		/// <param name="InKeys">
		/// The keys to export to text
		/// </param>
		/// <returns>
		/// The text representation of the requested elements
		/// </returns>
		public virtual FString ExportToText(TArray<FRigElementKey> InKeys)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKeys?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ExportToText, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The text representation of the selected items
		/// </returns>
		public virtual FString ExportSelectionToText()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __ExportSelectionToText, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="InKeys">
		/// The keys of the elements to duplicate
		/// </param>
		/// <param name="bSelectNewElements">
		/// If set to true the new elements will be selected
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <param name="bPrintPythonCommand">
		/// If set to true a python command equivalent to this call will be printed out
		/// </param>
		/// <returns>
		/// The keys of the 4d items
		/// </returns>
		public virtual TArray<FRigElementKey> DuplicateElements(TArray<FRigElementKey> InKeys, bool bSelectNewElements = true, bool bSetupUndo = false, bool bPrintPythonCommands = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = InKeys?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSelectNewElements;

				*(bool*)(__InBuffer + 9) = bSetupUndo;

				*(bool*)(__InBuffer + 10) = bPrintPythonCommands;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __DuplicateElements, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigElementKey>*)__ReturnBuffer;
			}
		}

		/// <param name="InKey">
		/// The key of the element to deselect
		/// </param>
		/// <returns>
		/// Returns true if the selection was applied
		/// </returns>
		public virtual bool DeselectElement(FRigElementKey InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DeselectElement, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Returns true if the selection was applied
		/// </returns>
		public virtual bool ClearSelection()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __ClearSelection, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InName">
		/// The suggested name of the new rigidbody - will eventually be corrected by the namespace
		/// </param>
		/// <param name="InParent">
		/// The (optional) parent of the new rigidbody. If you don't need a parent, pass FRigElementKey()
		/// </param>
		/// <param name="InSettings">
		/// All of the rigidbody's settings
		/// </param>
		/// <param name="InLocalTransform">
		/// The transform for the new rigidbody - in the space of the provided parent
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <param name="bPrintPythonCommand">
		/// If set to true a python command equivalent to this call will be printed out
		/// </param>
		/// <returns>
		/// The key for the newly created rigidbody.
		/// </returns>
		public virtual FRigElementKey AddRigidBody(FName InName, FRigElementKey InParent, FRigRigidBodySettings InSettings, FTransform InLocalTransform, bool bSetupUndo = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[34];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InLocalTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bSetupUndo;

				*(bool*)(__InBuffer + 33) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddRigidBody, __InBuffer, __ReturnBuffer);

				return *(FRigElementKey*)__ReturnBuffer;
			}
		}

		/// <param name="InChild">
		/// The key of the element to add the parent for
		/// </param>
		/// <param name="InParent">
		/// The key of the new parent to add
		/// </param>
		/// <param name="InWeight">
		/// The initial weight to give to the parent
		/// </param>
		/// <param name="bMaintainGlobalTransform">
		/// If set to true the child will stay in the same place spatially, otherwise it will maintain it's local transform (and potential move).
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <returns>
		/// Returns true if successful.
		/// </returns>
		public virtual bool AddParent(FRigElementKey InChild, FRigElementKey InParent, float InWeight = 0.000000f, bool bMaintainGlobalTransform = true, bool bSetupUndo = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[22];

				*(nint*)(__InBuffer) = InChild?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParent?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = InWeight;

				*(bool*)(__InBuffer + 20) = bMaintainGlobalTransform;

				*(bool*)(__InBuffer + 21) = bSetupUndo;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddParent, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InName">
		/// The suggested name of the new null - will eventually be corrected by the namespace
		/// </param>
		/// <param name="InParent">
		/// The (optional) parent of the new null. If you don't need a parent, pass FRigElementKey()
		/// </param>
		/// <param name="InTransform">
		/// The transform for the new null - either in local or global null, based on bTransformInGlobal
		/// </param>
		/// <param name="bTransformInGlobal">
		/// Set this to true if the Transform passed is expressed in global null, false for local null.
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <param name="bPrintPythonCommand">
		/// If set to true a python command equivalent to this call will be printed out
		/// </param>
		/// <returns>
		/// The key for the newly created null.
		/// </returns>
		public virtual FRigElementKey AddNull(FName InName, FRigElementKey InParent, FTransform InTransform, bool bTransformInGlobal = true, bool bSetupUndo = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[27];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bTransformInGlobal;

				*(bool*)(__InBuffer + 25) = bSetupUndo;

				*(bool*)(__InBuffer + 26) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddNull, __InBuffer, __ReturnBuffer);

				return *(FRigElementKey*)__ReturnBuffer;
			}
		}

		/// <param name="InName">
		/// The suggested name of the new curve - will eventually be corrected by the namespace
		/// </param>
		/// <param name="InValue">
		/// The value to use for the curve
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <param name="bPrintPythonCommand">
		/// If set to true a python command equivalent to this call will be printed out
		/// </param>
		/// <returns>
		/// The key for the newly created curve.
		/// </returns>
		public virtual FRigElementKey AddCurve(FName InName, float InValue = 0.000000f, bool bSetupUndo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[14];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InValue;

				*(bool*)(__InBuffer + 12) = bSetupUndo;

				*(bool*)(__InBuffer + 13) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddCurve, __InBuffer, __ReturnBuffer);

				return *(FRigElementKey*)__ReturnBuffer;
			}
		}

		/// <param name="InName">
		/// The suggested name of the new control - will eventually be corrected by the namespace
		/// </param>
		/// <param name="InParent">
		/// The (optional) parent of the new control. If you don't need a parent, pass FRigElementKey()
		/// </param>
		/// <param name="InSettings">
		/// All of the control's settings
		/// </param>
		/// <param name="InValue">
		/// The value to use for the control
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <returns>
		/// The key for the newly created control.
		/// </returns>
		public virtual FRigElementKey AddControl_ForBlueprint(FName InName, FRigElementKey InParent, FRigControlSettings InSettings, FRigControlValue InValue, bool bSetupUndo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[34];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bSetupUndo;

				*(bool*)(__InBuffer + 33) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddControl_ForBlueprint, __InBuffer, __ReturnBuffer);

				return *(FRigElementKey*)__ReturnBuffer;
			}
		}

		/// <param name="InName">
		/// The suggested name of the new bone - will eventually be corrected by the namespace
		/// </param>
		/// <param name="InParent">
		/// The (optional) parent of the new bone. If you don't need a parent, pass FRigElementKey()
		/// </param>
		/// <param name="InTransform">
		/// The transform for the new bone - either in local or global space, based on bTransformInGlobal
		/// </param>
		/// <param name="bTransformInGlobal">
		/// Set this to true if the Transform passed is expressed in global space, false for local space.
		/// </param>
		/// <param name="InBoneType">
		/// The type of bone to add. This can be used to differentiate between imported bones and user defined bones.
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <param name="bPrintPythonCommand">
		/// If set to true a python command equivalent to this call will be printed out
		/// </param>
		/// <returns>
		/// The key for the newly created bone.
		/// </returns>
		public virtual FRigElementKey AddBone(FName InName, FRigElementKey InParent, FTransform InTransform, bool bTransformInGlobal = true, ERigBoneType InBoneType = ERigBoneType.User, bool bSetupUndo = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bTransformInGlobal;

				*(byte*)(__InBuffer + 25) = (byte)InBoneType;

				*(bool*)(__InBuffer + 26) = bSetupUndo;

				*(bool*)(__InBuffer + 27) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddBone, __InBuffer, __ReturnBuffer);

				return *(FRigElementKey*)__ReturnBuffer;
			}
		}

		/// <param name="InName">
		/// The suggested name of the new animation channel - will eventually be corrected by the namespace
		/// </param>
		/// <param name="InParentControl">
		/// The parent of the new animation channel.
		/// </param>
		/// <param name="InSettings">
		/// All of the animation channel's settings
		/// </param>
		/// <param name="bSetupUndo">
		/// If set to true the stack will record the change for undo / redo
		/// </param>
		/// <returns>
		/// The key for the newly created animation channel.
		/// </returns>
		public virtual FRigElementKey AddAnimationChannel_ForBlueprint(FName InName, FRigElementKey InParentControl, FRigControlSettings InSettings, bool bSetupUndo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParentControl?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bSetupUndo;

				*(bool*)(__InBuffer + 25) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddAnimationChannel_ForBlueprint, __InBuffer, __ReturnBuffer);

				return *(FRigElementKey*)__ReturnBuffer;
			}
		}

		private static uint __bReportWarningsAndErrors = 0;

		private static uint __Hierarchy = 0;

		private static uint __SetSelection = 0;

		private static uint __SetParent = 0;

		private static uint __SetHierarchy = 0;

		private static uint __SetDisplayName = 0;

		private static uint __SetControlSettings = 0;

		private static uint __SelectElement = 0;

		private static uint __ReorderElement = 0;

		private static uint __RenameElement = 0;

		private static uint __RemoveParent = 0;

		private static uint __RemoveElement = 0;

		private static uint __RemoveAllParents = 0;

		private static uint __MirrorElements = 0;

		private static uint __ImportFromText = 0;

		private static uint __ImportCurvesFromAsset = 0;

		private static uint __ImportCurves = 0;

		private static uint __ImportBonesFromAsset = 0;

		private static uint __ImportBones = 0;

		private static uint __GetHierarchy = 0;

		private static uint __GetControlSettings = 0;

		private static uint __GeneratePythonCommands = 0;

		private static uint __ExportToText = 0;

		private static uint __ExportSelectionToText = 0;

		private static uint __DuplicateElements = 0;

		private static uint __DeselectElement = 0;

		private static uint __ClearSelection = 0;

		private static uint __AddRigidBody = 0;

		private static uint __AddParent = 0;

		private static uint __AddNull = 0;

		private static uint __AddCurve = 0;

		private static uint __AddControl_ForBlueprint = 0;

		private static uint __AddBone = 0;

		private static uint __AddAnimationChannel_ForBlueprint = 0;
	}
}