using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEasingExternalCurve")]
	public partial class UMovieSceneEasingExternalCurve : UObject, IStaticClass, IMovieSceneEasingFunction
	{
		public UCurveFloat Curve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Curve, __ReturnBuffer);

					return *(UCurveFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Curve, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneEasingExternalCurve");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual float OnEvaluate(float Interp)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Interp;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall3Implementation(GarbageCollectionHandle, __OnEvaluate, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

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

		private static uint __Curve = 0;

		private static uint __OnEvaluate = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}