using Script.CoreUObject;
using Script.Library;
using Script.Engine;
using Script.MovieScene;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.LevelSequencePlayerSnapshot")]
	public partial class FLevelSequencePlayerSnapshot : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LevelSequence.LevelSequencePlayerSnapshot");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLevelSequencePlayerSnapshot() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLevelSequencePlayerSnapshot() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLevelSequencePlayerSnapshot A, FLevelSequencePlayerSnapshot B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLevelSequencePlayerSnapshot A, FLevelSequencePlayerSnapshot B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLevelSequencePlayerSnapshot;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString RootName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RootName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RootName, __InBuffer);
				}
			}
		}

		public FQualifiedFrameTime RootTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RootTime, __ReturnBuffer);

					return *(FQualifiedFrameTime*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RootTime, __InBuffer);
				}
			}
		}

		public FQualifiedFrameTime SourceTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceTime, __ReturnBuffer);

					return *(FQualifiedFrameTime*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceTime, __InBuffer);
				}
			}
		}

		public FString CurrentShotName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CurrentShotName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CurrentShotName, __InBuffer);
				}
			}
		}

		public FQualifiedFrameTime CurrentShotLocalTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CurrentShotLocalTime, __ReturnBuffer);

					return *(FQualifiedFrameTime*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CurrentShotLocalTime, __InBuffer);
				}
			}
		}

		public FQualifiedFrameTime CurrentShotSourceTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CurrentShotSourceTime, __ReturnBuffer);

					return *(FQualifiedFrameTime*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CurrentShotSourceTime, __InBuffer);
				}
			}
		}

		public FString SourceTimecode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceTimecode, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceTimecode, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UCameraComponent> CameraComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CameraComponent, __ReturnBuffer);

					return *(TSoftObjectPtr<UCameraComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CameraComponent, __InBuffer);
				}
			}
		}

		public ULevelSequence ActiveShot
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActiveShot, __ReturnBuffer);

					return *(ULevelSequence*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActiveShot, __InBuffer);
				}
			}
		}

		public FMovieSceneSequenceID ShotID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ShotID, __ReturnBuffer);

					return *(FMovieSceneSequenceID*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ShotID, __InBuffer);
				}
			}
		}

		private static uint __RootName = 0;

		private static uint __RootTime = 0;

		private static uint __SourceTime = 0;

		private static uint __CurrentShotName = 0;

		private static uint __CurrentShotLocalTime = 0;

		private static uint __CurrentShotSourceTime = 0;

		private static uint __SourceTimecode = 0;

		private static uint __CameraComponent = 0;

		private static uint __ActiveShot = 0;

		private static uint __ShotID = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}