using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraSimCacheCaptureParameters")]
	public partial class FNiagaraSimCacheCaptureParameters : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraSimCacheCaptureParameters");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraSimCacheCaptureParameters() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraSimCacheCaptureParameters() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraSimCacheCaptureParameters A, FNiagaraSimCacheCaptureParameters B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraSimCacheCaptureParameters A, FNiagaraSimCacheCaptureParameters B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraSimCacheCaptureParameters;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bAppendToSimCache
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAppendToSimCache, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAppendToSimCache, __InBuffer);
				}
			}
		}

		public bool bCaptureFixedNumberOfFrames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCaptureFixedNumberOfFrames, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCaptureFixedNumberOfFrames, __InBuffer);
				}
			}
		}

		public int NumFrames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumFrames, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumFrames, __InBuffer);
				}
			}
		}

		public int CaptureRate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CaptureRate, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CaptureRate, __InBuffer);
				}
			}
		}

		public bool bUseTimeout
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bUseTimeout, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bUseTimeout, __InBuffer);
				}
			}
		}

		public int TimeoutFrameCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TimeoutFrameCount, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TimeoutFrameCount, __InBuffer);
				}
			}
		}

		public bool bCaptureAllFramesImmediatly
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCaptureAllFramesImmediatly, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCaptureAllFramesImmediatly, __InBuffer);
				}
			}
		}

		public float ImmediateCaptureDeltaTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ImmediateCaptureDeltaTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ImmediateCaptureDeltaTime, __InBuffer);
				}
			}
		}

		private static uint __bAppendToSimCache = 0;

		private static uint __bCaptureFixedNumberOfFrames = 0;

		private static uint __NumFrames = 0;

		private static uint __CaptureRate = 0;

		private static uint __bUseTimeout = 0;

		private static uint __TimeoutFrameCount = 0;

		private static uint __bCaptureAllFramesImmediatly = 0;

		private static uint __ImmediateCaptureDeltaTime = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}