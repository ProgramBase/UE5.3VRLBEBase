using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneLevelVisibilitySection")]
	public partial class UMovieSceneLevelVisibilitySection : UMovieSceneSection, IStaticClass, IMovieSceneEntityProvider
	{
		public ELevelVisibility Visibility
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Visibility, __ReturnBuffer);

					return *(ELevelVisibility*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Visibility, __InBuffer);
				}
			}
		}

		public TArray<FName> LevelNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LevelNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LevelNames, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneLevelVisibilitySection");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		public virtual void SetVisibility(ELevelVisibility InVisibility)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InVisibility;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVisibility, __InBuffer);
			}
		}

		public virtual void SetLevelNames(TArray<FName> InLevelNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InLevelNames?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLevelNames, __InBuffer);
			}
		}

		public virtual ELevelVisibility GetVisibility()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetVisibility, __ReturnBuffer);

				return *(ELevelVisibility*)__ReturnBuffer;
			}
		}

		public virtual TArray<FName> GetLevelNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLevelNames, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		private static uint __Visibility = 0;

		private static uint __LevelNames = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SetVisibility = 0;

		private static uint __SetLevelNames = 0;

		private static uint __GetVisibility = 0;

		private static uint __GetLevelNames = 0;
	}
}