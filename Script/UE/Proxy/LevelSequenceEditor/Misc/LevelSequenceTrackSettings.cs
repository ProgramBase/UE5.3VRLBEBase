using Script.CoreUObject;
using Script.Library;

namespace Script.LevelSequenceEditor
{
	[PathName("/Script/LevelSequenceEditor.LevelSequenceTrackSettings")]
	public partial class FLevelSequenceTrackSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LevelSequenceEditor.LevelSequenceTrackSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLevelSequenceTrackSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLevelSequenceTrackSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLevelSequenceTrackSettings A, FLevelSequenceTrackSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLevelSequenceTrackSettings A, FLevelSequenceTrackSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLevelSequenceTrackSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSoftClassPath MatchingActorClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MatchingActorClass, __ReturnBuffer);

					return *(FSoftClassPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MatchingActorClass, __InBuffer);
				}
			}
		}

		public TArray<FSoftClassPath> DefaultTracks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultTracks, __ReturnBuffer);

					return *(TArray<FSoftClassPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultTracks, __InBuffer);
				}
			}
		}

		public TArray<FSoftClassPath> ExcludeDefaultTracks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExcludeDefaultTracks, __ReturnBuffer);

					return *(TArray<FSoftClassPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExcludeDefaultTracks, __InBuffer);
				}
			}
		}

		public TArray<FLevelSequencePropertyTrackSettings> DefaultPropertyTracks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultPropertyTracks, __ReturnBuffer);

					return *(TArray<FLevelSequencePropertyTrackSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultPropertyTracks, __InBuffer);
				}
			}
		}

		public TArray<FLevelSequencePropertyTrackSettings> ExcludeDefaultPropertyTracks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExcludeDefaultPropertyTracks, __ReturnBuffer);

					return *(TArray<FLevelSequencePropertyTrackSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExcludeDefaultPropertyTracks, __InBuffer);
				}
			}
		}

		private static uint __MatchingActorClass = 0;

		private static uint __DefaultTracks = 0;

		private static uint __ExcludeDefaultTracks = 0;

		private static uint __DefaultPropertyTracks = 0;

		private static uint __ExcludeDefaultPropertyTracks = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}