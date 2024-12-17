using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraRendererMaterialStaticBoolParameter")]
	public partial class FNiagaraRendererMaterialStaticBoolParameter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraRendererMaterialStaticBoolParameter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraRendererMaterialStaticBoolParameter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraRendererMaterialStaticBoolParameter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraRendererMaterialStaticBoolParameter A, FNiagaraRendererMaterialStaticBoolParameter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraRendererMaterialStaticBoolParameter A, FNiagaraRendererMaterialStaticBoolParameter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraRendererMaterialStaticBoolParameter;

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

		public FName StaticVariableName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StaticVariableName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StaticVariableName, __InBuffer);
				}
			}
		}

		private static uint __MaterialParameterName = 0;

		private static uint __StaticVariableName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}