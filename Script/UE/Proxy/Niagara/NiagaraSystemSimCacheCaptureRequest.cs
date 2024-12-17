using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraSystemSimCacheCaptureRequest")]
	public partial class FNiagaraSystemSimCacheCaptureRequest : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraSystemSimCacheCaptureRequest");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraSystemSimCacheCaptureRequest() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraSystemSimCacheCaptureRequest() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraSystemSimCacheCaptureRequest A, FNiagaraSystemSimCacheCaptureRequest B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraSystemSimCacheCaptureRequest A, FNiagaraSystemSimCacheCaptureRequest B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraSystemSimCacheCaptureRequest;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName ComponentName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ComponentName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ComponentName, __InBuffer);
				}
			}
		}

		public uint CaptureDelayFrames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CaptureDelayFrames, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CaptureDelayFrames, __InBuffer);
				}
			}
		}

		public uint CaptureFrames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CaptureFrames, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CaptureFrames, __InBuffer);
				}
			}
		}

		private static uint __ComponentName = 0;

		private static uint __CaptureDelayFrames = 0;

		private static uint __CaptureFrames = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}