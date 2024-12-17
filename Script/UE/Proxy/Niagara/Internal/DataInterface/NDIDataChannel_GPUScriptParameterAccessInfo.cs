using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NDIDataChannel_GPUScriptParameterAccessInfo")]
	public partial class FNDIDataChannel_GPUScriptParameterAccessInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NDIDataChannel_GPUScriptParameterAccessInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNDIDataChannel_GPUScriptParameterAccessInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNDIDataChannel_GPUScriptParameterAccessInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNDIDataChannel_GPUScriptParameterAccessInfo A, FNDIDataChannel_GPUScriptParameterAccessInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNDIDataChannel_GPUScriptParameterAccessInfo A, FNDIDataChannel_GPUScriptParameterAccessInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNDIDataChannel_GPUScriptParameterAccessInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FNiagaraVariableBase> SortedParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SortedParameters, __ReturnBuffer);

					return *(TArray<FNiagaraVariableBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SortedParameters, __InBuffer);
				}
			}
		}

		private static uint __SortedParameters = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}