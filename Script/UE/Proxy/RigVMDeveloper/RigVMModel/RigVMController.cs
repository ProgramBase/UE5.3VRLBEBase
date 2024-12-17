using Script.CoreUObject;
using Script.Library;
using Script.RigVM;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMController")]
	public partial class URigVMController : UObject, IStaticClass
	{
		public FRigVMGraphModifiedDynamicEvent ModifiedEventDynamic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ModifiedEventDynamic, __ReturnBuffer);

					return *(FRigVMGraphModifiedDynamicEvent*)__ReturnBuffer;
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

		public TArray<URigVMGraph> Graphs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Graphs, __ReturnBuffer);

					return *(TArray<URigVMGraph>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Graphs, __InBuffer);
				}
			}
		}

		public URigVMSchema SchemaPtr
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SchemaPtr, __ReturnBuffer);

					return *(URigVMSchema*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SchemaPtr, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMController");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual TArray<URigVMNode> UpgradeNodes(TArray<FName> InNodeNames, bool bRecursive = true, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = InNodeNames?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bRecursive;

				*(bool*)(__InBuffer + 9) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 10) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __UpgradeNodes, __InBuffer, __ReturnBuffer);

				return *(TArray<URigVMNode>*)__ReturnBuffer;
			}
		}

		public virtual bool UnresolveTemplateNodes(TArray<FName> InNodeNames, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InNodeNames?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __UnresolveTemplateNodes, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool Undo()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __Undo, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool UnbindPinFromVariable(FString InPinPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __UnbindPinFromVariable, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetUnitNodeDefaults(URigVMUnitNode InNode, FString InDefaults, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InDefaults?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetUnitNodeDefaults, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetSchema(URigVMSchema InSchema)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSchema?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSchema, __InBuffer);
			}
		}

		public virtual bool SetRemappedVariable(URigVMFunctionReferenceNode InFunctionRefNode, FName InInnerVariableName, FName InOuterVariableName, bool bSetupUndoRedo = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = InFunctionRefNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InInnerVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InOuterVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bSetupUndoRedo;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetRemappedVariable, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetPinIsWatched(FString InPinPath, bool bIsWatched, bool bSetupUndoRedo = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsWatched;

				*(bool*)(__InBuffer + 9) = bSetupUndoRedo;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetPinIsWatched, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetPinExpansion(FString InPinPath, bool bIsExpanded, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = InPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsExpanded;

				*(bool*)(__InBuffer + 9) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 10) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetPinExpansion, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetPinDefaultValue(FString InPinPath, FString InDefaultValue, bool bResizeArrays = true, bool bSetupUndoRedo = true, bool bMergeUndoAction = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InDefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bResizeArrays;

				*(bool*)(__InBuffer + 17) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 18) = bMergeUndoAction;

				*(bool*)(__InBuffer + 19) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetPinDefaultValue, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetNodeSizeByName(FName InNodeName, FVector2D InSize, bool bSetupUndoRedo = true, bool bMergeUndoAction = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSize?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bMergeUndoAction;

				*(bool*)(__InBuffer + 18) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetNodeSizeByName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetNodeSize(URigVMNode InNode, FVector2D InSize, bool bSetupUndoRedo = true, bool bMergeUndoAction = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSize?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bMergeUndoAction;

				*(bool*)(__InBuffer + 18) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetNodeSize, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetNodeSelection(TArray<FName> InNodeNames, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InNodeNames?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetNodeSelection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetNodePositionByName(FName InNodeName, FVector2D InPosition, bool bSetupUndoRedo = true, bool bMergeUndoAction = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bMergeUndoAction;

				*(bool*)(__InBuffer + 18) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetNodePositionByName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetNodePosition(URigVMNode InNode, FVector2D InPosition, bool bSetupUndoRedo = true, bool bMergeUndoAction = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bMergeUndoAction;

				*(bool*)(__InBuffer + 18) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetNodePosition, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetNodeKeywordsByName(FName InNodeName, FString InKeywords, bool bSetupUndoRedo = true, bool bMergeUndoAction = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InKeywords?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bMergeUndoAction;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetNodeKeywordsByName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetNodeKeywords(URigVMCollapseNode InNode, FString InKeywords, bool bSetupUndoRedo = true, bool bMergeUndoAction = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InKeywords?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bMergeUndoAction;

				*(bool*)(__InBuffer + 18) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetNodeKeywords, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetNodeDescriptionByName(FName InNodeName, FString InDescription, bool bSetupUndoRedo = true, bool bMergeUndoAction = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InDescription?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bMergeUndoAction;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetNodeDescriptionByName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetNodeDescription(URigVMCollapseNode InNode, FString InDescription, bool bSetupUndoRedo = true, bool bMergeUndoAction = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InDescription?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bMergeUndoAction;

				*(bool*)(__InBuffer + 18) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetNodeDescription, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetNodeColorByName(FName InNodeName, FLinearColor InColor, bool bSetupUndoRedo = true, bool bMergeUndoAction = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bMergeUndoAction;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetNodeColorByName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetNodeColor(URigVMNode InNode, FLinearColor InColor, bool bSetupUndoRedo = true, bool bMergeUndoAction = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bMergeUndoAction;

				*(bool*)(__InBuffer + 18) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetNodeColor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetNodeCategoryByName(FName InNodeName, FString InCategory, bool bSetupUndoRedo = true, bool bMergeUndoAction = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCategory?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bMergeUndoAction;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetNodeCategoryByName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetNodeCategory(URigVMCollapseNode InNode, FString InCategory, bool bSetupUndoRedo = true, bool bMergeUndoAction = false, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCategory?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bMergeUndoAction;

				*(bool*)(__InBuffer + 18) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetNodeCategory, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetLocalVariableTypeFromObjectPath(FName InVariableName, FString InCPPType, FString InCPPTypeObjectPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InCPPTypeObjectPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 25) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetLocalVariableTypeFromObjectPath, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetLocalVariableType(FName InVariableName, FString InCPPType, UObject InCPPTypeObject, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InCPPTypeObject?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 25) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetLocalVariableType, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetLocalVariableDefaultValue(FName InVariableName, FString InDefaultValue, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InDefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetLocalVariableDefaultValue, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetIsRunningUnitTest(bool bIsRunning)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsRunning;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIsRunningUnitTest, __InBuffer);
			}
		}

		public virtual void SetGraph(URigVMGraph InGraph)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InGraph?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGraph, __InBuffer);
			}
		}

		public virtual bool SetExposedPinIndex(FName InPinName, int InNewIndex, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[14];

				*(nint*)(__InBuffer) = InPinName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InNewIndex;

				*(bool*)(__InBuffer + 12) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 13) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetExposedPinIndex, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCommentTextByName(FName InNodeName, FString InCommentText, int InCommentFontSize, bool bInCommentBubbleVisible, bool bInCommentColorBubble, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCommentText?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = InCommentFontSize;

				*(bool*)(__InBuffer + 20) = bInCommentBubbleVisible;

				*(bool*)(__InBuffer + 21) = bInCommentColorBubble;

				*(bool*)(__InBuffer + 22) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 23) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCommentTextByName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCommentText(URigVMNode InNode, FString InCommentText, int InCommentFontSize, bool bInCommentBubbleVisible, bool bInCommentColorBubble, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCommentText?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = InCommentFontSize;

				*(bool*)(__InBuffer + 20) = bInCommentBubbleVisible;

				*(bool*)(__InBuffer + 21) = bInCommentColorBubble;

				*(bool*)(__InBuffer + 22) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 23) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCommentText, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetArrayPinSize(FString InArrayPinPath, int InSize, FString InDefaultValue = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InDefaultValue ??= new FString("");

				var __InBuffer = stackalloc byte[22];

				*(nint*)(__InBuffer) = InArrayPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InSize;

				*(nint*)(__InBuffer + 12) = InDefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 20) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 21) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetArrayPinSize, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SelectNodeByName(FName InNodeName, bool bSelect = true, bool bSetupUndoRedo = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSelect;

				*(bool*)(__InBuffer + 9) = bSetupUndoRedo;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SelectNodeByName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SelectNode(URigVMNode InNode, bool bSelect = true, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = InNode?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSelect;

				*(bool*)(__InBuffer + 9) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 10) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SelectNode, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool ResolveWildCardPin(FString InPinPath, FString InCPPType, FName InCPPTypeObjectPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InCPPTypeObjectPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 25) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ResolveWildCardPin, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool ResetPinDefaultValue(FString InPinPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ResetPinDefaultValue, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual URigVMVariableNode ReplaceParameterNodeWithVariable(FName InNodeName, FName InVariableName, FString InCPPType, UObject InCPPTypeObject, bool bSetupUndoRedo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InCPPTypeObject?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bSetupUndoRedo;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ReplaceParameterNodeWithVariable, __InBuffer, __ReturnBuffer);

				return *(URigVMVariableNode*)__ReturnBuffer;
			}
		}

		public virtual bool RenameVariable(FName InOldName, FName InNewName, bool bSetupUndoRedo = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InOldName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNewName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameVariable, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RenameParameter(FName InOldName, FName InNewName, bool bSetupUndoRedo = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InOldName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNewName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameParameter, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RenameNode(URigVMNode InNode, FName InNewName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNewName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameNode, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RenameLocalVariable(FName InVariableName, FName InNewVariableName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNewVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameLocalVariable, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RenameFunction(FName InOldFunctionName, FName InNewFunctionName, bool bSetupUndoRedo = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InOldFunctionName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNewFunctionName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameFunction, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RenameExposedPin(FName InOldPinName, FName InNewPinName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InOldPinName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNewPinName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameExposedPin, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveNodesByName(TArray<FName> InNodeNames, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InNodeNames?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveNodesByName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveNodes(TArray<URigVMNode> InNodes, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InNodes?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveNodes, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveNodeByName(FName InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveNodeByName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveNode(URigVMNode InNode, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InNode?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveNode, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveLocalVariable(FName InVariableName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveLocalVariable, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveInjectedNode(FString InPinPath, bool bAsInput, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = InPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAsInput;

				*(bool*)(__InBuffer + 9) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 10) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveInjectedNode, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveFunctionFromLibrary(FName InFunctionName, bool bSetupUndoRedo = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InFunctionName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveFunctionFromLibrary, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveExposedPin(FName InPinName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InPinName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveExposedPin, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveDecorator(FName InNodeName, FName InDecoratorName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InDecoratorName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveDecorator, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveArrayPin(FString InArrayElementPinPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InArrayElementPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveArrayPin, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveAggregatePin(FString InPinPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveAggregatePin, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void RefreshVariableNode(FName InNodeName, FName InVariableName, FString InCPPType, UObject InCPPTypeObject, bool bSetupUndoRedo, bool bSetupOrphanPins = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[34];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InCPPTypeObject?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 33) = bSetupOrphanPins;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RefreshVariableNode, __InBuffer);
			}
		}

		public virtual bool Redo()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __Redo, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool PushGraph(URigVMGraph InGraph, bool bSetupUndoRedo = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InGraph?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __PushGraph, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool PromotePinToVariable(FString InPinPath, bool bCreateVariableNode, FVector2D InNodePosition = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InNodePosition ??= new FVector2D();

				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bCreateVariableNode;

				*(nint*)(__InBuffer + 9) = InNodePosition?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 18) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __PromotePinToVariable, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FName PromoteFunctionReferenceNodeToCollapseNode(FName InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false, bool bRemoveFunctionDefinition = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				*(bool*)(__InBuffer + 10) = bRemoveFunctionDefinition;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __PromoteFunctionReferenceNodeToCollapseNode, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual FName PromoteCollapseNodeToFunctionReferenceNode(FName InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false, FString InExistingFunctionDefinitionPath = null)
		{
			unsafe
			{
				InExistingFunctionDefinitionPath ??= new FString("");

				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				*(nint*)(__InBuffer + 10) = InExistingFunctionDefinitionPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __PromoteCollapseNodeToFunctionReferenceNode, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual URigVMGraph PopGraph(bool bSetupUndoRedo = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bSetupUndoRedo;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __PopGraph, __InBuffer, __ReturnBuffer);

				return *(URigVMGraph*)__ReturnBuffer;
			}
		}

		public virtual bool PerformUserWorkflow(FRigVMUserWorkflow InWorkflow, URigVMUserWorkflowOptions InOptions, bool bSetupUndoRedo = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InWorkflow?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InOptions?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __PerformUserWorkflow, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool OpenUndoBracket(FString InTitle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTitle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __OpenUndoBracket, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool MarkFunctionAsPublic(FName InFunctionName, bool bInIsPublic, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = InFunctionName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bInIsPublic;

				*(bool*)(__InBuffer + 9) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 10) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __MarkFunctionAsPublic, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool MakeVariableNodeFromBinding(FString InPinPath, FVector2D InNodePosition = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InNodePosition ??= new FVector2D();

				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNodePosition?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __MakeVariableNodeFromBinding, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual URigVMUserWorkflowOptions MakeOptionsForWorkflow(UObject InSubject, FRigVMUserWorkflow InWorkflow)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InSubject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InWorkflow?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __MakeOptionsForWorkflow, __InBuffer, __ReturnBuffer);

				return *(URigVMUserWorkflowOptions*)__ReturnBuffer;
			}
		}

		public virtual bool MakeBindingsFromVariableNode(FName InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __MakeBindingsFromVariableNode, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TMap<FRigVMGraphFunctionIdentifier, URigVMLibraryNode> LocalizeFunctions(TArray<FRigVMGraphFunctionIdentifier> InFunctionDefinitions, bool bLocalizeDependentPrivateFunctions = true, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = InFunctionDefinitions?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bLocalizeDependentPrivateFunctions;

				*(bool*)(__InBuffer + 9) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 10) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __LocalizeFunctions, __InBuffer, __ReturnBuffer);

				return *(TMap<FRigVMGraphFunctionIdentifier, URigVMLibraryNode>*)__ReturnBuffer;
			}
		}

		public virtual URigVMLibraryNode LocalizeFunctionFromPath(FString InHostPath, FName InFunctionName, bool bLocalizeDependentPrivateFunctions = true, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InHostPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InFunctionName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bLocalizeDependentPrivateFunctions;

				*(bool*)(__InBuffer + 17) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 18) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __LocalizeFunctionFromPath, __InBuffer, __ReturnBuffer);

				return *(URigVMLibraryNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMLibraryNode LocalizeFunction(FRigVMGraphFunctionIdentifier InFunctionDefinition, bool bLocalizeDependentPrivateFunctions = true, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = InFunctionDefinition?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bLocalizeDependentPrivateFunctions;

				*(bool*)(__InBuffer + 9) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 10) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __LocalizeFunction, __InBuffer, __ReturnBuffer);

				return *(URigVMLibraryNode*)__ReturnBuffer;
			}
		}

		public virtual bool IsTransacting()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsTransacting, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsReportingEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsReportingEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsFunctionPublic(FName InFunctionName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFunctionName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsFunctionPublic, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FString InsertArrayPin(FString InArrayPinPath, int InIndex = -1, FString InDefaultValue = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InDefaultValue ??= new FString("");

				var __InBuffer = stackalloc byte[22];

				*(nint*)(__InBuffer) = InArrayPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InIndex;

				*(nint*)(__InBuffer + 12) = InDefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 20) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 21) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __InsertArrayPin, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual TArray<FName> ImportNodesFromText(FString InText, bool bSetupUndoRedo = true, bool bPrintPythonCommands = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InText?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommands;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ImportNodesFromText, __InBuffer, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		public static TArray<UScriptStruct> GetUnitStructsForTemplate(FName InNotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InNotation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetUnitStructsForTemplate, __InBuffer, __ReturnBuffer);

				return *(TArray<UScriptStruct>*)__ReturnBuffer;
			}
		}

		public virtual URigVMGraph GetTopLevelGraph()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTopLevelGraph, __ReturnBuffer);

				return *(URigVMGraph*)__ReturnBuffer;
			}
		}

		public static FString GetTemplateForUnitStruct(UScriptStruct InFunction, FString InMethodName = null)
		{
			unsafe
			{
				InMethodName ??= new FString("Execute");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InFunction?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMethodName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTemplateForUnitStruct, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual URigVMSchema GetSchema()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSchema, __ReturnBuffer);

				return *(URigVMSchema*)__ReturnBuffer;
			}
		}

		public static TArray<UScriptStruct> GetRegisteredUnitStructs()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetRegisteredUnitStructs, __ReturnBuffer);

				return *(TArray<UScriptStruct>*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetRegisteredTemplates()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetRegisteredTemplates, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public virtual FString GetPinDefaultValue(FString InPinPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPinPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetPinDefaultValue, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual URigVMGraph GetGraph()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetGraph, __ReturnBuffer);

				return *(URigVMGraph*)__ReturnBuffer;
			}
		}

		public virtual URigVMController GetControllerForGraph(URigVMGraph InGraph)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InGraph?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetControllerForGraph, __InBuffer, __ReturnBuffer);

				return *(URigVMController*)__ReturnBuffer;
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

		public virtual FString ExportSelectedNodesToText(bool bIncludeExteriorLinks = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIncludeExteriorLinks;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ExportSelectedNodesToText, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual FString ExportNodesToText(TArray<FName> InNodeNames, bool bIncludeExteriorLinks = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InNodeNames?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIncludeExteriorLinks;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ExportNodesToText, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual TArray<URigVMNode> ExpandLibraryNode(FName InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ExpandLibraryNode, __InBuffer, __ReturnBuffer);

				return *(TArray<URigVMNode>*)__ReturnBuffer;
			}
		}

		public virtual void EnableReporting(bool bEnabled = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __EnableReporting, __InBuffer);
			}
		}

		public virtual URigVMNode EjectNodeFromPin(FString InPinPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __EjectNodeFromPin, __InBuffer, __ReturnBuffer);

				return *(URigVMNode*)__ReturnBuffer;
			}
		}

		public virtual FString DuplicateArrayPin(FString InArrayElementPinPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InArrayElementPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __DuplicateArrayPin, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual URigVMCollapseNode CollapseNodes(TArray<FName> InNodeNames, FString InCollapseNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false, bool bIsAggregate = false)
		{
			unsafe
			{
				InCollapseNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InNodeNames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCollapseNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bPrintPythonCommand;

				*(bool*)(__InBuffer + 18) = bIsAggregate;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CollapseNodes, __InBuffer, __ReturnBuffer);

				return *(URigVMCollapseNode*)__ReturnBuffer;
			}
		}

		public virtual bool CloseUndoBracket()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __CloseUndoBracket, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool ClearNodeSelection(bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 1) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ClearNodeSelection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool ClearArrayPin(FString InArrayPinPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InArrayPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 9) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ClearArrayPin, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool ChangeExposedPinType(FName InPinName, FString InCPPType, FName InCPPTypeObjectPath, ref bool bSetupUndoRedo, bool bSetupOrphanPins, bool bPrintPythonCommand)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[27];

				*(nint*)(__InBuffer) = InPinName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InCPPTypeObjectPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 25) = bSetupOrphanPins;

				*(bool*)(__InBuffer + 26) = bPrintPythonCommand;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __ChangeExposedPinType, __InBuffer, __OutBuffer, __ReturnBuffer);

				bSetupUndoRedo = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool CanImportNodesFromText(FString InText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InText?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CanImportNodesFromText, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool CancelUndoBracket()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __CancelUndoBracket, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool BreakLink(FString InOutputPinPath, FString InInputPinPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InOutputPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InInputPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __BreakLink, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool BreakAllLinks(FString InPinPath, bool bAsInput = true, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = InPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAsInput;

				*(bool*)(__InBuffer + 9) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 10) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __BreakAllLinks, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool BindPinToVariable(FString InPinPath, FString InNewBoundVariablePath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNewBoundVariablePath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __BindPinToVariable, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual URigVMVariableNode AddVariableNodeFromObjectPath(FName InVariableName, FString InCPPType, FString InCPPTypeObjectPath, bool bIsGetter, FString InDefaultValue, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[51];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InCPPTypeObjectPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bIsGetter;

				*(nint*)(__InBuffer + 25) = InDefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 33) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 41) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 49) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 50) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddVariableNodeFromObjectPath, __InBuffer, __ReturnBuffer);

				return *(URigVMVariableNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMVariableNode AddVariableNode(FName InVariableName, FString InCPPType, UObject InCPPTypeObject, bool bIsGetter, FString InDefaultValue, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[51];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InCPPTypeObject?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bIsGetter;

				*(nint*)(__InBuffer + 25) = InDefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 33) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 41) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 49) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 50) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddVariableNode, __InBuffer, __ReturnBuffer);

				return *(URigVMVariableNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMUnitNode AddUnitNodeWithDefaults(UScriptStruct InScriptStruct, FString InDefaults, FName InMethodName = null, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InMethodName ??= new FName("Execute");

				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[42];

				*(nint*)(__InBuffer) = InScriptStruct?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InDefaults?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InMethodName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 40) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 41) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddUnitNodeWithDefaults, __InBuffer, __ReturnBuffer);

				return *(URigVMUnitNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMUnitNode AddUnitNodeFromStructPath(FString InScriptStructPath, FName InMethodName = null, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InMethodName ??= new FName("Execute");

				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[34];

				*(nint*)(__InBuffer) = InScriptStructPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMethodName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 33) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddUnitNodeFromStructPath, __InBuffer, __ReturnBuffer);

				return *(URigVMUnitNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMUnitNode AddUnitNode(UScriptStruct InScriptStruct, FName InMethodName = null, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InMethodName ??= new FName("Execute");

				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[34];

				*(nint*)(__InBuffer) = InScriptStruct?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMethodName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 33) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddUnitNode, __InBuffer, __ReturnBuffer);

				return *(URigVMUnitNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMTemplateNode AddTemplateNode(FName InNotation, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InNotation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 25) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddTemplateNode, __InBuffer, __ReturnBuffer);

				return *(URigVMTemplateNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMNode AddSelectNodeFromStruct(UScriptStruct InScriptStruct, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true)
		{
			unsafe
			{
				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = InScriptStruct?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bSetupUndoRedo;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddSelectNodeFromStruct, __InBuffer, __ReturnBuffer);

				return *(URigVMNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMNode AddSelectNode(FString InCPPType, FName InCPPTypeObjectPath, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[34];

				*(nint*)(__InBuffer) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCPPTypeObjectPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 33) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddSelectNode, __InBuffer, __ReturnBuffer);

				return *(URigVMNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMRerouteNode AddRerouteNodeOnPin(FString InPinPath, bool bAsInput, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[27];

				*(nint*)(__InBuffer) = InPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAsInput;

				*(nint*)(__InBuffer + 9) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 25) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 26) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddRerouteNodeOnPin, __InBuffer, __ReturnBuffer);

				return *(URigVMRerouteNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMRerouteNode AddRerouteNodeOnLinkPath(FString InLinkPinPathRepresentation, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InLinkPinPathRepresentation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 25) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddRerouteNodeOnLinkPath, __InBuffer, __ReturnBuffer);

				return *(URigVMRerouteNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMRerouteNode AddRerouteNodeOnLink(URigVMLink InLink, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InLink?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 25) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddRerouteNodeOnLink, __InBuffer, __ReturnBuffer);

				return *(URigVMRerouteNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMParameterNode AddParameterNodeFromObjectPath(FName InParameterName, FString InCPPType, FString InCPPTypeObjectPath, bool bIsInput, FString InDefaultValue, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[51];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InCPPTypeObjectPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bIsInput;

				*(nint*)(__InBuffer + 25) = InDefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 33) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 41) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 49) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 50) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddParameterNodeFromObjectPath, __InBuffer, __ReturnBuffer);

				return *(URigVMParameterNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMParameterNode AddParameterNode(FName InParameterName, FString InCPPType, UObject InCPPTypeObject, bool bIsInput, FString InDefaultValue, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[51];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InCPPTypeObject?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bIsInput;

				*(nint*)(__InBuffer + 25) = InDefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 33) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 41) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 49) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 50) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddParameterNode, __InBuffer, __ReturnBuffer);

				return *(URigVMParameterNode*)__ReturnBuffer;
			}
		}

		public virtual FRigVMGraphVariableDescription AddLocalVariableFromObjectPath(FName InVariableName, FString InCPPType, FString InCPPTypeObjectPath, FString InDefaultValue, bool bSetupUndoRedo = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InCPPTypeObjectPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InDefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bSetupUndoRedo;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddLocalVariableFromObjectPath, __InBuffer, __ReturnBuffer);

				return *(FRigVMGraphVariableDescription*)__ReturnBuffer;
			}
		}

		public virtual FRigVMGraphVariableDescription AddLocalVariable(FName InVariableName, FString InCPPType, UObject InCPPTypeObject, FString InDefaultValue, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[34];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InCPPTypeObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InDefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 33) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddLocalVariable, __InBuffer, __ReturnBuffer);

				return *(FRigVMGraphVariableDescription*)__ReturnBuffer;
			}
		}

		public virtual bool AddLink(FString InOutputPinPath, FString InInputPinPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false, ERigVMPinDirection InUserDirection = ERigVMPinDirection.Output, bool bCreateCastNode = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InOutputPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InInputPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bPrintPythonCommand;

				*(byte*)(__InBuffer + 18) = (byte)InUserDirection;

				*(bool*)(__InBuffer + 19) = bCreateCastNode;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddLink, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual URigVMInvokeEntryNode AddInvokeEntryNode(FName InEntryName, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InEntryName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 25) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddInvokeEntryNode, __InBuffer, __ReturnBuffer);

				return *(URigVMInvokeEntryNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMInjectionInfo AddInjectedNodeFromStructPath(FString InPinPath, bool bAsInput, FString InScriptStructPath, FName InMethodName, FName InInputPinName, FName InOutputPinName, FString InNodeName = null, bool bSetupUndoRedo = true)
		{
			unsafe
			{
				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[50];

				*(nint*)(__InBuffer) = InPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAsInput;

				*(nint*)(__InBuffer + 9) = InScriptStructPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = InMethodName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 25) = InInputPinName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 33) = InOutputPinName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 41) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 49) = bSetupUndoRedo;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddInjectedNodeFromStructPath, __InBuffer, __ReturnBuffer);

				return *(URigVMInjectionInfo*)__ReturnBuffer;
			}
		}

		public virtual URigVMInjectionInfo AddInjectedNode(FString InPinPath, bool bAsInput, UScriptStruct InScriptStruct, FName InMethodName, FName InInputPinName, FName InOutputPinName, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[51];

				*(nint*)(__InBuffer) = InPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAsInput;

				*(nint*)(__InBuffer + 9) = InScriptStruct?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = InMethodName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 25) = InInputPinName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 33) = InOutputPinName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 41) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 49) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 50) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddInjectedNode, __InBuffer, __ReturnBuffer);

				return *(URigVMInjectionInfo*)__ReturnBuffer;
			}
		}

		public virtual URigVMNode AddIfNodeFromStruct(UScriptStruct InScriptStruct, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true)
		{
			unsafe
			{
				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = InScriptStruct?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bSetupUndoRedo;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddIfNodeFromStruct, __InBuffer, __ReturnBuffer);

				return *(URigVMNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMNode AddIfNode(FString InCPPType, FName InCPPTypeObjectPath, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[34];

				*(nint*)(__InBuffer) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCPPTypeObjectPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 33) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddIfNode, __InBuffer, __ReturnBuffer);

				return *(URigVMNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMLibraryNode AddFunctionToLibrary(FName InFunctionName, bool bMutable, FVector2D InNodePosition = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InNodePosition ??= new FVector2D();

				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = InFunctionName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bMutable;

				*(nint*)(__InBuffer + 9) = InNodePosition?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 17) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 18) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddFunctionToLibrary, __InBuffer, __ReturnBuffer);

				return *(URigVMLibraryNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMFunctionReferenceNode AddFunctionReferenceNodeFromDescription(FRigVMGraphFunctionHeader InFunctionDefinition, FVector2D InNodePosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InNodePosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InFunctionDefinition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNodePosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 25) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddFunctionReferenceNodeFromDescription, __InBuffer, __ReturnBuffer);

				return *(URigVMFunctionReferenceNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMFunctionReferenceNode AddFunctionReferenceNode(URigVMLibraryNode InFunctionDefinition, FVector2D InNodePosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InNodePosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InFunctionDefinition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNodePosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 25) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddFunctionReferenceNode, __InBuffer, __ReturnBuffer);

				return *(URigVMFunctionReferenceNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMRerouteNode AddFreeRerouteNode(FString InCPPType, FName InCPPTypeObjectPath, bool bIsConstant, FName InCustomWidgetName, FString InDefaultValue, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true)
		{
			unsafe
			{
				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[50];

				*(nint*)(__InBuffer) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCPPTypeObjectPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bIsConstant;

				*(nint*)(__InBuffer + 17) = InCustomWidgetName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 25) = InDefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 33) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 41) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 49) = bSetupUndoRedo;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddFreeRerouteNode, __InBuffer, __ReturnBuffer);

				return *(URigVMRerouteNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMFunctionReferenceNode AddExternalFunctionReferenceNode(FString InHostPath, FName InFunctionName, FVector2D InNodePosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InNodePosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[34];

				*(nint*)(__InBuffer) = InHostPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InFunctionName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InNodePosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 33) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddExternalFunctionReferenceNode, __InBuffer, __ReturnBuffer);

				return *(URigVMFunctionReferenceNode*)__ReturnBuffer;
			}
		}

		public virtual FName AddExposedPin(FName InPinName, ERigVMPinDirection InDirection, FString InCPPType, FName InCPPTypeObjectPath, FString InDefaultValue, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[35];

				*(nint*)(__InBuffer) = InPinName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InDirection;

				*(nint*)(__InBuffer + 9) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = InCPPTypeObjectPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 25) = InDefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 33) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 34) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddExposedPin, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual URigVMEnumNode AddEnumNode(FName InCPPTypeObjectPath, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InCPPTypeObjectPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 25) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddEnumNode, __InBuffer, __ReturnBuffer);

				return *(URigVMEnumNode*)__ReturnBuffer;
			}
		}

		public virtual FName AddDecorator(FName InNodeName, FName InDecoratorTypeObjectPath, FName InDecoratorName = null, FString InDefaultValue = null, int InPinIndex = -1, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InDecoratorName ??= new FName("None");

				InDefaultValue ??= new FString("");

				var __InBuffer = stackalloc byte[38];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InDecoratorTypeObjectPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InDecoratorName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InDefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 32) = InPinIndex;

				*(bool*)(__InBuffer + 36) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 37) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddDecorator, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual URigVMCommentNode AddCommentNode(FString InCommentText, FVector2D InPosition = null, FVector2D InSize = null, FLinearColor InColor = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InPosition ??= new FVector2D();

				InSize ??= new FVector2D(400.000000, 300.000000);

				InColor ??= new FLinearColor(0.000000f, 0.000000f, 0.000000f, 1.000000f);

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[42];

				*(nint*)(__InBuffer) = InCommentText?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InSize?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 40) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 41) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddCommentNode, __InBuffer, __ReturnBuffer);

				return *(URigVMCommentNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMNode AddBranchNode(FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddBranchNode, __InBuffer, __ReturnBuffer);

				return *(URigVMNode*)__ReturnBuffer;
			}
		}

		public virtual FString AddArrayPin(FString InArrayPinPath, FString InDefaultValue = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InDefaultValue ??= new FString("");

				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InArrayPinPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InDefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 17) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddArrayPin, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual URigVMNode AddArrayNodeFromObjectPath(ERigVMOpCode InOpCode, FString InCPPType, FString InCPPTypeObjectPath, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false, bool bIsPatching = false)
		{
			unsafe
			{
				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[36];

				*(byte*)(__InBuffer) = (byte)InOpCode;

				*(nint*)(__InBuffer + 1) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 9) = InCPPTypeObjectPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 25) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 33) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 34) = bPrintPythonCommand;

				*(bool*)(__InBuffer + 35) = bIsPatching;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddArrayNodeFromObjectPath, __InBuffer, __ReturnBuffer);

				return *(URigVMNode*)__ReturnBuffer;
			}
		}

		public virtual URigVMNode AddArrayNode(ERigVMOpCode InOpCode, FString InCPPType, UObject InCPPTypeObject, FVector2D InPosition = null, FString InNodeName = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false, bool bIsPatching = false)
		{
			unsafe
			{
				InPosition ??= new FVector2D();

				InNodeName ??= new FString("");

				var __InBuffer = stackalloc byte[36];

				*(byte*)(__InBuffer) = (byte)InOpCode;

				*(nint*)(__InBuffer + 1) = InCPPType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 9) = InCPPTypeObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 25) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 33) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 34) = bPrintPythonCommand;

				*(bool*)(__InBuffer + 35) = bIsPatching;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddArrayNode, __InBuffer, __ReturnBuffer);

				return *(URigVMNode*)__ReturnBuffer;
			}
		}

		public virtual FString AddAggregatePin(FString InNodeName, FString InPinName, FString InDefaultValue = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
		{
			unsafe
			{
				InDefaultValue ??= new FString("");

				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPinName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InDefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bSetupUndoRedo;

				*(bool*)(__InBuffer + 25) = bPrintPythonCommand;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddAggregatePin, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __ModifiedEventDynamic = 0;

		private static uint __Graphs = 0;

		private static uint __SchemaPtr = 0;

		private static uint __UpgradeNodes = 0;

		private static uint __UnresolveTemplateNodes = 0;

		private static uint __Undo = 0;

		private static uint __UnbindPinFromVariable = 0;

		private static uint __SetUnitNodeDefaults = 0;

		private static uint __SetSchema = 0;

		private static uint __SetRemappedVariable = 0;

		private static uint __SetPinIsWatched = 0;

		private static uint __SetPinExpansion = 0;

		private static uint __SetPinDefaultValue = 0;

		private static uint __SetNodeSizeByName = 0;

		private static uint __SetNodeSize = 0;

		private static uint __SetNodeSelection = 0;

		private static uint __SetNodePositionByName = 0;

		private static uint __SetNodePosition = 0;

		private static uint __SetNodeKeywordsByName = 0;

		private static uint __SetNodeKeywords = 0;

		private static uint __SetNodeDescriptionByName = 0;

		private static uint __SetNodeDescription = 0;

		private static uint __SetNodeColorByName = 0;

		private static uint __SetNodeColor = 0;

		private static uint __SetNodeCategoryByName = 0;

		private static uint __SetNodeCategory = 0;

		private static uint __SetLocalVariableTypeFromObjectPath = 0;

		private static uint __SetLocalVariableType = 0;

		private static uint __SetLocalVariableDefaultValue = 0;

		private static uint __SetIsRunningUnitTest = 0;

		private static uint __SetGraph = 0;

		private static uint __SetExposedPinIndex = 0;

		private static uint __SetCommentTextByName = 0;

		private static uint __SetCommentText = 0;

		private static uint __SetArrayPinSize = 0;

		private static uint __SelectNodeByName = 0;

		private static uint __SelectNode = 0;

		private static uint __ResolveWildCardPin = 0;

		private static uint __ResetPinDefaultValue = 0;

		private static uint __ReplaceParameterNodeWithVariable = 0;

		private static uint __RenameVariable = 0;

		private static uint __RenameParameter = 0;

		private static uint __RenameNode = 0;

		private static uint __RenameLocalVariable = 0;

		private static uint __RenameFunction = 0;

		private static uint __RenameExposedPin = 0;

		private static uint __RemoveNodesByName = 0;

		private static uint __RemoveNodes = 0;

		private static uint __RemoveNodeByName = 0;

		private static uint __RemoveNode = 0;

		private static uint __RemoveLocalVariable = 0;

		private static uint __RemoveInjectedNode = 0;

		private static uint __RemoveFunctionFromLibrary = 0;

		private static uint __RemoveExposedPin = 0;

		private static uint __RemoveDecorator = 0;

		private static uint __RemoveArrayPin = 0;

		private static uint __RemoveAggregatePin = 0;

		private static uint __RefreshVariableNode = 0;

		private static uint __Redo = 0;

		private static uint __PushGraph = 0;

		private static uint __PromotePinToVariable = 0;

		private static uint __PromoteFunctionReferenceNodeToCollapseNode = 0;

		private static uint __PromoteCollapseNodeToFunctionReferenceNode = 0;

		private static uint __PopGraph = 0;

		private static uint __PerformUserWorkflow = 0;

		private static uint __OpenUndoBracket = 0;

		private static uint __MarkFunctionAsPublic = 0;

		private static uint __MakeVariableNodeFromBinding = 0;

		private static uint __MakeOptionsForWorkflow = 0;

		private static uint __MakeBindingsFromVariableNode = 0;

		private static uint __LocalizeFunctions = 0;

		private static uint __LocalizeFunctionFromPath = 0;

		private static uint __LocalizeFunction = 0;

		private static uint __IsTransacting = 0;

		private static uint __IsReportingEnabled = 0;

		private static uint __IsFunctionPublic = 0;

		private static uint __InsertArrayPin = 0;

		private static uint __ImportNodesFromText = 0;

		private static uint __GetUnitStructsForTemplate = 0;

		private static uint __GetTopLevelGraph = 0;

		private static uint __GetTemplateForUnitStruct = 0;

		private static uint __GetSchema = 0;

		private static uint __GetRegisteredUnitStructs = 0;

		private static uint __GetRegisteredTemplates = 0;

		private static uint __GetPinDefaultValue = 0;

		private static uint __GetGraph = 0;

		private static uint __GetControllerForGraph = 0;

		private static uint __GeneratePythonCommands = 0;

		private static uint __ExportSelectedNodesToText = 0;

		private static uint __ExportNodesToText = 0;

		private static uint __ExpandLibraryNode = 0;

		private static uint __EnableReporting = 0;

		private static uint __EjectNodeFromPin = 0;

		private static uint __DuplicateArrayPin = 0;

		private static uint __CollapseNodes = 0;

		private static uint __CloseUndoBracket = 0;

		private static uint __ClearNodeSelection = 0;

		private static uint __ClearArrayPin = 0;

		private static uint __ChangeExposedPinType = 0;

		private static uint __CanImportNodesFromText = 0;

		private static uint __CancelUndoBracket = 0;

		private static uint __BreakLink = 0;

		private static uint __BreakAllLinks = 0;

		private static uint __BindPinToVariable = 0;

		private static uint __AddVariableNodeFromObjectPath = 0;

		private static uint __AddVariableNode = 0;

		private static uint __AddUnitNodeWithDefaults = 0;

		private static uint __AddUnitNodeFromStructPath = 0;

		private static uint __AddUnitNode = 0;

		private static uint __AddTemplateNode = 0;

		private static uint __AddSelectNodeFromStruct = 0;

		private static uint __AddSelectNode = 0;

		private static uint __AddRerouteNodeOnPin = 0;

		private static uint __AddRerouteNodeOnLinkPath = 0;

		private static uint __AddRerouteNodeOnLink = 0;

		private static uint __AddParameterNodeFromObjectPath = 0;

		private static uint __AddParameterNode = 0;

		private static uint __AddLocalVariableFromObjectPath = 0;

		private static uint __AddLocalVariable = 0;

		private static uint __AddLink = 0;

		private static uint __AddInvokeEntryNode = 0;

		private static uint __AddInjectedNodeFromStructPath = 0;

		private static uint __AddInjectedNode = 0;

		private static uint __AddIfNodeFromStruct = 0;

		private static uint __AddIfNode = 0;

		private static uint __AddFunctionToLibrary = 0;

		private static uint __AddFunctionReferenceNodeFromDescription = 0;

		private static uint __AddFunctionReferenceNode = 0;

		private static uint __AddFreeRerouteNode = 0;

		private static uint __AddExternalFunctionReferenceNode = 0;

		private static uint __AddExposedPin = 0;

		private static uint __AddEnumNode = 0;

		private static uint __AddDecorator = 0;

		private static uint __AddCommentNode = 0;

		private static uint __AddBranchNode = 0;

		private static uint __AddArrayPin = 0;

		private static uint __AddArrayNodeFromObjectPath = 0;

		private static uint __AddArrayNode = 0;

		private static uint __AddAggregatePin = 0;
	}
}