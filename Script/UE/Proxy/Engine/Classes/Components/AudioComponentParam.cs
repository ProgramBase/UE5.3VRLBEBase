using Script.CoreUObject;
using Script.Library;
using Script.AudioExtensions;

namespace Script.Engine
{
	[PathName("/Script/Engine.AudioComponentParam")]
	public partial class FAudioComponentParam : FAudioParameter, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AudioComponentParam");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAudioComponentParam()
		{
		}

		public static bool operator ==(FAudioComponentParam A, FAudioComponentParam B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAudioComponentParam A, FAudioComponentParam B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAudioComponentParam;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public USoundWave SoundWaveParam
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SoundWaveParam, __ReturnBuffer);

					return *(USoundWave*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SoundWaveParam, __InBuffer);
				}
			}
		}

		private static uint __SoundWaveParam = 0;

	}
}