using Script.CoreUObject;
using Script.Library;
using Script.Niagara;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraOutlinerWorldDataCustomizationWrapper")]
	public partial class FNiagaraOutlinerWorldDataCustomizationWrapper : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraOutlinerWorldDataCustomizationWrapper");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraOutlinerWorldDataCustomizationWrapper() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraOutlinerWorldDataCustomizationWrapper() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraOutlinerWorldDataCustomizationWrapper A, FNiagaraOutlinerWorldDataCustomizationWrapper B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraOutlinerWorldDataCustomizationWrapper A, FNiagaraOutlinerWorldDataCustomizationWrapper B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraOutlinerWorldDataCustomizationWrapper;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FNiagaraOutlinerWorldData Data
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Data, __ReturnBuffer);

					return *(FNiagaraOutlinerWorldData*)__ReturnBuffer;
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