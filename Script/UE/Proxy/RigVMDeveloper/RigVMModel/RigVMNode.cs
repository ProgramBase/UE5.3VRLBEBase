using Script.CoreUObject;
using Script.RigVM;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMNode")]
	public partial class URigVMNode : UObject, IStaticClass
	{
		public FString NodeTitle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NodeTitle, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NodeTitle, __InBuffer);
				}
			}
		}

		public FVector2D Position
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Position, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Position, __InBuffer);
				}
			}
		}

		public FVector2D Size
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Size, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Size, __InBuffer);
				}
			}
		}

		public FLinearColor NodeColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NodeColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NodeColor, __InBuffer);
				}
			}
		}

		public FName PreviousName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviousName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviousName, __InBuffer);
				}
			}
		}

		public bool bHasBreakpoint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasBreakpoint, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasBreakpoint, __InBuffer);
				}
			}
		}

		public bool bHaltedAtThisNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHaltedAtThisNode, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHaltedAtThisNode, __InBuffer);
				}
			}
		}

		public TArray<FString> DecoratorRootPinNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DecoratorRootPinNames, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DecoratorRootPinNames, __InBuffer);
				}
			}
		}

		public TArray<URigVMPin> Pins
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Pins, __ReturnBuffer);

					return *(TArray<URigVMPin>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Pins, __InBuffer);
				}
			}
		}

		public TArray<URigVMPin> OrphanedPins
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OrphanedPins, __ReturnBuffer);

					return *(TArray<URigVMPin>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OrphanedPins, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetHasBreakpoint(bool bValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetHasBreakpoint, __InBuffer);
			}
		}

		public virtual void SetExecutionIsHaltedAtThisNode(bool bValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetExecutionIsHaltedAtThisNode, __InBuffer);
			}
		}

		public virtual bool IsVisibleInUI()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsVisibleInUI, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsSelected()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsSelected, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsPure()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPure, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsMutable()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsMutable, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsLoopNode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsLoopNode, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsLinkedTo(URigVMNode InNode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InNode?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsLinkedTo, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsInputAggregate()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsInputAggregate, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsInjected()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsInjected, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsEvent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsEvent, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsDefinedAsVarying()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsDefinedAsVarying, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsDefinedAsConstant()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsDefinedAsConstant, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsDecoratorPin(FName InName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsDecoratorPin, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsControlFlowNode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsControlFlowNode, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsAggregate()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsAggregate, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasPinOfDirection(ERigVMPinDirection InDirection)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InDirection;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasPinOfDirection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasOutputPin(bool bIncludeIO = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIncludeIO;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasOutputPin, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasOrphanedPins()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasOrphanedPins, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasLazyPin(bool bOnlyConsiderPinsWithLinks = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bOnlyConsiderPinsWithLinks;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasLazyPin, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasIOPin()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasIOPin, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasInputPin(bool bIncludeIO = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIncludeIO;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasInputPin, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasBreakpoint()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasBreakpoint, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FText GetToolTipText()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetToolTipText, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public virtual TArray<FRigVMUserWorkflow> GetSupportedWorkflows(ERigVMUserWorkflowType InType, UObject InSubject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)InType;

				*(nint*)(__InBuffer + 1) = InSubject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSupportedWorkflows, __InBuffer, __ReturnBuffer);

				return *(TArray<FRigVMUserWorkflow>*)__ReturnBuffer;
			}
		}

		public virtual FVector2D GetSize()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSize, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public virtual URigVMPin GetSecondAggregatePin()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSecondAggregatePin, __ReturnBuffer);

				return *(URigVMPin*)__ReturnBuffer;
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

		public virtual FName GetPreviousFName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPreviousFName, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual FVector2D GetPosition()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPosition, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public virtual TArray<URigVMPin> GetPins()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPins, __ReturnBuffer);

				return *(TArray<URigVMPin>*)__ReturnBuffer;
			}
		}

		public virtual TArray<URigVMPin> GetOrphanedPins()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOrphanedPins, __ReturnBuffer);

				return *(TArray<URigVMPin>*)__ReturnBuffer;
			}
		}

		public virtual URigVMPin GetOppositeAggregatePin()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOppositeAggregatePin, __ReturnBuffer);

				return *(URigVMPin*)__ReturnBuffer;
			}
		}

		public virtual FString GetNodeTitle()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetNodeTitle, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual FString GetNodePath(bool bRecursive = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bRecursive;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetNodePath, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual int GetNodeIndex()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNodeIndex, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual FLinearColor GetNodeColor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetNodeColor, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public virtual FName GetNextAggregateName(FName InLastAggregatePinName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InLastAggregatePinName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetNextAggregateName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
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

		public virtual TArray<URigVMNode> GetLinkedTargetNodes()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLinkedTargetNodes, __ReturnBuffer);

				return *(TArray<URigVMNode>*)__ReturnBuffer;
			}
		}

		public virtual TArray<URigVMNode> GetLinkedSourceNodes()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLinkedSourceNodes, __ReturnBuffer);

				return *(TArray<URigVMNode>*)__ReturnBuffer;
			}
		}

		public virtual URigVMInjectionInfo GetInjectionInfo()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetInjectionInfo, __ReturnBuffer);

				return *(URigVMInjectionInfo*)__ReturnBuffer;
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

		public virtual URigVMGraph GetGraph()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetGraph, __ReturnBuffer);

				return *(URigVMGraph*)__ReturnBuffer;
			}
		}

		public virtual URigVMPin GetFirstAggregatePin()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetFirstAggregatePin, __ReturnBuffer);

				return *(URigVMPin*)__ReturnBuffer;
			}
		}

		public virtual FName GetEventName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetEventName, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual TArray<URigVMPin> GetDecoratorPins()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDecoratorPins, __ReturnBuffer);

				return *(TArray<URigVMPin>*)__ReturnBuffer;
			}
		}

		public virtual TArray<URigVMPin> GetAllPinsRecursively()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAllPinsRecursively, __ReturnBuffer);

				return *(TArray<URigVMPin>*)__ReturnBuffer;
			}
		}

		public virtual TArray<URigVMPin> GetAggregateOutputs()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAggregateOutputs, __ReturnBuffer);

				return *(TArray<URigVMPin>*)__ReturnBuffer;
			}
		}

		public virtual TArray<URigVMPin> GetAggregateInputs()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAggregateInputs, __ReturnBuffer);

				return *(TArray<URigVMPin>*)__ReturnBuffer;
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

		public virtual URigVMLibraryNode FindFunctionForNode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __FindFunctionForNode, __ReturnBuffer);

				return *(URigVMLibraryNode*)__ReturnBuffer;
			}
		}

		public virtual bool ExecutionIsHaltedAtThisNode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __ExecutionIsHaltedAtThisNode, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool CanOnlyExistOnce()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __CanOnlyExistOnce, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool CanBeUpgraded()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __CanBeUpgraded, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __NodeTitle = 0;

		private static uint __Position = 0;

		private static uint __Size = 0;

		private static uint __NodeColor = 0;

		private static uint __PreviousName = 0;

		private static uint __bHasBreakpoint = 0;

		private static uint __bHaltedAtThisNode = 0;

		private static uint __DecoratorRootPinNames = 0;

		private static uint __Pins = 0;

		private static uint __OrphanedPins = 0;

		private static uint __SetHasBreakpoint = 0;

		private static uint __SetExecutionIsHaltedAtThisNode = 0;

		private static uint __IsVisibleInUI = 0;

		private static uint __IsSelected = 0;

		private static uint __IsPure = 0;

		private static uint __IsMutable = 0;

		private static uint __IsLoopNode = 0;

		private static uint __IsLinkedTo = 0;

		private static uint __IsInputAggregate = 0;

		private static uint __IsInjected = 0;

		private static uint __IsEvent = 0;

		private static uint __IsDefinedAsVarying = 0;

		private static uint __IsDefinedAsConstant = 0;

		private static uint __IsDecoratorPin = 0;

		private static uint __IsControlFlowNode = 0;

		private static uint __IsAggregate = 0;

		private static uint __HasPinOfDirection = 0;

		private static uint __HasOutputPin = 0;

		private static uint __HasOrphanedPins = 0;

		private static uint __HasLazyPin = 0;

		private static uint __HasIOPin = 0;

		private static uint __HasInputPin = 0;

		private static uint __HasBreakpoint = 0;

		private static uint __GetToolTipText = 0;

		private static uint __GetSupportedWorkflows = 0;

		private static uint __GetSize = 0;

		private static uint __GetSecondAggregatePin = 0;

		private static uint __GetRootGraph = 0;

		private static uint __GetPreviousFName = 0;

		private static uint __GetPosition = 0;

		private static uint __GetPins = 0;

		private static uint __GetOrphanedPins = 0;

		private static uint __GetOppositeAggregatePin = 0;

		private static uint __GetNodeTitle = 0;

		private static uint __GetNodePath = 0;

		private static uint __GetNodeIndex = 0;

		private static uint __GetNodeColor = 0;

		private static uint __GetNextAggregateName = 0;

		private static uint __GetLinks = 0;

		private static uint __GetLinkedTargetNodes = 0;

		private static uint __GetLinkedSourceNodes = 0;

		private static uint __GetInjectionInfo = 0;

		private static uint __GetGraphDepth = 0;

		private static uint __GetGraph = 0;

		private static uint __GetFirstAggregatePin = 0;

		private static uint __GetEventName = 0;

		private static uint __GetDecoratorPins = 0;

		private static uint __GetAllPinsRecursively = 0;

		private static uint __GetAggregateOutputs = 0;

		private static uint __GetAggregateInputs = 0;

		private static uint __FindPin = 0;

		private static uint __FindFunctionForNode = 0;

		private static uint __ExecutionIsHaltedAtThisNode = 0;

		private static uint __CanOnlyExistOnce = 0;

		private static uint __CanBeUpgraded = 0;
	}
}