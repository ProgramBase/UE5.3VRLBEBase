using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMHost")]
	public partial class URigVMHost : UObject, IStaticClass, IInterface_AssetUserData
	{
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

		public URigVM VM
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VM, __ReturnBuffer);

					return *(URigVM*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VM, __InBuffer);
				}
			}
		}

		public FRigVMExtendedExecuteContext ExtendedExecuteContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExtendedExecuteContext, __ReturnBuffer);

					return *(FRigVMExtendedExecuteContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExtendedExecuteContext, __InBuffer);
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

		public TArray<FName> EventQueue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EventQueue, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EventQueue, __InBuffer);
				}
			}
		}

		public TArray<UAssetUserData> AssetUserData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetUserData, __ReturnBuffer);

					return *(TArray<UAssetUserData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetUserData, __InBuffer);
				}
			}
		}

		public URigVM VMSnapshotBeforeExecution
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VMSnapshotBeforeExecution, __ReturnBuffer);

					return *(URigVM*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VMSnapshotBeforeExecution, __InBuffer);
				}
			}
		}

		public FRigVMExtendedExecuteContext SnapshotContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SnapshotContext, __ReturnBuffer);

					return *(FRigVMExtendedExecuteContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SnapshotContext, __InBuffer);
				}
			}
		}

		public bool bIsInDebugMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsInDebugMode, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsInDebugMode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVM.RigVMHost");
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

		public virtual bool SupportsEvent(FName InEventName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InEventName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SupportsEvent, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetVariableFromString(FName InVariableName, FString InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetVariableFromString, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetFramesPerSecond(float InFramesPerSecond)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InFramesPerSecond;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFramesPerSecond, __InBuffer);
			}
		}

		public virtual void SetDeltaTime(float InDeltaTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InDeltaTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDeltaTime, __InBuffer);
			}
		}

		public virtual void SetAbsoluteTime(float InAbsoluteTime, bool InSetDeltaTimeZero = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = InAbsoluteTime;

				*(bool*)(__InBuffer + 4) = InSetDeltaTimeZero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAbsoluteTime, __InBuffer);
			}
		}

		public virtual void SetAbsoluteAndDeltaTime(float InAbsoluteTime, float InDeltaTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = InAbsoluteTime;

				*(float*)(__InBuffer + 4) = InDeltaTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAbsoluteAndDeltaTime, __InBuffer);
			}
		}

		public virtual void RequestRunOnceEvent(FName InEventName, int InEventIndex = -1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InEventName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InEventIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RequestRunOnceEvent, __InBuffer);
			}
		}

		public virtual void RequestInit()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RequestInit);
			}
		}

		public virtual bool RemoveRunOnceEvent(FName InEventName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InEventName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveRunOnceEvent, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual URigVM GetVM()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetVM, __ReturnBuffer);

				return *(URigVM*)__ReturnBuffer;
			}
		}

		public virtual FName GetVariableType(FName InVariableName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVariableType, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual FString GetVariableAsString(FName InVariableName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVariableName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVariableAsString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual TArray<FName> GetSupportedEvents()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSupportedEvents, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		public virtual TArray<FName> GetScriptAccessibleVariables()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetScriptAccessibleVariables, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		public virtual FRigVMExtendedExecuteContext GetExtendedExecuteContext()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetExtendedExecuteContext, __ReturnBuffer);

				return *(FRigVMExtendedExecuteContext*)__ReturnBuffer;
			}
		}

		public virtual float GetDeltaTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDeltaTime, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetCurrentFramesPerSecond()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCurrentFramesPerSecond, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetAbsoluteTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAbsoluteTime, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static TArray<URigVMHost> FindRigVMHosts(UObject Outer, TSubclassOf<URigVMHost> OptionalClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Outer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OptionalClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindRigVMHosts, __InBuffer, __ReturnBuffer);

				return *(TArray<URigVMHost>*)__ReturnBuffer;
			}
		}

		public virtual bool ExecuteEvent(FName InEventName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InEventName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ExecuteEvent, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool Execute(FName InEventName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InEventName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Execute, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool CanExecute()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __CanExecute, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __VMRuntimeSettings = 0;

		private static uint __VM = 0;

		private static uint __ExtendedExecuteContext = 0;

		private static uint __DrawContainer = 0;

		private static uint __EventQueue = 0;

		private static uint __AssetUserData = 0;

		private static uint __VMSnapshotBeforeExecution = 0;

		private static uint __SnapshotContext = 0;

		private static uint __bIsInDebugMode = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SupportsEvent = 0;

		private static uint __SetVariableFromString = 0;

		private static uint __SetFramesPerSecond = 0;

		private static uint __SetDeltaTime = 0;

		private static uint __SetAbsoluteTime = 0;

		private static uint __SetAbsoluteAndDeltaTime = 0;

		private static uint __RequestRunOnceEvent = 0;

		private static uint __RequestInit = 0;

		private static uint __RemoveRunOnceEvent = 0;

		private static uint __GetVM = 0;

		private static uint __GetVariableType = 0;

		private static uint __GetVariableAsString = 0;

		private static uint __GetSupportedEvents = 0;

		private static uint __GetScriptAccessibleVariables = 0;

		private static uint __GetExtendedExecuteContext = 0;

		private static uint __GetDeltaTime = 0;

		private static uint __GetCurrentFramesPerSecond = 0;

		private static uint __GetAbsoluteTime = 0;

		private static uint __FindRigVMHosts = 0;

		private static uint __ExecuteEvent = 0;

		private static uint __Execute = 0;

		private static uint __CanExecute = 0;
	}
}