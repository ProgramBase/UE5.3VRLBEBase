using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMGraph")]
	public partial class URigVMGraph : UObject, IStaticClass
	{
		public TArray<URigVMNode> Nodes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Nodes, __ReturnBuffer);

					return *(TArray<URigVMNode>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Nodes, __InBuffer);
				}
			}
		}

		public TArray<URigVMLink> Links
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Links, __ReturnBuffer);

					return *(TArray<URigVMLink>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Links, __InBuffer);
				}
			}
		}

		public TArray<URigVMLink> DetachedLinks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DetachedLinks, __ReturnBuffer);

					return *(TArray<URigVMLink>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DetachedLinks, __InBuffer);
				}
			}
		}

		public TArray<FName> SelectedNodes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedNodes, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedNodes, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<URigVMGraph> DefaultFunctionLibraryPtr
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultFunctionLibraryPtr, __ReturnBuffer);

					return *(TWeakObjectPtr<URigVMGraph>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultFunctionLibraryPtr, __InBuffer);
				}
			}
		}

		public UScriptStruct ExecuteContextStruct
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExecuteContextStruct, __ReturnBuffer);

					return *(UScriptStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExecuteContextStruct, __InBuffer);
				}
			}
		}

		public uint LastStructureHash
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastStructureHash, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastStructureHash, __InBuffer);
				}
			}
		}

		public bool bEditable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEditable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEditable, __InBuffer);
				}
			}
		}

		public TArray<FRigVMGraphVariableDescription> LocalVariables
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LocalVariables, __ReturnBuffer);

					return *(TArray<FRigVMGraphVariableDescription>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LocalVariables, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMGraph");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetDefaultFunctionLibrary(URigVMFunctionLibrary InFunctionLibrary)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFunctionLibrary?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultFunctionLibrary, __InBuffer);
			}
		}

		public virtual bool IsTopLevelGraph()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsTopLevelGraph, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsRootGraph()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsRootGraph, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsNodeSelected(FName InNodeName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsNodeSelected, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TArray<FRigVMGraphVariableDescription> GetVariableDescriptions()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetVariableDescriptions, __ReturnBuffer);

				return *(TArray<FRigVMGraphVariableDescription>*)__ReturnBuffer;
			}
		}

		public virtual TArray<FName> GetSelectNodes()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSelectNodes, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		public virtual URigVMGraph GetRootGraph()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRootGraph, __ReturnBuffer);

				return *(URigVMGraph*)__ReturnBuffer;
			}
		}

		public virtual URigVMFunctionReturnNode GetReturnNode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetReturnNode, __ReturnBuffer);

				return *(URigVMFunctionReturnNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMGraph GetParentGraph()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetParentGraph, __ReturnBuffer);

				return *(URigVMGraph*)__ReturnBuffer;
			}
		}

		public virtual TArray<FRigVMGraphVariableDescription> GetOutputArguments()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOutputArguments, __ReturnBuffer);

				return *(TArray<FRigVMGraphVariableDescription>*)__ReturnBuffer;
			}
		}

		public virtual TArray<URigVMNode> GetNodes()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetNodes, __ReturnBuffer);

				return *(TArray<URigVMNode>*)__ReturnBuffer;
			}
		}

		public virtual FString GetNodePath()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetNodePath, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual TArray<FRigVMGraphVariableDescription> GetLocalVariables(bool bIncludeInputArguments = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIncludeInputArguments;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLocalVariables, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigVMGraphVariableDescription>*)__ReturnBuffer;
			}
		}

		public virtual TArray<URigVMLink> GetLinks()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLinks, __ReturnBuffer);

				return *(TArray<URigVMLink>*)__ReturnBuffer;
			}
		}

		public virtual TArray<FRigVMGraphVariableDescription> GetInputArguments()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetInputArguments, __ReturnBuffer);

				return *(TArray<FRigVMGraphVariableDescription>*)__ReturnBuffer;
			}
		}

		public virtual FString GetGraphName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetGraphName, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual int GetGraphDepth()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetGraphDepth, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual TArray<FName> GetEventNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetEventNames, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		public virtual URigVMFunctionEntryNode GetEntryNode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetEntryNode, __ReturnBuffer);

				return *(URigVMFunctionEntryNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMFunctionLibrary GetDefaultFunctionLibrary()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDefaultFunctionLibrary, __ReturnBuffer);

				return *(URigVMFunctionLibrary*)__ReturnBuffer;
			}
		}

		public virtual TArray<URigVMGraph> GetContainedGraphs(bool bRecursive = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bRecursive;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetContainedGraphs, __InBuffer, __ReturnBuffer);

				return *(TArray<URigVMGraph>*)__ReturnBuffer;
			}
		}

		public virtual URigVMPin FindPin(FString InPinPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPinPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindPin, __InBuffer, __ReturnBuffer);

				return *(URigVMPin*)__ReturnBuffer;
			}
		}

		public virtual URigVMNode FindNodeByName(FName InNodeName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindNodeByName, __InBuffer, __ReturnBuffer);

				return *(URigVMNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMNode FindNode(FString InNodePath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InNodePath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindNode, __InBuffer, __ReturnBuffer);

				return *(URigVMNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMLink FindLink(FString InLinkPinPathRepresentation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InLinkPinPathRepresentation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindLink, __InBuffer, __ReturnBuffer);

				return *(URigVMLink*)__ReturnBuffer;
			}
		}

		public virtual bool ContainsLink(FString InPinPathRepresentation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPinPathRepresentation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ContainsLink, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __Nodes = 0;

		private static uint __Links = 0;

		private static uint __DetachedLinks = 0;

		private static uint __SelectedNodes = 0;

		private static uint __DefaultFunctionLibraryPtr = 0;

		private static uint __ExecuteContextStruct = 0;

		private static uint __LastStructureHash = 0;

		private static uint __bEditable = 0;

		private static uint __LocalVariables = 0;

		private static uint __SetDefaultFunctionLibrary = 0;

		private static uint __IsTopLevelGraph = 0;

		private static uint __IsRootGraph = 0;

		private static uint __IsNodeSelected = 0;

		private static uint __GetVariableDescriptions = 0;

		private static uint __GetSelectNodes = 0;

		private static uint __GetRootGraph = 0;

		private static uint __GetReturnNode = 0;

		private static uint __GetParentGraph = 0;

		private static uint __GetOutputArguments = 0;

		private static uint __GetNodes = 0;

		private static uint __GetNodePath = 0;

		private static uint __GetLocalVariables = 0;

		private static uint __GetLinks = 0;

		private static uint __GetInputArguments = 0;

		private static uint __GetGraphName = 0;

		private static uint __GetGraphDepth = 0;

		private static uint __GetEventNames = 0;

		private static uint __GetEntryNode = 0;

		private static uint __GetDefaultFunctionLibrary = 0;

		private static uint __GetContainedGraphs = 0;

		private static uint __FindPin = 0;

		private static uint __FindNodeByName = 0;

		private static uint __FindNode = 0;

		private static uint __FindLink = 0;

		private static uint __ContainsLink = 0;
	}
}