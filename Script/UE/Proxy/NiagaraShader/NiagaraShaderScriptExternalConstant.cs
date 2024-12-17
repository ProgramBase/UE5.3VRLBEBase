using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraShader
{
	[PathName("/Script/NiagaraShader.NiagaraShaderScriptExternalConstant")]
	public partial class FNiagaraShaderScriptExternalConstant : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraShader.NiagaraShaderScriptExternalConstant");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraShaderScriptExternalConstant() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraShaderScriptExternalConstant() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraShaderScriptExternalConstant A, FNiagaraShaderScriptExternalConstant B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraShaderScriptExternalConstant A, FNiagaraShaderScriptExternalConstant B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraShaderScriptExternalConstant;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName Type
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Type, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Type, __InBuffer);
				}
			}
		}

		public FString Name
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Name, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Name, __InBuffer);
				}
			}
		}

		private static uint __Type = 0;

		private static uint __Name = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}