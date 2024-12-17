using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraRendererMaterialScalarParameter")]
	public partial class FNiagaraRendererMaterialScalarParameter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraRendererMaterialScalarParameter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraRendererMaterialScalarParameter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraRendererMaterialScalarParameter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraRendererMaterialScalarParameter A, FNiagaraRendererMaterialScalarParameter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraRendererMaterialScalarParameter A, FNiagaraRendererMaterialScalarParameter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraRendererMaterialScalarParameter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName MaterialParameterName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaterialParameterName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaterialParameterName, __InBuffer);
				}
			}
		}

		public float Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __MaterialParameterName = 0;

		private static uint __Value = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}