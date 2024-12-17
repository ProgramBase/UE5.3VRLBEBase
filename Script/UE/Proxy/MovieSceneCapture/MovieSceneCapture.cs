using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneCapture
{
	[PathName("/Script/MovieSceneCapture.MovieSceneCapture")]
	public partial class UMovieSceneCapture : UObject, IStaticClass, IMovieSceneCaptureInterface
	{
		public FSoftClassPath ImageCaptureProtocolType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ImageCaptureProtocolType, __ReturnBuffer);

					return *(FSoftClassPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ImageCaptureProtocolType, __InBuffer);
				}
			}
		}

		public FSoftClassPath AudioCaptureProtocolType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AudioCaptureProtocolType, __ReturnBuffer);

					return *(FSoftClassPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AudioCaptureProtocolType, __InBuffer);
				}
			}
		}

		public UMovieSceneImageCaptureProtocolBase ImageCaptureProtocol
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ImageCaptureProtocol, __ReturnBuffer);

					return *(UMovieSceneImageCaptureProtocolBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ImageCaptureProtocol, __InBuffer);
				}
			}
		}

		public UMovieSceneAudioCaptureProtocolBase AudioCaptureProtocol
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AudioCaptureProtocol, __ReturnBuffer);

					return *(UMovieSceneAudioCaptureProtocolBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AudioCaptureProtocol, __InBuffer);
				}
			}
		}

		public FMovieSceneCaptureSettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(FMovieSceneCaptureSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __InBuffer);
				}
			}
		}

		public bool bUseSeparateProcess
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseSeparateProcess, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseSeparateProcess, __InBuffer);
				}
			}
		}

		public bool bCloseEditorWhenCaptureStarts
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCloseEditorWhenCaptureStarts, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCloseEditorWhenCaptureStarts, __InBuffer);
				}
			}
		}

		public FString AdditionalCommandLineArguments
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AdditionalCommandLineArguments, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AdditionalCommandLineArguments, __InBuffer);
				}
			}
		}

		public FString InheritedCommandLineArguments
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InheritedCommandLineArguments, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InheritedCommandLineArguments, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneCapture.MovieSceneCapture");
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

		public virtual void SetImageCaptureProtocolType(TSubclassOf<UMovieSceneCaptureProtocolBase> ProtocolType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ProtocolType?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetImageCaptureProtocolType, __InBuffer);
			}
		}

		public virtual void SetAudioCaptureProtocolType(TSubclassOf<UMovieSceneCaptureProtocolBase> ProtocolType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ProtocolType?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAudioCaptureProtocolType, __InBuffer);
			}
		}

		public virtual UMovieSceneCaptureProtocolBase GetImageCaptureProtocol()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetImageCaptureProtocol, __ReturnBuffer);

				return *(UMovieSceneCaptureProtocolBase*)__ReturnBuffer;
			}
		}

		public virtual UMovieSceneCaptureProtocolBase GetAudioCaptureProtocol()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAudioCaptureProtocol, __ReturnBuffer);

				return *(UMovieSceneCaptureProtocolBase*)__ReturnBuffer;
			}
		}

		private static uint __ImageCaptureProtocolType = 0;

		private static uint __AudioCaptureProtocolType = 0;

		private static uint __ImageCaptureProtocol = 0;

		private static uint __AudioCaptureProtocol = 0;

		private static uint __Settings = 0;

		private static uint __bUseSeparateProcess = 0;

		private static uint __bCloseEditorWhenCaptureStarts = 0;

		private static uint __AdditionalCommandLineArguments = 0;

		private static uint __InheritedCommandLineArguments = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SetImageCaptureProtocolType = 0;

		private static uint __SetAudioCaptureProtocolType = 0;

		private static uint __GetImageCaptureProtocol = 0;

		private static uint __GetAudioCaptureProtocol = 0;
	}
}