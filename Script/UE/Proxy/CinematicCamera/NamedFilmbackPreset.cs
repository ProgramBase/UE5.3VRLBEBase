using Script.CoreUObject;
using Script.Library;

namespace Script.CinematicCamera
{
	[PathName("/Script/CinematicCamera.NamedFilmbackPreset")]
	public partial class FNamedFilmbackPreset : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CinematicCamera.NamedFilmbackPreset");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNamedFilmbackPreset() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNamedFilmbackPreset() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNamedFilmbackPreset A, FNamedFilmbackPreset B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNamedFilmbackPreset A, FNamedFilmbackPreset B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNamedFilmbackPreset;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Name
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Name, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Name, __InBuffer);
				}
			}
		}

		public FCameraFilmbackSettings FilmbackSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilmbackSettings, __ReturnBuffer);

					return *(FCameraFilmbackSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilmbackSettings, __InBuffer);
				}
			}
		}

		private static uint __Name = 0;

		private static uint __FilmbackSettings = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}