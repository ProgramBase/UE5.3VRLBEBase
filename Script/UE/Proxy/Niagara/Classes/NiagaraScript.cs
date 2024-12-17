using Script.CoreUObject;
using Script.NiagaraShader;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraScript")]
	public partial class UNiagaraScript : UNiagaraScriptBase, IStaticClass
	{
		public TArray<UNiagaraValidationRule> ValidationRules
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ValidationRules, __ReturnBuffer);

					return *(TArray<UNiagaraValidationRule>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ValidationRules, __InBuffer);
				}
			}
		}

		public ENiagaraScriptUsage Usage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Usage, __ReturnBuffer);

					return *(ENiagaraScriptUsage*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Usage, __InBuffer);
				}
			}
		}

		public FGuid UsageId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UsageId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UsageId, __InBuffer);
				}
			}
		}

		public FGuid ExposedVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExposedVersion, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExposedVersion, __InBuffer);
				}
			}
		}

		public bool bVersioningEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bVersioningEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bVersioningEnabled, __InBuffer);
				}
			}
		}

		public TArray<FVersionedNiagaraScriptData> VersionData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VersionData, __ReturnBuffer);

					return *(TArray<FVersionedNiagaraScriptData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VersionData, __InBuffer);
				}
			}
		}

		public FNiagaraParameterStore RapidIterationParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RapidIterationParameters, __ReturnBuffer);

					return *(FNiagaraParameterStore*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RapidIterationParameters, __InBuffer);
				}
			}
		}

		public FNiagaraParameterStore RapidIterationParametersCookedEditorCache
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RapidIterationParametersCookedEditorCache, __ReturnBuffer);

					return *(FNiagaraParameterStore*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RapidIterationParametersCookedEditorCache, __InBuffer);
				}
			}
		}

		public FGuid VersionToOpenInEditor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VersionToOpenInEditor, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VersionToOpenInEditor, __InBuffer);
				}
			}
		}

		public FNiagaraScriptExecutionParameterStore ScriptExecutionParamStoreCPU
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScriptExecutionParamStoreCPU, __ReturnBuffer);

					return *(FNiagaraScriptExecutionParameterStore*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScriptExecutionParamStoreCPU, __InBuffer);
				}
			}
		}

		public FNiagaraScriptExecutionParameterStore ScriptExecutionParamStoreGPU
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScriptExecutionParamStoreGPU, __ReturnBuffer);

					return *(FNiagaraScriptExecutionParameterStore*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScriptExecutionParamStoreGPU, __InBuffer);
				}
			}
		}

		public FNiagaraScriptExecutionParameterStore ScriptExecutionParamStore
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScriptExecutionParamStore, __ReturnBuffer);

					return *(FNiagaraScriptExecutionParameterStore*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScriptExecutionParamStore, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraBoundParameter> ScriptExecutionBoundParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScriptExecutionBoundParameters, __ReturnBuffer);

					return *(TArray<FNiagaraBoundParameter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScriptExecutionBoundParameters, __InBuffer);
				}
			}
		}

		public FNiagaraVMExecutableDataId CachedScriptVMId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedScriptVMId, __ReturnBuffer);

					return *(FNiagaraVMExecutableDataId*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedScriptVMId, __InBuffer);
				}
			}
		}

		public TArray<UObject> ActiveCompileRoots
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveCompileRoots, __ReturnBuffer);

					return *(TArray<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveCompileRoots, __InBuffer);
				}
			}
		}

		public FNiagaraVMExecutableData CachedScriptVM
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedScriptVM, __ReturnBuffer);

					return *(FNiagaraVMExecutableData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedScriptVM, __InBuffer);
				}
			}
		}

		public TArray<UNiagaraParameterCollection> CachedParameterCollectionReferences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedParameterCollectionReferences, __ReturnBuffer);

					return *(TArray<UNiagaraParameterCollection>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedParameterCollectionReferences, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraScriptDataInterfaceInfo> CachedDefaultDataInterfaces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedDefaultDataInterfaces, __ReturnBuffer);

					return *(TArray<FNiagaraScriptDataInterfaceInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedDefaultDataInterfaces, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraScriptResolvedDataInterfaceInfo> ResolvedDataInterfaces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ResolvedDataInterfaces, __ReturnBuffer);

					return *(TArray<FNiagaraScriptResolvedDataInterfaceInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ResolvedDataInterfaces, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraResolvedUserDataInterfaceBinding> ResolvedUserDataInterfaceBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ResolvedUserDataInterfaceBindings, __ReturnBuffer);

					return *(TArray<FNiagaraResolvedUserDataInterfaceBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ResolvedUserDataInterfaceBindings, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraScriptUObjectCompileInfo> CachedDefaultUObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedDefaultUObjects, __ReturnBuffer);

					return *(TArray<FNiagaraScriptUObjectCompileInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedDefaultUObjects, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraResolvedUObjectInfo> ResolvedUObjectInfos
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ResolvedUObjectInfos, __ReturnBuffer);

					return *(TArray<FNiagaraResolvedUObjectInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ResolvedUObjectInfos, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraScript");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void RaiseOnGPUCompilationComplete()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RaiseOnGPUCompilationComplete);
			}
		}

		private static uint __ValidationRules = 0;

		private static uint __Usage = 0;

		private static uint __UsageId = 0;

		private static uint __ExposedVersion = 0;

		private static uint __bVersioningEnabled = 0;

		private static uint __VersionData = 0;

		private static uint __RapidIterationParameters = 0;

		private static uint __RapidIterationParametersCookedEditorCache = 0;

		private static uint __VersionToOpenInEditor = 0;

		private static uint __ScriptExecutionParamStoreCPU = 0;

		private static uint __ScriptExecutionParamStoreGPU = 0;

		private static uint __ScriptExecutionParamStore = 0;

		private static uint __ScriptExecutionBoundParameters = 0;

		private static uint __CachedScriptVMId = 0;

		private static uint __ActiveCompileRoots = 0;

		private static uint __CachedScriptVM = 0;

		private static uint __CachedParameterCollectionReferences = 0;

		private static uint __CachedDefaultDataInterfaces = 0;

		private static uint __ResolvedDataInterfaces = 0;

		private static uint __ResolvedUserDataInterfaceBindings = 0;

		private static uint __CachedDefaultUObjects = 0;

		private static uint __ResolvedUObjectInfos = 0;

		private static uint __RaiseOnGPUCompilationComplete = 0;
	}
}