using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraOutlinerTimingData")]
	public partial class FNiagaraOutlinerTimingData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraOutlinerTimingData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraOutlinerTimingData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraOutlinerTimingData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraOutlinerTimingData A, FNiagaraOutlinerTimingData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraOutlinerTimingData A, FNiagaraOutlinerTimingData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraOutlinerTimingData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float GameThread
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameThread, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameThread, __InBuffer);
				}
			}
		}

		public float RenderThread
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RenderThread, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RenderThread, __InBuffer);
				}
			}
		}

		private static uint __GameThread = 0;

		private static uint __RenderThread = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}