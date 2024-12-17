using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraOutlinerSystemData")]
	public partial class FNiagaraOutlinerSystemData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraOutlinerSystemData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraOutlinerSystemData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraOutlinerSystemData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraOutlinerSystemData A, FNiagaraOutlinerSystemData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraOutlinerSystemData A, FNiagaraOutlinerSystemData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraOutlinerSystemData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FNiagaraOutlinerSystemInstanceData> SystemInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SystemInstances, __ReturnBuffer);

					return *(TArray<FNiagaraOutlinerSystemInstanceData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SystemInstances, __InBuffer);
				}
			}
		}

		public FNiagaraOutlinerTimingData AveragePerFrameTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AveragePerFrameTime, __ReturnBuffer);

					return *(FNiagaraOutlinerTimingData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AveragePerFrameTime, __InBuffer);
				}
			}
		}

		public FNiagaraOutlinerTimingData MaxPerFrameTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxPerFrameTime, __ReturnBuffer);

					return *(FNiagaraOutlinerTimingData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxPerFrameTime, __InBuffer);
				}
			}
		}

		public FNiagaraOutlinerTimingData AveragePerInstanceTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AveragePerInstanceTime, __ReturnBuffer);

					return *(FNiagaraOutlinerTimingData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AveragePerInstanceTime, __InBuffer);
				}
			}
		}

		public FNiagaraOutlinerTimingData MaxPerInstanceTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxPerInstanceTime, __ReturnBuffer);

					return *(FNiagaraOutlinerTimingData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxPerInstanceTime, __InBuffer);
				}
			}
		}

		private static uint __SystemInstances = 0;

		private static uint __AveragePerFrameTime = 0;

		private static uint __MaxPerFrameTime = 0;

		private static uint __AveragePerInstanceTime = 0;

		private static uint __MaxPerInstanceTime = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}