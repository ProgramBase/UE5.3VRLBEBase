using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TranslationTrack")]
	public partial class FTranslationTrack : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.TranslationTrack");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTranslationTrack() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTranslationTrack() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTranslationTrack A, FTranslationTrack B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTranslationTrack A, FTranslationTrack B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTranslationTrack;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FVector3f> PosKeys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PosKeys, __ReturnBuffer);

					return *(TArray<FVector3f>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PosKeys, __InBuffer);
				}
			}
		}

		public TArray<float> Times
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Times, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Times, __InBuffer);
				}
			}
		}

		private static uint __PosKeys = 0;

		private static uint __Times = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}