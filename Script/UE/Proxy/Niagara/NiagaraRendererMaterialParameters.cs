using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraRendererMaterialParameters")]
	public partial class FNiagaraRendererMaterialParameters : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraRendererMaterialParameters");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraRendererMaterialParameters() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraRendererMaterialParameters() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraRendererMaterialParameters A, FNiagaraRendererMaterialParameters B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraRendererMaterialParameters A, FNiagaraRendererMaterialParameters B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraRendererMaterialParameters;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FNiagaraMaterialAttributeBinding> AttributeBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AttributeBindings, __ReturnBuffer);

					return *(TArray<FNiagaraMaterialAttributeBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AttributeBindings, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraRendererMaterialScalarParameter> ScalarParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ScalarParameters, __ReturnBuffer);

					return *(TArray<FNiagaraRendererMaterialScalarParameter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ScalarParameters, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraRendererMaterialVectorParameter> VectorParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VectorParameters, __ReturnBuffer);

					return *(TArray<FNiagaraRendererMaterialVectorParameter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VectorParameters, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraRendererMaterialTextureParameter> TextureParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TextureParameters, __ReturnBuffer);

					return *(TArray<FNiagaraRendererMaterialTextureParameter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TextureParameters, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraRendererMaterialStaticBoolParameter> StaticBoolParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StaticBoolParameters, __ReturnBuffer);

					return *(TArray<FNiagaraRendererMaterialStaticBoolParameter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StaticBoolParameters, __InBuffer);
				}
			}
		}

		private static uint __AttributeBindings = 0;

		private static uint __ScalarParameters = 0;

		private static uint __VectorParameters = 0;

		private static uint __TextureParameters = 0;

		private static uint __StaticBoolParameters = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}