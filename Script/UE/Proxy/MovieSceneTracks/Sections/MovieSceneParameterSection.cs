using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneParameterSection")]
	public partial class UMovieSceneParameterSection : UMovieSceneSection, IStaticClass, IMovieSceneEntityProvider
	{
		public TArray<FBoolParameterNameAndCurve> BoolParameterNamesAndCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BoolParameterNamesAndCurves, __ReturnBuffer);

					return *(TArray<FBoolParameterNameAndCurve>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BoolParameterNamesAndCurves, __InBuffer);
				}
			}
		}

		public TArray<FScalarParameterNameAndCurve> ScalarParameterNamesAndCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScalarParameterNamesAndCurves, __ReturnBuffer);

					return *(TArray<FScalarParameterNameAndCurve>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScalarParameterNamesAndCurves, __InBuffer);
				}
			}
		}

		public TArray<FVector2DParameterNameAndCurves> Vector2DParameterNamesAndCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Vector2DParameterNamesAndCurves, __ReturnBuffer);

					return *(TArray<FVector2DParameterNameAndCurves>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Vector2DParameterNamesAndCurves, __InBuffer);
				}
			}
		}

		public TArray<FVectorParameterNameAndCurves> VectorParameterNamesAndCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VectorParameterNamesAndCurves, __ReturnBuffer);

					return *(TArray<FVectorParameterNameAndCurves>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VectorParameterNamesAndCurves, __InBuffer);
				}
			}
		}

		public TArray<FColorParameterNameAndCurves> ColorParameterNamesAndCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ColorParameterNamesAndCurves, __ReturnBuffer);

					return *(TArray<FColorParameterNameAndCurves>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ColorParameterNamesAndCurves, __InBuffer);
				}
			}
		}

		public TArray<FTransformParameterNameAndCurves> TransformParameterNamesAndCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TransformParameterNamesAndCurves, __ReturnBuffer);

					return *(TArray<FTransformParameterNameAndCurves>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TransformParameterNamesAndCurves, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneParameterSection");
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

		/// <param name="InParameterName">
		/// The name of the vector parameter to remove.
		/// </param>
		/// <returns>
		/// True if a parameter with that name was found and removed, otherwise false.
		/// </returns>
		public virtual bool RemoveVectorParameter(FName InParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveVectorParameter, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InParameterName">
		/// The name of the vector2D parameter to remove.
		/// </param>
		/// <returns>
		/// True if a parameter with that name was found and removed, otherwise false.
		/// </returns>
		public virtual bool RemoveVector2DParameter(FName InParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveVector2DParameter, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InParameterName">
		/// The name of the transform parameter to remove.
		/// </param>
		/// <returns>
		/// True if a parameter with that name was found and removed, otherwise false.
		/// </returns>
		public virtual bool RemoveTransformParameter(FName InParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveTransformParameter, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InParameterName">
		/// The name of the scalar parameter to remove.
		/// </param>
		/// <returns>
		/// True if a parameter with that name was found and removed, otherwise false.
		/// </returns>
		public virtual bool RemoveScalarParameter(FName InParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveScalarParameter, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InParameterName">
		/// The name of the color parameter to remove.
		/// </param>
		/// <returns>
		/// True if a parameter with that name was found and removed, otherwise false.
		/// </returns>
		public virtual bool RemoveColorParameter(FName InParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveColorParameter, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InParameterName">
		/// The name of the bool parameter to remove.
		/// </param>
		/// <returns>
		/// True if a parameter with that name was found and removed, otherwise false.
		/// </returns>
		public virtual bool RemoveBoolParameter(FName InParameterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveBoolParameter, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void GetParameterNames(ref TSet<FName> ParameterNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ParameterNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetParameterNames, __InBuffer, __OutBuffer);

				ParameterNames = *(TSet<FName>*)(__OutBuffer);

			}
		}

		public virtual void AddVectorParameterKey(FName InParameterName, FFrameNumber InTime, FVector InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTime?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddVectorParameterKey, __InBuffer);
			}
		}

		public virtual void AddVector2DParameterKey(FName InParameterName, FFrameNumber InTime, FVector2D InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTime?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddVector2DParameterKey, __InBuffer);
			}
		}

		public virtual void AddTransformParameterKey(FName InParameterName, FFrameNumber InTime, FTransform InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTime?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddTransformParameterKey, __InBuffer);
			}
		}

		public virtual void AddScalarParameterKey(FName InParameterName, FFrameNumber InTime, float InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTime?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddScalarParameterKey, __InBuffer);
			}
		}

		public virtual void AddColorParameterKey(FName InParameterName, FFrameNumber InTime, FLinearColor InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTime?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddColorParameterKey, __InBuffer);
			}
		}

		public virtual void AddBoolParameterKey(FName InParameterName, FFrameNumber InTime, bool InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTime?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddBoolParameterKey, __InBuffer);
			}
		}

		private static uint __BoolParameterNamesAndCurves = 0;

		private static uint __ScalarParameterNamesAndCurves = 0;

		private static uint __Vector2DParameterNamesAndCurves = 0;

		private static uint __VectorParameterNamesAndCurves = 0;

		private static uint __ColorParameterNamesAndCurves = 0;

		private static uint __TransformParameterNamesAndCurves = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __RemoveVectorParameter = 0;

		private static uint __RemoveVector2DParameter = 0;

		private static uint __RemoveTransformParameter = 0;

		private static uint __RemoveScalarParameter = 0;

		private static uint __RemoveColorParameter = 0;

		private static uint __RemoveBoolParameter = 0;

		private static uint __GetParameterNames = 0;

		private static uint __AddVectorParameterKey = 0;

		private static uint __AddVector2DParameterKey = 0;

		private static uint __AddTransformParameterKey = 0;

		private static uint __AddScalarParameterKey = 0;

		private static uint __AddColorParameterKey = 0;

		private static uint __AddBoolParameterKey = 0;
	}
}