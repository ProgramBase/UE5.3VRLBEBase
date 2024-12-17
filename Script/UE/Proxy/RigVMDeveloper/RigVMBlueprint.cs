using Script.CoreUObject;
using Script.Engine;
using Script.RigVM;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMBlueprint")]
	public partial class URigVMBlueprint : UBlueprint, IStaticClass, IRigVMClientHost
	{
		public URigVMEdGraph FunctionLibraryEdGraph
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FunctionLibraryEdGraph, __ReturnBuffer);

					return *(URigVMEdGraph*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FunctionLibraryEdGraph, __InBuffer);
				}
			}
		}

		public FRigVMEdGraphDisplaySettings RigGraphDisplaySettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RigGraphDisplaySettings, __ReturnBuffer);

					return *(FRigVMEdGraphDisplaySettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RigGraphDisplaySettings, __InBuffer);
				}
			}
		}

		public FRigVMRuntimeSettings VMRuntimeSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VMRuntimeSettings, __ReturnBuffer);

					return *(FRigVMRuntimeSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VMRuntimeSettings, __InBuffer);
				}
			}
		}

		public FRigVMCompileSettings VMCompileSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VMCompileSettings, __ReturnBuffer);

					return *(FRigVMCompileSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VMCompileSettings, __InBuffer);
				}
			}
		}

		public FRigVMPythonSettings PythonLogSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PythonLogSettings, __ReturnBuffer);

					return *(FRigVMPythonSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PythonLogSettings, __InBuffer);
				}
			}
		}

		public FRigVMClient RigVMClient
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RigVMClient, __ReturnBuffer);

					return *(FRigVMClient*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RigVMClient, __InBuffer);
				}
			}
		}

		public bool ReferencedObjectPathsStored
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReferencedObjectPathsStored, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReferencedObjectPathsStored, __InBuffer);
				}
			}
		}

		public TArray<FSoftObjectPath> ReferencedObjectPaths
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReferencedObjectPaths, __ReturnBuffer);

					return *(TArray<FSoftObjectPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReferencedObjectPaths, __InBuffer);
				}
			}
		}

		public TArray<FRigVMGraphFunctionHeader> PublicGraphFunctions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PublicGraphFunctions, __ReturnBuffer);

					return *(TArray<FRigVMGraphFunctionHeader>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PublicGraphFunctions, __InBuffer);
				}
			}
		}

		public TArray<FRigVMReferenceNodeData> FunctionReferenceNodeData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FunctionReferenceNodeData, __ReturnBuffer);

					return *(TArray<FRigVMReferenceNodeData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FunctionReferenceNodeData, __InBuffer);
				}
			}
		}

		public URigVMGraph TemplateModel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TemplateModel, __ReturnBuffer);

					return *(URigVMGraph*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TemplateModel, __InBuffer);
				}
			}
		}

		public URigVMController TemplateController
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TemplateController, __ReturnBuffer);

					return *(URigVMController*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TemplateController, __InBuffer);
				}
			}
		}

		public TMap<FString, FRigVMOperand> PinToOperandMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PinToOperandMap, __ReturnBuffer);

					return *(TMap<FString, FRigVMOperand>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PinToOperandMap, __InBuffer);
				}
			}
		}

		public TArray<FName> SupportedEventNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SupportedEventNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SupportedEventNames, __InBuffer);
				}
			}
		}

		public bool bAutoRecompileVM
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoRecompileVM, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoRecompileVM, __InBuffer);
				}
			}
		}

		public bool bVMRecompilationRequired
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bVMRecompilationRequired, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bVMRecompilationRequired, __InBuffer);
				}
			}
		}

		public bool bIsCompiling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsCompiling, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsCompiling, __InBuffer);
				}
			}
		}

		public int VMRecompilationBracket
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VMRecompilationBracket, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VMRecompilationBracket, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMBlueprint");
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

		public virtual void SuspendNotifications(bool bSuspendNotifs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bSuspendNotifs;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SuspendNotifications, __InBuffer);
			}
		}

		public virtual void SetAutoVMRecompile(bool bAutoRecompile)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bAutoRecompile;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAutoVMRecompile, __InBuffer);
			}
		}

		public virtual void RequestRigVMInit()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RequestRigVMInit);
			}
		}

		public virtual void RequestAutoVMRecompilation()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RequestAutoVMRecompilation);
			}
		}

		public virtual bool RenameMemberVariable(FName InOldName, FName InNewName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InOldName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNewName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameMemberVariable, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveModel(FString InName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = true)
		{
			unsafe
			{
				InName ??= new FString("Rig Graph");

				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveModel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveMemberVariable(FName InName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveMemberVariable, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void RecompileVMIfRequired()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RecompileVMIfRequired);
			}
		}

		public virtual void RecompileVM()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RecompileVM);
			}
		}

		public virtual UClass GetRigVMHostClass()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRigVMHostClass, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		public virtual URigVMController GetOrCreateController(URigVMGraph InGraph = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InGraph?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetOrCreateController, __InBuffer, __ReturnBuffer);

				return *(URigVMController*)__ReturnBuffer;
			}
		}

		public virtual URigVMGraph GetModel(UEdGraph InEdGraph = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InEdGraph?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetModel, __InBuffer, __ReturnBuffer);

				return *(URigVMGraph*)__ReturnBuffer;
			}
		}

		public virtual TArray<FRigVMGraphVariableDescription> GetMemberVariables()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMemberVariables, __ReturnBuffer);

				return *(TArray<FRigVMGraphVariableDescription>*)__ReturnBuffer;
			}
		}

		public virtual URigVMFunctionLibrary GetLocalFunctionLibrary()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLocalFunctionLibrary, __ReturnBuffer);

				return *(URigVMFunctionLibrary*)__ReturnBuffer;
			}
		}

		public virtual URigVMGraph GetFocusedModel()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetFocusedModel, __ReturnBuffer);

				return *(URigVMGraph*)__ReturnBuffer;
			}
		}

		public virtual URigVMGraph GetDefaultModel()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDefaultModel, __ReturnBuffer);

				return *(URigVMGraph*)__ReturnBuffer;
			}
		}

		public virtual URigVMController GetControllerByName(FString InGraphName = null)
		{
			unsafe
			{
				InGraphName ??= new FString("");

				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InGraphName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetControllerByName, __InBuffer, __ReturnBuffer);

				return *(URigVMController*)__ReturnBuffer;
			}
		}

		public virtual URigVMController GetController(URigVMGraph InGraph = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InGraph?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetController, __InBuffer, __ReturnBuffer);

				return *(URigVMController*)__ReturnBuffer;
			}
		}

		public virtual TArray<UStruct> GetAvailableRigVMStructs()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAvailableRigVMStructs, __ReturnBuffer);

				return *(TArray<UStruct>*)__ReturnBuffer;
			}
		}

		public virtual bool GetAutoVMRecompile()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAutoVMRecompile, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TArray<URigVMGraph> GetAllModels()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAllModels, __ReturnBuffer);

				return *(TArray<URigVMGraph>*)__ReturnBuffer;
			}
		}

		public virtual TArray<FString> GeneratePythonCommands(FString InNewBlueprintName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InNewBlueprintName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GeneratePythonCommands, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public virtual URigVMHost CreateRigVMHost()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __CreateRigVMHost, __ReturnBuffer);

				return *(URigVMHost*)__ReturnBuffer;
			}
		}

		public virtual bool ChangeMemberVariableType(FName InName, FString InCPPType, bool bIsPublic = false, bool bIsReadOnly = false, FString InDefaultValue = null)
		{
			unsafe
			{
				InDefaultValue ??= new FString("");

				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bIsPublic;

				*(bool*)(__InBuffer + 17) = bIsReadOnly;

				*(nint*)(__InBuffer + 18) = InDefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ChangeMemberVariableType, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual URigVMGraph AddModel(FString InName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = true)
		{
			unsafe
			{
				InName ??= new FString("Rig Graph");

				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddModel, __InBuffer, __ReturnBuffer);

				return *(URigVMGraph*)__ReturnBuffer;
			}
		}

		public virtual FName AddMemberVariable(FName InName, FString InCPPType, bool bIsPublic = false, bool bIsReadOnly = false, FString InDefaultValue = null)
		{
			unsafe
			{
				InDefaultValue ??= new FString("");

				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bIsPublic;

				*(bool*)(__InBuffer + 17) = bIsReadOnly;

				*(nint*)(__InBuffer + 18) = InDefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddMemberVariable, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		private static uint __FunctionLibraryEdGraph = 0;

		private static uint __RigGraphDisplaySettings = 0;

		private static uint __VMRuntimeSettings = 0;

		private static uint __VMCompileSettings = 0;

		private static uint __PythonLogSettings = 0;

		private static uint __RigVMClient = 0;

		private static uint __ReferencedObjectPathsStored = 0;

		private static uint __ReferencedObjectPaths = 0;

		private static uint __PublicGraphFunctions = 0;

		private static uint __FunctionReferenceNodeData = 0;

		private static uint __TemplateModel = 0;

		private static uint __TemplateController = 0;

		private static uint __PinToOperandMap = 0;

		private static uint __SupportedEventNames = 0;

		private static uint __bAutoRecompileVM = 0;

		private static uint __bVMRecompilationRequired = 0;

		private static uint __bIsCompiling = 0;

		private static uint __VMRecompilationBracket = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SuspendNotifications = 0;

		private static uint __SetAutoVMRecompile = 0;

		private static uint __RequestRigVMInit = 0;

		private static uint __RequestAutoVMRecompilation = 0;

		private static uint __RenameMemberVariable = 0;

		private static uint __RemoveModel = 0;

		private static uint __RemoveMemberVariable = 0;

		private static uint __RecompileVMIfRequired = 0;

		private static uint __RecompileVM = 0;

		private static uint __GetRigVMHostClass = 0;

		private static uint __GetOrCreateController = 0;

		private static uint __GetModel = 0;

		private static uint __GetMemberVariables = 0;

		private static uint __GetLocalFunctionLibrary = 0;

		private static uint __GetFocusedModel = 0;

		private static uint __GetDefaultModel = 0;

		private static uint __GetControllerByName = 0;

		private static uint __GetController = 0;

		private static uint __GetAvailableRigVMStructs = 0;

		private static uint __GetAutoVMRecompile = 0;

		private static uint __GetAllModels = 0;

		private static uint __GeneratePythonCommands = 0;

		private static uint __CreateRigVMHost = 0;

		private static uint __ChangeMemberVariableType = 0;

		private static uint __AddModel = 0;

		private static uint __AddMemberVariable = 0;
	}
}