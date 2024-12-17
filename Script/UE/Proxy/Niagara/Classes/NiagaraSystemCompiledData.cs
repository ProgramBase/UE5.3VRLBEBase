using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraSystemCompiledData")]
	public partial class FNiagaraSystemCompiledData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraSystemCompiledData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraSystemCompiledData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraSystemCompiledData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraSystemCompiledData A, FNiagaraSystemCompiledData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraSystemCompiledData A, FNiagaraSystemCompiledData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraSystemCompiledData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FNiagaraParameterStore InstanceParamStore
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InstanceParamStore, __ReturnBuffer);

					return *(FNiagaraParameterStore*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InstanceParamStore, __InBuffer);
				}
			}
		}

		public FNiagaraDataSetCompiledData DataSetCompiledData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DataSetCompiledData, __ReturnBuffer);

					return *(FNiagaraDataSetCompiledData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DataSetCompiledData, __InBuffer);
				}
			}
		}

		public FNiagaraDataSetCompiledData SpawnInstanceParamsDataSetCompiledData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpawnInstanceParamsDataSetCompiledData, __ReturnBuffer);

					return *(FNiagaraDataSetCompiledData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpawnInstanceParamsDataSetCompiledData, __InBuffer);
				}
			}
		}

		public FNiagaraDataSetCompiledData UpdateInstanceParamsDataSetCompiledData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UpdateInstanceParamsDataSetCompiledData, __ReturnBuffer);

					return *(FNiagaraDataSetCompiledData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UpdateInstanceParamsDataSetCompiledData, __InBuffer);
				}
			}
		}

		public FNiagaraParameterDataSetBindingCollection SpawnInstanceGlobalBinding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpawnInstanceGlobalBinding, __ReturnBuffer);

					return *(FNiagaraParameterDataSetBindingCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpawnInstanceGlobalBinding, __InBuffer);
				}
			}
		}

		public FNiagaraParameterDataSetBindingCollection SpawnInstanceSystemBinding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpawnInstanceSystemBinding, __ReturnBuffer);

					return *(FNiagaraParameterDataSetBindingCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpawnInstanceSystemBinding, __InBuffer);
				}
			}
		}

		public FNiagaraParameterDataSetBindingCollection SpawnInstanceOwnerBinding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpawnInstanceOwnerBinding, __ReturnBuffer);

					return *(FNiagaraParameterDataSetBindingCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpawnInstanceOwnerBinding, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraParameterDataSetBindingCollection> SpawnInstanceEmitterBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpawnInstanceEmitterBindings, __ReturnBuffer);

					return *(TArray<FNiagaraParameterDataSetBindingCollection>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpawnInstanceEmitterBindings, __InBuffer);
				}
			}
		}

		public FNiagaraParameterDataSetBindingCollection UpdateInstanceGlobalBinding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UpdateInstanceGlobalBinding, __ReturnBuffer);

					return *(FNiagaraParameterDataSetBindingCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UpdateInstanceGlobalBinding, __InBuffer);
				}
			}
		}

		public FNiagaraParameterDataSetBindingCollection UpdateInstanceSystemBinding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UpdateInstanceSystemBinding, __ReturnBuffer);

					return *(FNiagaraParameterDataSetBindingCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UpdateInstanceSystemBinding, __InBuffer);
				}
			}
		}

		public FNiagaraParameterDataSetBindingCollection UpdateInstanceOwnerBinding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UpdateInstanceOwnerBinding, __ReturnBuffer);

					return *(FNiagaraParameterDataSetBindingCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UpdateInstanceOwnerBinding, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraParameterDataSetBindingCollection> UpdateInstanceEmitterBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UpdateInstanceEmitterBindings, __ReturnBuffer);

					return *(TArray<FNiagaraParameterDataSetBindingCollection>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UpdateInstanceEmitterBindings, __InBuffer);
				}
			}
		}

		private static uint __InstanceParamStore = 0;

		private static uint __DataSetCompiledData = 0;

		private static uint __SpawnInstanceParamsDataSetCompiledData = 0;

		private static uint __UpdateInstanceParamsDataSetCompiledData = 0;

		private static uint __SpawnInstanceGlobalBinding = 0;

		private static uint __SpawnInstanceSystemBinding = 0;

		private static uint __SpawnInstanceOwnerBinding = 0;

		private static uint __SpawnInstanceEmitterBindings = 0;

		private static uint __UpdateInstanceGlobalBinding = 0;

		private static uint __UpdateInstanceSystemBinding = 0;

		private static uint __UpdateInstanceOwnerBinding = 0;

		private static uint __UpdateInstanceEmitterBindings = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}