using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.FractureEffect")]
	public partial class FFractureEffect : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.FractureEffect");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFractureEffect() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFractureEffect() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFractureEffect A, FFractureEffect B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFractureEffect A, FFractureEffect B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFractureEffect;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UParticleSystem ParticleSystem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParticleSystem, __ReturnBuffer);

					return *(UParticleSystem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParticleSystem, __InBuffer);
				}
			}
		}

		public USoundBase Sound
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Sound, __ReturnBuffer);

					return *(USoundBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Sound, __InBuffer);
				}
			}
		}

		private static uint __ParticleSystem = 0;

		private static uint __Sound = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}