using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.MovieScene;

namespace Script.SequencerScripting
{
	[PathName("/Script/SequencerScripting.MovieSceneSectionExtensions")]
	public partial class UMovieSceneSectionExtensions : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerScripting.MovieSceneSectionExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Section">
		/// The section within which to set the start time
		/// </param>
		/// <param name="StartTime">
		/// The desired start time for this section
		/// </param>
		public static void SetStartFrameSeconds(UMovieSceneSection Section, float StartTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = StartTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetStartFrameSeconds, __InBuffer);
			}
		}

		/// <param name="Section">
		/// The section to set whether the start frame is bounded or not
		/// </param>
		/// <param name="IsBounded">
		/// The desired bounded state of the start frame
		/// </param>
		public static void SetStartFrameBounded(UMovieSceneSection Section, bool bIsBounded)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsBounded;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetStartFrameBounded, __InBuffer);
			}
		}

		/// <param name="Section">
		/// The section within which to set the start frame
		/// </param>
		/// <param name="StartFrame">
		/// The desired start frame for this section
		/// </param>
		public static void SetStartFrame(UMovieSceneSection Section, int StartFrame)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = StartFrame;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetStartFrame, __InBuffer);
			}
		}

		/// <param name="Section">
		/// The section within which to set the range
		/// </param>
		/// <param name="StartTime">
		/// The desired start frame for this section
		/// </param>
		/// <param name="EndTime">
		/// The desired end frame for this section
		/// </param>
		public static void SetRangeSeconds(UMovieSceneSection Section, float StartTime, float EndTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = StartTime;

				*(float*)(__InBuffer + 12) = EndTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetRangeSeconds, __InBuffer);
			}
		}

		/// <param name="Section">
		/// The section within which to set the range
		/// </param>
		/// <param name="StartFrame">
		/// The desired start frame for this section
		/// </param>
		/// <param name="EndFrame">
		/// The desired end frame for this section
		/// </param>
		public static void SetRange(UMovieSceneSection Section, int StartFrame, int EndFrame)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = StartFrame;

				*(int*)(__InBuffer + 12) = EndFrame;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetRange, __InBuffer);
			}
		}

		/// <param name="Section">
		/// The section within which to set the end time
		/// </param>
		/// <param name="EndTime">
		/// The desired end time for this section
		/// </param>
		public static void SetEndFrameSeconds(UMovieSceneSection Section, float EndTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = EndTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetEndFrameSeconds, __InBuffer);
			}
		}

		/// <param name="Section">
		/// The section to set whether the end frame is bounded or not
		/// </param>
		/// <param name="IsBounded">
		/// The desired bounded state of the end frame
		/// </param>
		public static void SetEndFrameBounded(UMovieSceneSection Section, bool bIsBounded)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsBounded;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetEndFrameBounded, __InBuffer);
			}
		}

		/// <param name="Section">
		/// The section within which to set the end frame
		/// </param>
		/// <param name="EndFrame">
		/// The desired start frame for this section
		/// </param>
		public static void SetEndFrame(UMovieSceneSection Section, int EndFrame)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = EndFrame;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetEndFrame, __InBuffer);
			}
		}

		/// <param name="Section">
		/// The section being queried
		/// </param>
		/// <returns>
		/// Whether this section has a valid start frame (else infinite)
		/// </returns>
		public static bool HasStartFrame(UMovieSceneSection Section)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasStartFrame, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Section">
		/// The section being queried
		/// </param>
		/// <returns>
		/// Whether this section has a valid end frame (else infinite)
		/// </returns>
		public static bool HasEndFrame(UMovieSceneSection Section)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasEndFrame, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Section">
		/// The section within which to get the start time
		/// </param>
		/// <returns>
		/// Start time of this section
		/// </returns>
		public static float GetStartFrameSeconds(UMovieSceneSection Section)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetStartFrameSeconds, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Section">
		/// The section within which to get the start frame
		/// </param>
		/// <returns>
		/// Start frame of this section
		/// </returns>
		public static int GetStartFrame(UMovieSceneSection Section)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetStartFrame, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Section">
		/// The section that the InFrame is local to
		/// </param>
		/// <param name="InFrame">
		/// The desired local frame
		/// </param>
		/// <param name="ParentSequence">
		/// The parent sequence to traverse from
		/// </param>
		/// <returns>
		/// The frame at the parent sequence
		/// </returns>
		public static int GetParentSequenceFrame(UMovieSceneSubSection Section, int InFrame, UMovieSceneSequence ParentSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InFrame;

				*(nint*)(__InBuffer + 12) = ParentSequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetParentSequenceFrame, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Section">
		/// The section within which to get the end time
		/// </param>
		/// <returns>
		/// End time of this section
		/// </returns>
		public static float GetEndFrameSeconds(UMovieSceneSection Section)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetEndFrameSeconds, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Section">
		/// The section within which to get the end frame
		/// </param>
		/// <returns>
		/// End frame of this section
		/// </returns>
		public static int GetEndFrame(UMovieSceneSection Section)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetEndFrame, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Section">
		/// The section to use.
		/// </param>
		/// <param name="ChannelType">
		/// The class type to look for.
		/// </param>
		/// <returns>
		/// An array containing any key channels that match the type specified
		/// </returns>
		public static TArray<UMovieSceneScriptingChannel> GetChannelsByType(UMovieSceneSection Section, TSubclassOf<UMovieSceneScriptingChannel> ChannelType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ChannelType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetChannelsByType, __InBuffer, __ReturnBuffer);

				return *(TArray<UMovieSceneScriptingChannel>*)__ReturnBuffer;
			}
		}

		/// <param name="Section">
		/// The section being queried
		/// </param>
		/// <returns>
		/// The start frame of the AutoSize data in seconds.
		/// </returns>
		public static float GetAutoSizeStartFrameSeconds(UMovieSceneSection Section)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAutoSizeStartFrameSeconds, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Section">
		/// The section being queried
		/// </param>
		/// <returns>
		/// The start frame of the AutoSize data.
		/// </returns>
		public static int GetAutoSizeStartFrame(UMovieSceneSection Section)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAutoSizeStartFrame, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Section">
		/// The section being queried
		/// </param>
		/// <returns>
		/// Whether this section has a valid autosize range, and a valid start frame
		/// </returns>
		public static bool GetAutoSizeHasStartFrame(UMovieSceneSection Section)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAutoSizeHasStartFrame, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Section">
		/// The section being queried
		/// </param>
		/// <returns>
		/// Whether this section has a valid autosize range, and a valid end frame
		/// </returns>
		public static bool GetAutoSizeHasEndFrame(UMovieSceneSection Section)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAutoSizeHasEndFrame, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Section">
		/// The section being queried
		/// </param>
		/// <returns>
		/// The end frame of the AutoSize data in seconds.
		/// </returns>
		public static float GetAutoSizeEndFrameSeconds(UMovieSceneSection Section)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAutoSizeEndFrameSeconds, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Section">
		/// The section being queried
		/// </param>
		/// <returns>
		/// The end frame of the AutoSize data.
		/// </returns>
		public static int GetAutoSizeEndFrame(UMovieSceneSection Section)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAutoSizeEndFrame, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Section">
		/// The section to use.
		/// </param>
		/// <returns>
		/// An array containing any key channels that match the type specified
		/// </returns>
		public static TArray<UMovieSceneScriptingChannel> GetAllChannels(UMovieSceneSection Section)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Section?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAllChannels, __InBuffer, __ReturnBuffer);

				return *(TArray<UMovieSceneScriptingChannel>*)__ReturnBuffer;
			}
		}

		private static uint __SetStartFrameSeconds = 0;

		private static uint __SetStartFrameBounded = 0;

		private static uint __SetStartFrame = 0;

		private static uint __SetRangeSeconds = 0;

		private static uint __SetRange = 0;

		private static uint __SetEndFrameSeconds = 0;

		private static uint __SetEndFrameBounded = 0;

		private static uint __SetEndFrame = 0;

		private static uint __HasStartFrame = 0;

		private static uint __HasEndFrame = 0;

		private static uint __GetStartFrameSeconds = 0;

		private static uint __GetStartFrame = 0;

		private static uint __GetParentSequenceFrame = 0;

		private static uint __GetEndFrameSeconds = 0;

		private static uint __GetEndFrame = 0;

		private static uint __GetChannelsByType = 0;

		private static uint __GetAutoSizeStartFrameSeconds = 0;

		private static uint __GetAutoSizeStartFrame = 0;

		private static uint __GetAutoSizeHasStartFrame = 0;

		private static uint __GetAutoSizeHasEndFrame = 0;

		private static uint __GetAutoSizeEndFrameSeconds = 0;

		private static uint __GetAutoSizeEndFrame = 0;

		private static uint __GetAllChannels = 0;
	}
}