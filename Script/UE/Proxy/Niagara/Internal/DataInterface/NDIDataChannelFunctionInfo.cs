using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NDIDataChannelFunctionInfo")]
	public partial class FNDIDataChannelFunctionInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NDIDataChannelFunctionInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNDIDataChannelFunctionInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNDIDataChannelFunctionInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNDIDataChannelFunctionInfo A, FNDIDataChannelFunctionInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNDIDataChannelFunctionInfo A, FNDIDataChannelFunctionInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNDIDataChannelFunctionInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName FunctionName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FunctionName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FunctionName, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraVariableBase> Inputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Inputs, __ReturnBuffer);

					return *(TArray<FNiagaraVariableBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Inputs, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraVariableBase> Outputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Outputs, __ReturnBuffer);

					return *(TArray<FNiagaraVariableBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Outputs, __InBuffer);
				}
			}
		}

		private static uint __FunctionName = 0;

		private static uint __Inputs = 0;

		private static uint __Outputs = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}