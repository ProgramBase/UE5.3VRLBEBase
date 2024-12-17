using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleEditorPromotionSettings")]
	public partial class FParticleEditorPromotionSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ParticleEditorPromotionSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FParticleEditorPromotionSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FParticleEditorPromotionSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FParticleEditorPromotionSettings A, FParticleEditorPromotionSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FParticleEditorPromotionSettings A, FParticleEditorPromotionSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FParticleEditorPromotionSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FFilePath DefaultParticleAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultParticleAsset, __ReturnBuffer);

					return *(FFilePath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultParticleAsset, __InBuffer);
				}
			}
		}

		private static uint __DefaultParticleAsset = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}