using Script.CoreUObject;
using Script.Library;
using Script.Niagara;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraOutlinerEmitterInstanceDataCustomizationWrapper")]
	public partial class FNiagaraOutlinerEmitterInstanceDataCustomizationWrapper : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraOutlinerEmitterInstanceDataCustomizationWrapper");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraOutlinerEmitterInstanceDataCustomizationWrapper() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraOutlinerEmitterInstanceDataCustomizationWrapper() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraOutlinerEmitterInstanceDataCustomizationWrapper A, FNiagaraOutlinerEmitterInstanceDataCustomizationWrapper B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraOutlinerEmitterInstanceDataCustomizationWrapper A, FNiagaraOutlinerEmitterInstanceDataCustomizationWrapper B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraOutlinerEmitterInstanceDataCustomizationWrapper;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FNiagaraOutlinerEmitterInstanceData Data
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Data, __ReturnBuffer);

					return *(FNiagaraOutlinerEmitterInstanceData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Data, __InBuffer);
				}
			}
		}

		private static uint __Data = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}