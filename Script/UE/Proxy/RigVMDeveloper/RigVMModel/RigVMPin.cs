using Script.CoreUObject;
using Script.RigVM;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMPin")]
	public partial class URigVMPin : UObject, IStaticClass
	{
		public FName DisplayName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DisplayName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DisplayName, __InBuffer);
				}
			}
		}

		public ERigVMPinDirection Direction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Direction, __ReturnBuffer);

					return *(ERigVMPinDirection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Direction, __InBuffer);
				}
			}
		}

		public bool bIsExpanded
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsExpanded, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsExpanded, __InBuffer);
				}
			}
		}

		public bool bIsConstant
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsConstant, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsConstant, __InBuffer);
				}
			}
		}

		public bool bRequiresWatch
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRequiresWatch, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRequiresWatch, __InBuffer);
				}
			}
		}

		public bool bIsDynamicArray
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsDynamicArray, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsDynamicArray, __InBuffer);
				}
			}
		}

		public FString CPPType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CPPType, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CPPType, __InBuffer);
				}
			}
		}

		public UObject CPPTypeObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CPPTypeObject, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CPPTypeObject, __InBuffer);
				}
			}
		}

		public FName CPPTypeObjectPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CPPTypeObjectPath, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CPPTypeObjectPath, __InBuffer);
				}
			}
		}

		public FString DefaultValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultValue, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultValue, __InBuffer);
				}
			}
		}

		public FName CustomWidgetName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CustomWidgetName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CustomWidgetName, __InBuffer);
				}
			}
		}

		public TArray<URigVMPin> SubPins
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SubPins, __ReturnBuffer);

					return *(TArray<URigVMPin>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SubPins, __InBuffer);
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

		public TArray<URigVMInjectionInfo> InjectionInfos
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InjectionInfos, __ReturnBuffer);

					return *(TArray<URigVMInjectionInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InjectionInfos, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMPin");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool ShouldOnlyShowSubPins()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __ShouldOnlyShowSubPins, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool ShouldHideSubPins()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __ShouldHideSubPins, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RequiresWatch(bool bCheckExposedPinChain = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bCheckExposedPinChain;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RequiresWatch, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsWildCard()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsWildCard, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsUObject()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsUObject, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsStructMember()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsStructMember, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsStruct()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsStruct, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsStringType()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsStringType, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsRootPin()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsRootPin, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsReferenceCountedContainer()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsReferenceCountedContainer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsLinkedTo(URigVMPin InPin)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPin?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsLinkedTo, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsLazy()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsLazy, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsInterface()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsInterface, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsFixedSizeArray()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsFixedSizeArray, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsExpanded()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsExpanded, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsExecuteContext()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsExecuteContext, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsEnum()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsEnum, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsDynamicArray()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsDynamicArray, __ReturnBuffer);

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

		public virtual bool IsDecoratorPin()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsDecoratorPin, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsArrayElement()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsArrayElement, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsArray()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsArray, __ReturnBuffer);

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

		public virtual TArray<URigVMLink> GetTargetLinks(bool bRecursive = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bRecursive;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTargetLinks, __InBuffer, __ReturnBuffer);

				return *(TArray<URigVMLink>*)__ReturnBuffer;
			}
		}

		public virtual TArray<URigVMPin> GetSubPins()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSubPins, __ReturnBuffer);

				return *(TArray<URigVMPin>*)__ReturnBuffer;
			}
		}

		public virtual FString GetSubPinPath(URigVMPin InParentPin, bool bIncludeParentPinName = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InParentPin?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIncludeParentPinName;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSubPinPath, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual TArray<URigVMLink> GetSourceLinks(bool bRecursive = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bRecursive;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSourceLinks, __InBuffer, __ReturnBuffer);

				return *(TArray<URigVMLink>*)__ReturnBuffer;
			}
		}

		public virtual FString GetSegmentPath(bool bIncludeRootPin = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIncludeRootPin;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSegmentPath, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual UScriptStruct GetScriptStruct()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetScriptStruct, __ReturnBuffer);

				return *(UScriptStruct*)__ReturnBuffer;
			}
		}

		public virtual URigVMPin GetRootPin()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRootPin, __ReturnBuffer);

				return *(URigVMPin*)__ReturnBuffer;
			}
		}

		public virtual FString GetPinPath(bool bUseNodePath = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bUseNodePath;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetPinPath, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual int GetPinIndex()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPinIndex, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual URigVMPin GetPinForLink()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPinForLink, __ReturnBuffer);

				return *(URigVMPin*)__ReturnBuffer;
			}
		}

		public virtual URigVMPin GetParentPin()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetParentPin, __ReturnBuffer);

				return *(URigVMPin*)__ReturnBuffer;
			}
		}

		public virtual URigVMPin GetOriginalPinFromInjectedNode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOriginalPinFromInjectedNode, __ReturnBuffer);

				return *(URigVMPin*)__ReturnBuffer;
			}
		}

		public virtual URigVMNode GetNode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetNode, __ReturnBuffer);

				return *(URigVMNode*)__ReturnBuffer;
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

		public virtual TArray<URigVMPin> GetLinkedTargetPins(bool bRecursive = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bRecursive;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLinkedTargetPins, __InBuffer, __ReturnBuffer);

				return *(TArray<URigVMPin>*)__ReturnBuffer;
			}
		}

		public virtual TArray<URigVMPin> GetLinkedSourcePins(bool bRecursive = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bRecursive;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLinkedSourcePins, __InBuffer, __ReturnBuffer);

				return *(TArray<URigVMPin>*)__ReturnBuffer;
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

		public virtual UEnum GetEnum()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetEnum, __ReturnBuffer);

				return *(UEnum*)__ReturnBuffer;
			}
		}

		public virtual FName GetDisplayName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDisplayName, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual ERigVMPinDirection GetDirection()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDirection, __ReturnBuffer);

				return *(ERigVMPinDirection*)__ReturnBuffer;
			}
		}

		public virtual FString GetDefaultValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDefaultValue, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual FName GetCustomWidgetName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCustomWidgetName, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual UObject GetCPPTypeObject()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCPPTypeObject, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public virtual FString GetCPPType()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCPPType, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual int GetArraySize()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetArraySize, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual FString GetArrayElementCppType()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetArrayElementCppType, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual int GetAbsolutePinIndex()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAbsolutePinIndex, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual URigVMPin FindSubPin(FString InPinPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPinPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindSubPin, __InBuffer, __ReturnBuffer);

				return *(URigVMPin*)__ReturnBuffer;
			}
		}

		public virtual URigVMLink FindLinkForPin(URigVMPin InOtherPin)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InOtherPin?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindLinkForPin, __InBuffer, __ReturnBuffer);

				return *(URigVMLink*)__ReturnBuffer;
			}
		}

		public virtual bool ContainsWildCardSubPin()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __ContainsWildCardSubPin, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __DisplayName = 0;

		private static uint __Direction = 0;

		private static uint __bIsExpanded = 0;

		private static uint __bIsConstant = 0;

		private static uint __bRequiresWatch = 0;

		private static uint __bIsDynamicArray = 0;

		private static uint __CPPType = 0;

		private static uint __CPPTypeObject = 0;

		private static uint __CPPTypeObjectPath = 0;

		private static uint __DefaultValue = 0;

		private static uint __CustomWidgetName = 0;

		private static uint __SubPins = 0;

		private static uint __Links = 0;

		private static uint __InjectionInfos = 0;

		private static uint __ShouldOnlyShowSubPins = 0;

		private static uint __ShouldHideSubPins = 0;

		private static uint __RequiresWatch = 0;

		private static uint __IsWildCard = 0;

		private static uint __IsUObject = 0;

		private static uint __IsStructMember = 0;

		private static uint __IsStruct = 0;

		private static uint __IsStringType = 0;

		private static uint __IsRootPin = 0;

		private static uint __IsReferenceCountedContainer = 0;

		private static uint __IsLinkedTo = 0;

		private static uint __IsLazy = 0;

		private static uint __IsInterface = 0;

		private static uint __IsFixedSizeArray = 0;

		private static uint __IsExpanded = 0;

		private static uint __IsExecuteContext = 0;

		private static uint __IsEnum = 0;

		private static uint __IsDynamicArray = 0;

		private static uint __IsDefinedAsConstant = 0;

		private static uint __IsDecoratorPin = 0;

		private static uint __IsArrayElement = 0;

		private static uint __IsArray = 0;

		private static uint __GetToolTipText = 0;

		private static uint __GetTargetLinks = 0;

		private static uint __GetSubPins = 0;

		private static uint __GetSubPinPath = 0;

		private static uint __GetSourceLinks = 0;

		private static uint __GetSegmentPath = 0;

		private static uint __GetScriptStruct = 0;

		private static uint __GetRootPin = 0;

		private static uint __GetPinPath = 0;

		private static uint __GetPinIndex = 0;

		private static uint __GetPinForLink = 0;

		private static uint __GetParentPin = 0;

		private static uint __GetOriginalPinFromInjectedNode = 0;

		private static uint __GetNode = 0;

		private static uint __GetLinks = 0;

		private static uint __GetLinkedTargetPins = 0;

		private static uint __GetLinkedSourcePins = 0;

		private static uint __GetGraph = 0;

		private static uint __GetEnum = 0;

		private static uint __GetDisplayName = 0;

		private static uint __GetDirection = 0;

		private static uint __GetDefaultValue = 0;

		private static uint __GetCustomWidgetName = 0;

		private static uint __GetCPPTypeObject = 0;

		private static uint __GetCPPType = 0;

		private static uint __GetArraySize = 0;

		private static uint __GetArrayElementCppType = 0;

		private static uint __GetAbsolutePinIndex = 0;

		private static uint __FindSubPin = 0;

		private static uint __FindLinkForPin = 0;

		private static uint __ContainsWildCardSubPin = 0;
	}
}