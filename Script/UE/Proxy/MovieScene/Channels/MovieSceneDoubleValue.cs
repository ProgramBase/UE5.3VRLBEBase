using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneDoubleValue")]
	public partial class FMovieSceneDoubleValue : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneDoubleValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneDoubleValue() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneDoubleValue() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneDoubleValue A, FMovieSceneDoubleValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneDoubleValue A, FMovieSceneDoubleValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneDoubleValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public double Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		public FMovieSceneTangentData Tangent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Tangent, __ReturnBuffer);

					return *(FMovieSceneTangentData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Tangent, __InBuffer);
				}
			}
		}

		public ERichCurveInterpMode InterpMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InterpMode, __ReturnBuffer);

					return *(ERichCurveInterpMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InterpMode, __InBuffer);
				}
			}
		}

		public ERichCurveTangentMode TangentMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TangentMode, __ReturnBuffer);

					return *(ERichCurveTangentMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TangentMode, __InBuffer);
				}
			}
		}

		public byte PaddingByte
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PaddingByte, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PaddingByte, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

		private static uint __Tangent = 0;

		private static uint __InterpMode = 0;

		private static uint __TangentMode = 0;

		private static uint __PaddingByte = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}