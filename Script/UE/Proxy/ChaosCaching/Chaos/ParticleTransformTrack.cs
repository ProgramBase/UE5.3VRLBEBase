using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.ChaosCaching
{
	[PathName("/Script/ChaosCaching.ParticleTransformTrack")]
	public partial class FParticleTransformTrack : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ChaosCaching.ParticleTransformTrack");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FParticleTransformTrack() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FParticleTransformTrack() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FParticleTransformTrack A, FParticleTransformTrack B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FParticleTransformTrack A, FParticleTransformTrack B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FParticleTransformTrack;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRawAnimSequenceTrack RawTransformTrack
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RawTransformTrack, __ReturnBuffer);

					return *(FRawAnimSequenceTrack*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RawTransformTrack, __InBuffer);
				}
			}
		}

		public float BeginOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BeginOffset, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BeginOffset, __InBuffer);
				}
			}
		}

		public bool bDeactivateOnEnd
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bDeactivateOnEnd, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bDeactivateOnEnd, __InBuffer);
				}
			}
		}

		public TArray<float> KeyTimestamps
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __KeyTimestamps, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __KeyTimestamps, __InBuffer);
				}
			}
		}

		private static uint __RawTransformTrack = 0;

		private static uint __BeginOffset = 0;

		private static uint __bDeactivateOnEnd = 0;

		private static uint __KeyTimestamps = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}