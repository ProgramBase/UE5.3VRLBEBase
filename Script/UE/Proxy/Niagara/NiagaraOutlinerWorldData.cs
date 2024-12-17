using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraOutlinerWorldData")]
	public partial class FNiagaraOutlinerWorldData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraOutlinerWorldData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraOutlinerWorldData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraOutlinerWorldData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraOutlinerWorldData A, FNiagaraOutlinerWorldData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraOutlinerWorldData A, FNiagaraOutlinerWorldData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraOutlinerWorldData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FString, FNiagaraOutlinerSystemData> Systems
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Systems, __ReturnBuffer);

					return *(TMap<FString, FNiagaraOutlinerSystemData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Systems, __InBuffer);
				}
			}
		}

		public bool bHasBegunPlay
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHasBegunPlay, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHasBegunPlay, __InBuffer);
				}
			}
		}

		public byte WorldType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WorldType, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WorldType, __InBuffer);
				}
			}
		}

		public byte NetMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NetMode, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NetMode, __InBuffer);
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

		private static uint __Systems = 0;

		private static uint __bHasBegunPlay = 0;

		private static uint __WorldType = 0;

		private static uint __NetMode = 0;

		private static uint __AveragePerFrameTime = 0;

		private static uint __MaxPerFrameTime = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}