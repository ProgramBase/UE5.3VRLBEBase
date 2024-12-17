using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.SequencerScripting
{
	[PathName("/Script/SequencerScripting.SequencerScriptingRangeExtensions")]
	public partial class USequencerScriptingRangeExtensions : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerScripting.SequencerScriptingRangeExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Range">
		/// The range to set the start on
		/// </param>
		public static void SetStartSeconds(ref FSequencerScriptingRange Range, float Start)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Range?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Start;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetStartSeconds, __InBuffer, __OutBuffer);

				Range = *(FSequencerScriptingRange*)(__OutBuffer);

			}
		}

		/// <param name="Range">
		/// The range to set the start on
		/// </param>
		public static void SetStartFrame(ref FSequencerScriptingRange Range, int Start)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Range?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Start;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetStartFrame, __InBuffer, __OutBuffer);

				Range = *(FSequencerScriptingRange*)(__OutBuffer);

			}
		}

		/// <param name="Range">
		/// The range to set the end on
		/// </param>
		public static void SetEndSeconds(ref FSequencerScriptingRange Range, float End)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Range?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = End;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetEndSeconds, __InBuffer, __OutBuffer);

				Range = *(FSequencerScriptingRange*)(__OutBuffer);

			}
		}

		/// <param name="Range">
		/// The range to set the end on
		/// </param>
		public static void SetEndFrame(ref FSequencerScriptingRange Range, int End)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Range?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = End;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetEndFrame, __InBuffer, __OutBuffer);

				Range = *(FSequencerScriptingRange*)(__OutBuffer);

			}
		}

		/// <param name="Range">
		/// The range to remove the start from
		/// </param>
		public static void RemoveStart(ref FSequencerScriptingRange Range)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Range?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __RemoveStart, __InBuffer, __OutBuffer);

				Range = *(FSequencerScriptingRange*)(__OutBuffer);

			}
		}

		/// <param name="Range">
		/// The range to remove the end from
		/// </param>
		public static void RemoveEnd(ref FSequencerScriptingRange Range)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Range?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __RemoveEnd, __InBuffer, __OutBuffer);

				Range = *(FSequencerScriptingRange*)(__OutBuffer);

			}
		}

		/// <param name="Range">
		/// The range to check
		/// </param>
		public static bool HasStart(FSequencerScriptingRange Range)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Range?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasStart, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Range">
		/// The range to check
		/// </param>
		public static bool HasEnd(FSequencerScriptingRange Range)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Range?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasEnd, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Range">
		/// The range to get the start from
		/// </param>
		public static float GetStartSeconds(FSequencerScriptingRange Range)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Range?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetStartSeconds, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Range">
		/// The range to get the start from
		/// </param>
		public static int GetStartFrame(FSequencerScriptingRange Range)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Range?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetStartFrame, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Range">
		/// The range to get the end from
		/// </param>
		public static float GetEndSeconds(FSequencerScriptingRange Range)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Range?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetEndSeconds, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Range">
		/// The range to get the end from
		/// </param>
		public static int GetEndFrame(FSequencerScriptingRange Range)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Range?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetEndFrame, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __SetStartSeconds = 0;

		private static uint __SetStartFrame = 0;

		private static uint __SetEndSeconds = 0;

		private static uint __SetEndFrame = 0;

		private static uint __RemoveStart = 0;

		private static uint __RemoveEnd = 0;

		private static uint __HasStart = 0;

		private static uint __HasEnd = 0;

		private static uint __GetStartSeconds = 0;

		private static uint __GetStartFrame = 0;

		private static uint __GetEndSeconds = 0;

		private static uint __GetEndFrame = 0;
	}
}