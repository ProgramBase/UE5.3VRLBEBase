using Script.CoreUObject;
using Script.Niagara;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraParameterDefinitions")]
	public partial class UNiagaraParameterDefinitions : UNiagaraParameterDefinitionsBase, IStaticClass
	{
		public bool bPromoteToTopInAddMenus
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPromoteToTopInAddMenus, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPromoteToTopInAddMenus, __InBuffer);
				}
			}
		}

		public int MenuSortOrder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MenuSortOrder, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MenuSortOrder, __InBuffer);
				}
			}
		}

		public TArray<UNiagaraScriptVariable> ScriptVariables
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScriptVariables, __ReturnBuffer);

					return *(TArray<UNiagaraScriptVariable>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScriptVariables, __InBuffer);
				}
			}
		}

		public TArray<FParameterDefinitionsBindingNameSubscription> ExternalParameterDefinitionsSubscriptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExternalParameterDefinitionsSubscriptions, __ReturnBuffer);

					return *(TArray<FParameterDefinitionsBindingNameSubscription>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExternalParameterDefinitionsSubscriptions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraParameterDefinitions");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bPromoteToTopInAddMenus = 0;

		private static uint __MenuSortOrder = 0;

		private static uint __ScriptVariables = 0;

		private static uint __ExternalParameterDefinitionsSubscriptions = 0;
	}
}