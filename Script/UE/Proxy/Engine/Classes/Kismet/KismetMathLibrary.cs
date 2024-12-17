using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.KismetMathLibrary")]
	public partial class UKismetMathLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.KismetMathLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static int Xor_IntInt(int A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = A;

				*(int*)(__InBuffer + 4) = B;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Xor_IntInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static long Xor_Int64Int64(long A, long B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(long*)(__InBuffer) = A;

				*(long*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Xor_Int64Int64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static int Wrap(int Value, int Min, int Max)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = Value;

				*(int*)(__InBuffer + 4) = Min;

				*(int*)(__InBuffer + 8) = Max;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Wrap, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="CurrentSample">
		/// - The value to blend with the previous sample to get a new weighted value
		/// </param>
		/// <param name="PreviousSample">
		/// - The last value from the series
		/// </param>
		/// <param name="Weight">
		/// - The weight to blend with
		/// </param>
		/// <returns>
		/// the next value in the series
		/// </returns>
		public static FVector WeightedMovingAverage_FVector(FVector CurrentSample, FVector PreviousSample, float Weight)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = CurrentSample?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PreviousSample?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Weight;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __WeightedMovingAverage_FVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="CurrentSample">
		/// - The value to blend with the previous sample to get a new weighted value
		/// </param>
		/// <param name="PreviousSample">
		/// - The last value from the series
		/// </param>
		/// <param name="Weight">
		/// - The weight to blend with
		/// </param>
		/// <returns>
		/// the next value in the series
		/// </returns>
		public static FRotator WeightedMovingAverage_FRotator(FRotator CurrentSample, FRotator PreviousSample, float Weight)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = CurrentSample?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PreviousSample?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Weight;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __WeightedMovingAverage_FRotator, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <param name="CurrentSample">
		/// - The value to blend with the previous sample to get a new weighted value
		/// </param>
		/// <param name="PreviousSample">
		/// - The last value from the series
		/// </param>
		/// <param name="Weight">
		/// - The weight to blend with
		/// </param>
		/// <returns>
		/// the next value in the series
		/// </returns>
		public static float WeightedMovingAverage_Float(float CurrentSample, float PreviousSample, float Weight)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = CurrentSample;

				*(float*)(__InBuffer + 4) = PreviousSample;

				*(float*)(__InBuffer + 8) = Weight;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __WeightedMovingAverage_Float, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static double VSizeXYSquared(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __VSizeXYSquared, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double VSizeXY(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __VSizeXY, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double VSizeSquared(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __VSizeSquared, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double VSize2DSquared(FVector2D A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __VSize2DSquared, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double VSize2D(FVector2D A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __VSize2D, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double VSize(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __VSize, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FVector VLerp(FVector A, FVector B, float Alpha)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Alpha;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __VLerp, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="Current">
		/// Actual position
		/// </param>
		/// <param name="Target">
		/// Target position
		/// </param>
		/// <param name="DeltaTime">
		/// Time since last tick
		/// </param>
		/// <param name="InterpSpeed">
		/// Interpolation speed
		/// </param>
		/// <returns>
		/// New interpolated position
		/// </returns>
		public static FVector VInterpTo_Constant(FVector Current, FVector Target, float DeltaTime, float InterpSpeed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Current?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Target?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = DeltaTime;

				*(float*)(__InBuffer + 20) = InterpSpeed;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __VInterpTo_Constant, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="Current">
		/// Actual position
		/// </param>
		/// <param name="Target">
		/// Target position
		/// </param>
		/// <param name="DeltaTime">
		/// Time since last tick
		/// </param>
		/// <param name="InterpSpeed">
		/// Interpolation speed, if the speed given is 0, then jump to the target.
		/// </param>
		/// <returns>
		/// New interpolated position
		/// </returns>
		public static FVector VInterpTo(FVector Current, FVector Target, float DeltaTime, float InterpSpeed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Current?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Target?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = DeltaTime;

				*(float*)(__InBuffer + 20) = InterpSpeed;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __VInterpTo, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="Current">
		/// Current value
		/// </param>
		/// <param name="Target">
		/// Target value
		/// </param>
		/// <param name="SpringState">
		/// Data related to spring model (velocity, error, etc..) - Create a unique variable per spring
		/// </param>
		/// <param name="Stiffness">
		/// How stiff the spring model is (more stiffness means more oscillation around the target value)
		/// </param>
		/// <param name="CriticalDampingFactor">
		/// How much damping to apply to the spring (0 means no damping, 1 means critically damped which means no oscillation)
		/// </param>
		/// <param name="DeltaTime">
		/// Time difference since the last update
		/// </param>
		/// <param name="Mass">
		/// Multiplier that acts like mass on a spring
		/// </param>
		/// <param name="TargetVelocityAmount">
		/// If 1 then the target velocity will be calculated and used, which results following the target more closely/without lag. Values down to zero (recommended when using this to smooth data) will progressively disable this effect.
		/// </param>
		/// <param name="bClamp">
		/// Whether to use the Min/Max values to clamp the motion
		/// </param>
		/// <param name="MinValue">
		/// Clamps the minimum output value and cancels the velocity if it reaches this limit
		/// </param>
		/// <param name="MaxValue">
		/// Clamps the maximum output value and cancels the velocity if it reaches this limit
		/// </param>
		/// <param name="bInitializeFromTarget">
		/// If set then the current value will be set from the target on the first update
		/// </param>
		public static FVector VectorSpringInterp(FVector Current, FVector Target, ref FVectorSpringState SpringState, float Stiffness, float CriticalDampingFactor, float DeltaTime, float Mass, float TargetVelocityAmount, bool bClamp, FVector MinValue, FVector MaxValue, bool bInitializeFromTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[62];

				*(nint*)(__InBuffer) = Current?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Target?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SpringState?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Stiffness;

				*(float*)(__InBuffer + 28) = CriticalDampingFactor;

				*(float*)(__InBuffer + 32) = DeltaTime;

				*(float*)(__InBuffer + 36) = Mass;

				*(float*)(__InBuffer + 40) = TargetVelocityAmount;

				*(bool*)(__InBuffer + 44) = bClamp;

				*(nint*)(__InBuffer + 45) = MinValue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 53) = MaxValue?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 61) = bInitializeFromTarget;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __VectorSpringInterp, __InBuffer, __OutBuffer, __ReturnBuffer);

				SpringState = *(FVectorSpringState*)(__OutBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Vector_Zero()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Vector_Zero, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Vector_Up()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Vector_Up, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static void Vector_UnwindEuler(ref FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Vector_UnwindEuler, __InBuffer, __OutBuffer);

				A = *(FVector*)(__OutBuffer);

			}
		}

		/// <returns>
		/// Output Theta will be in the range [0, PI], and output Phi will be in the range [-PI, PI]. 
		/// </returns>
		public static FVector2D Vector_UnitCartesianToSpherical(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_UnitCartesianToSpherical, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Vector containing radian values
		/// </returns>
		public static FVector Vector_ToRadians(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_ToRadians, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Vector  containing degree values
		/// </returns>
		public static FVector Vector_ToDegrees(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_ToDegrees, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="InGridSize">
		/// Grid dimension / step.
		/// </param>
		/// <returns>
		/// A copy of this vector snapped to a grid.
		/// </returns>
		public static FVector Vector_SnappedToGrid(FVector InVect, float InGridSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InVect?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InGridSize;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_SnappedToGrid, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="Vector">
		/// Vector we interpolate from
		/// </param>
		/// <param name="Direction">
		/// Target direction we interpolate to
		/// </param>
		/// <param name="Alpha">
		/// interpolation amount, usually between 0-1
		/// </param>
		/// <returns>
		/// Vector after interpolating between Vector and Direction along a spherical path. The magnitude will remain the length of the starting vector.
		/// </returns>
		public static FVector Vector_SlerpVectorToDirection(FVector Vector, FVector Direction, double Alpha)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Vector?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Direction?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 16) = Alpha;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_SlerpVectorToDirection, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="NormalA">
		/// Start direction of interpolation, must be normalized.
		/// </param>
		/// <param name="NormalB">
		/// End target direction of interpolation, must be normalized.
		/// </param>
		/// <param name="Alpha">
		/// interpolation amount, usually between 0-1
		/// </param>
		/// <returns>
		/// Vector after interpolating between A and B along a spherical path.
		/// </returns>
		public static FVector Vector_SlerpNormals(FVector NormalA, FVector NormalB, double Alpha)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NormalA?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NormalB?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 16) = Alpha;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_SlerpNormals, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="InX">
		/// New X coordinate.
		/// </param>
		/// <param name="InY">
		/// New Y coordinate.
		/// </param>
		/// <param name="InZ">
		/// New Z coordinate.
		/// </param>
		public static void Vector_Set(ref FVector A, double X, double Y, double Z)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = X;

				*(double*)(__InBuffer + 16) = Y;

				*(double*)(__InBuffer + 24) = Z;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Vector_Set, __InBuffer, __OutBuffer);

				A = *(FVector*)(__OutBuffer);

			}
		}

		public static FVector Vector_Right()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Vector_Right, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Reciprocal of this vector.
		/// </returns>
		public static FVector Vector_Reciprocal(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_Reciprocal, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="InNormal">
		/// Vector to project onto (assumed to be unit length).
		/// </param>
		/// <returns>
		/// Projected vector.
		/// </returns>
		public static FVector Vector_ProjectOnToNormal(FVector V, FVector InNormal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = V?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNormal?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_ProjectOnToNormal, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Vector_One()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Vector_One, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Normalized version of vector.
		/// </returns>
		public static FVector Vector_NormalUnsafe(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_NormalUnsafe, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="Tolerance">
		/// Minimum squared length of vector for normalization.
		/// </param>
		public static void Vector_Normalize(ref FVector A, float Tolerance = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Tolerance;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Vector_Normalize, __InBuffer, __OutBuffer);

				A = *(FVector*)(__OutBuffer);

			}
		}

		/// <param name="Tolerance">
		/// Minimum squared vector length.
		/// </param>
		/// <returns>
		/// Normalized copy if safe, (0,0,0) otherwise.
		/// </returns>
		public static FVector Vector_Normal2D(FVector A, float Tolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Tolerance;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_Normal2D, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="Plane">
		/// Plane to mirror about.
		/// </param>
		/// <returns>
		/// Mirrored vector.
		/// </returns>
		public static FVector Vector_MirrorByPlane(FVector A, FPlane InPlane)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPlane?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_MirrorByPlane, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Vector_Left()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Vector_Left, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if vector is exactly zero, otherwise false.
		/// </returns>
		public static bool Vector_IsZero(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_IsZero, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if unit, false otherwise.
		/// </returns>
		public static bool Vector_IsUnit(FVector A, float SquaredLenthTolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = SquaredLenthTolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_IsUnit, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Tolerance">
		/// Error tolerance.
		/// </param>
		/// <returns>
		/// true if the vectors are equal within tolerance limits, false otherwise.
		/// </returns>
		public static bool Vector_IsUniform(FVector A, float Tolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Tolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_IsUniform, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if normalized, false otherwise.
		/// </returns>
		public static bool Vector_IsNormal(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_IsNormal, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Tolerance">
		/// Error tolerance.
		/// </param>
		/// <returns>
		/// true if vector is in tolerance to zero, otherwise false.
		/// </returns>
		public static bool Vector_IsNearlyZero(FVector A, float Tolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Tolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_IsNearlyZero, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if one or more components is NAN, otherwise false.
		/// </returns>
		public static bool Vector_IsNAN(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_IsNAN, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// 'Heading' angle between +/-PI radians. 0 is pointing down +X.
		/// </returns>
		public static double Vector_HeadingAngle(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_HeadingAngle, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <param name="A">
		/// copy of the vector with each component set to +1 or -1
		/// </param>
		public static FVector Vector_GetSignVector(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_GetSignVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Projected version of vector based on Z.
		/// </returns>
		public static FVector Vector_GetProjection(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_GetProjection, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static double Vector_GetAbsMin(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_GetAbsMin, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double Vector_GetAbsMax(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_GetAbsMax, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// A copy of this vector with absolute value of each component.
		/// </returns>
		public static FVector Vector_GetAbs(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_GetAbs, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Vector_Forward()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Vector_Forward, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Vector_Down()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Vector_Down, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="V1">
		/// The first point.
		/// </param>
		/// <param name="V2">
		/// The second point.
		/// </param>
		/// <returns>
		/// The squared distance between two points.
		/// </returns>
		public static double Vector_DistanceSquared(FVector V1, FVector V2)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = V1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = V2?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_DistanceSquared, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <param name="V1">
		/// The first point.
		/// </param>
		/// <param name="V2">
		/// The second point.
		/// </param>
		/// <returns>
		/// The distance between two points in the XY plane.
		/// </returns>
		public static double Vector_Distance2DSquared(FVector V1, FVector V2)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = V1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = V2?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_Distance2DSquared, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <param name="V1">
		/// The first point.
		/// </param>
		/// <param name="V2">
		/// The second point.
		/// </param>
		/// <returns>
		/// The distance between two points in the XY plane.
		/// </returns>
		public static double Vector_Distance2D(FVector V1, FVector V2)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = V1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = V2?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_Distance2D, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <param name="V1">
		/// The first point.
		/// </param>
		/// <param name="V2">
		/// The second point.
		/// </param>
		/// <returns>
		/// The distance between two points.
		/// </returns>
		public static double Vector_Distance(FVector V1, FVector V2)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = V1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = V2?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_Distance, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <param name="B">
		/// the other vector to find the 2D cosine of the angle with.
		/// </param>
		/// <returns>
		/// The cosine.
		/// </returns>
		public static double Vector_CosineAngle2D(FVector A, FVector B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_CosineAngle2D, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FVector Vector_ComponentMin(FVector A, FVector B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_ComponentMin, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Vector_ComponentMax(FVector A, FVector B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_ComponentMax, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Vector_ClampSizeMax2D(FVector A, double Max)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = Max;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_ClampSizeMax2D, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Vector_ClampSizeMax(FVector A, double Max)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = Max;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_ClampSizeMax, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Vector_ClampSize2D(FVector A, double Min, double Max)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = Min;

				*(double*)(__InBuffer + 16) = Max;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_ClampSize2D, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="InRadius">
		/// Half size of the cube (or radius of sphere circumscribed in the cube).
		/// </param>
		/// <returns>
		/// A copy of this vector, bound by cube.
		/// </returns>
		public static FVector Vector_BoundedToCube(FVector InVect, float InRadius)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InVect?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InRadius;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_BoundedToCube, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Vector_BoundedToBox(FVector InVect, FVector InBoxMin, FVector InBoxMax)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InVect?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InBoxMin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InBoxMax?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector_BoundedToBox, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Vector_Backward()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Vector_Backward, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="InVector">
		/// Vector to copy values from.
		/// </param>
		public static void Vector_Assign(ref FVector A, FVector InVector)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InVector?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Vector_Assign, __InBuffer, __OutBuffer);

				A = *(FVector*)(__OutBuffer);

			}
		}

		/// <param name="InAddVect">
		/// Vector to add.
		/// </param>
		/// <param name="InRadius">
		/// Half size of the cube.
		/// </param>
		public static void Vector_AddBounded(ref FVector A, FVector InAddVect, float InRadius)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InAddVect?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = InRadius;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Vector_AddBounded, __InBuffer, __OutBuffer);

				A = *(FVector*)(__OutBuffer);

			}
		}

		public static FVector4 Vector4_Zero()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Vector4_Zero, __ReturnBuffer);

				return *(FVector4*)__ReturnBuffer;
			}
		}

		public static double Vector4_SizeSquared3(FVector4 A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector4_SizeSquared3, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double Vector4_SizeSquared(FVector4 A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector4_SizeSquared, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double Vector4_Size3(FVector4 A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector4_Size3, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double Vector4_Size(FVector4 A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector4_Size, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <param name="InX">
		/// New X coordinate.
		/// </param>
		/// <param name="InY">
		/// New Y coordinate.
		/// </param>
		/// <param name="InZ">
		/// New Z coordinate.
		/// </param>
		/// <param name="InW">
		/// New W coordinate.
		/// </param>
		public static void Vector4_Set(ref FVector4 A, double X, double Y, double Z, double W)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = X;

				*(double*)(__InBuffer + 16) = Y;

				*(double*)(__InBuffer + 24) = Z;

				*(double*)(__InBuffer + 32) = W;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Vector4_Set, __InBuffer, __OutBuffer);

				A = *(FVector4*)(__OutBuffer);

			}
		}

		/// <returns>
		/// Normalized version of vector.
		/// </returns>
		public static FVector4 Vector4_NormalUnsafe3(FVector4 A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector4_NormalUnsafe3, __InBuffer, __ReturnBuffer);

				return *(FVector4*)__ReturnBuffer;
			}
		}

		/// <param name="Tolerance">
		/// Minimum squared length of vector for normalization.
		/// </param>
		public static void Vector4_Normalize3(ref FVector4 A, float Tolerance = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Tolerance;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Vector4_Normalize3, __InBuffer, __OutBuffer);

				A = *(FVector4*)(__OutBuffer);

			}
		}

		/// <param name="Tolerance">
		/// Minimum squared vector length.
		/// </param>
		/// <returns>
		/// A normalized copy if safe, (0,0,0) otherwise.
		/// </returns>
		public static FVector4 Vector4_Normal3(FVector4 A, float Tolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Tolerance;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector4_Normal3, __InBuffer, __ReturnBuffer);

				return *(FVector4*)__ReturnBuffer;
			}
		}

		public static FVector4 Vector4_Negated(FVector4 A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector4_Negated, __InBuffer, __ReturnBuffer);

				return *(FVector4*)__ReturnBuffer;
			}
		}

		/// <param name="Direction">
		/// Direction vector the ray is coming from.
		/// </param>
		/// <param name="SurfaceNormal">
		/// A normal of the surface the ray should be reflected on.
		/// </param>
		/// <returns>
		/// Reflected vector.
		/// </returns>
		public static FVector4 Vector4_MirrorByVector3(FVector4 Direction, FVector4 SurfaceNormal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Direction?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SurfaceNormal?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector4_MirrorByVector3, __InBuffer, __ReturnBuffer);

				return *(FVector4*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if vector is exactly zero, otherwise false.
		/// </returns>
		public static bool Vector4_IsZero(FVector4 A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector4_IsZero, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if unit, false otherwise.
		/// </returns>
		public static bool Vector4_IsUnit3(FVector4 A, float SquaredLenthTolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = SquaredLenthTolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector4_IsUnit3, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if normalized, false otherwise.
		/// </returns>
		public static bool Vector4_IsNormal3(FVector4 A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector4_IsNormal3, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Tolerance">
		/// Error tolerance.
		/// </param>
		/// <returns>
		/// true if vector is in tolerance to zero, otherwise false.
		/// </returns>
		public static bool Vector4_IsNearlyZero3(FVector4 A, float Tolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Tolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector4_IsNearlyZero3, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if one or more components is NAN, otherwise false.
		/// </returns>
		public static bool Vector4_IsNAN(FVector4 A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector4_IsNAN, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static double Vector4_DotProduct3(FVector4 A, FVector4 B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector4_DotProduct3, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double Vector4_DotProduct(FVector4 A, FVector4 B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector4_DotProduct, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FVector4 Vector4_CrossProduct3(FVector4 A, FVector4 B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector4_CrossProduct3, __InBuffer, __ReturnBuffer);

				return *(FVector4*)__ReturnBuffer;
			}
		}

		/// <param name="InVector">
		/// Vector to copy values from.
		/// </param>
		public static void Vector4_Assign(ref FVector4 A, FVector4 InVector)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InVector?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Vector4_Assign, __InBuffer, __OutBuffer);

				A = *(FVector4*)(__OutBuffer);

			}
		}

		/// <param name="Current">
		/// Actual position
		/// </param>
		/// <param name="Target">
		/// Target position
		/// </param>
		/// <param name="DeltaTime">
		/// Time since last tick
		/// </param>
		/// <param name="InterpSpeed">
		/// Interpolation speed
		/// </param>
		/// <returns>
		/// New interpolated position
		/// </returns>
		public static FVector2D Vector2DInterpTo_Constant(FVector2D Current, FVector2D Target, float DeltaTime, float InterpSpeed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Current?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Target?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = DeltaTime;

				*(float*)(__InBuffer + 20) = InterpSpeed;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector2DInterpTo_Constant, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		/// <param name="Current">
		/// Actual position
		/// </param>
		/// <param name="Target">
		/// Target position
		/// </param>
		/// <param name="DeltaTime">
		/// Time since last tick
		/// </param>
		/// <param name="InterpSpeed">
		/// Interpolation speed, if the speed given is 0, then jump to the target.
		/// </param>
		/// <returns>
		/// New interpolated position
		/// </returns>
		public static FVector2D Vector2DInterpTo(FVector2D Current, FVector2D Target, float DeltaTime, float InterpSpeed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Current?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Target?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = DeltaTime;

				*(float*)(__InBuffer + 20) = InterpSpeed;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Vector2DInterpTo, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FVector2D Vector2D_Zero()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Vector2D_Zero, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FVector2D Vector2D_Unit45Deg()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Vector2D_Unit45Deg, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FVector2D Vector2D_One()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Vector2D_One, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FVector VEase(FVector A, FVector B, float Alpha, EEasingFunc EasingFunc, float BlendExp = 2.000000f, int Steps = 2)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Alpha;

				*(byte*)(__InBuffer + 20) = (byte)EasingFunc;

				*(float*)(__InBuffer + 21) = BlendExp;

				*(int*)(__InBuffer + 25) = Steps;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __VEase, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FDateTime UtcNow()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __UtcNow, __ReturnBuffer);

				return *(FDateTime*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Transformed vector4.
		/// </returns>
		public static FVector4 TransformVector4(FMatrix Matrix, FVector4 Vec4)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Matrix?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Vec4?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TransformVector4, __InBuffer, __ReturnBuffer);

				return *(FVector4*)__ReturnBuffer;
			}
		}

		public static FRotator TransformRotation(FTransform T, FRotator Rotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = T?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TransformRotation, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static FVector TransformLocation(FTransform T, FVector Location)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = T?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Location?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TransformLocation, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector TransformDirection(FTransform T, FVector Direction)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = T?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Direction?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TransformDirection, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static float Transform_Determinant(FTransform Transform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Transform?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Transform_Determinant, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <see>
		/// FromUnixTimestamp
		/// </see>
		/// <returns>
		/// Time of day.
		/// </returns>
		public static double ToUnixTimestampDouble(FDateTime Time)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Time?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ToUnixTimestampDouble, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <see>
		/// FromUnixTimestamp
		/// </see>
		/// <returns>
		/// Time of day.
		/// </returns>
		public static long ToUnixTimestamp(FDateTime Time)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Time?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ToUnixTimestamp, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// A copy of the vector with each component set to +1 or -1
		/// </returns>
		public static FVector2D ToSign2D(FVector2D A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ToSign2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// New FVector2D from this vector that is rounded.
		/// </returns>
		public static FVector2D ToRounded2D(FVector2D A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ToRounded2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FString ToHex_LinearColor(FLinearColor InColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ToHex_LinearColor, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="OutDir">
		/// Reference passed in to store unit direction vector.
		/// </param>
		/// <param name="OutLength">
		/// Reference passed in to store length of the vector.
		/// </param>
		public static void ToDirectionAndLength2D(FVector2D A, ref FVector2D OutDir, ref double OutLength)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutDir?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 16) = OutLength;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ToDirectionAndLength2D, __InBuffer, __OutBuffer);

				OutDir = *(FVector2D*)(__OutBuffer);

				OutLength = *(double*)(__OutBuffer + 8);

			}
		}

		public static FDateTime Today()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Today, __ReturnBuffer);

				return *(FDateTime*)__ReturnBuffer;
			}
		}

		public static FTransform TLerp(FTransform A, FTransform B, float Alpha, ELerpInterpolationMode InterpMode = ELerpInterpolationMode.QuatInterp)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Alpha;

				*(byte*)(__InBuffer + 20) = (byte)InterpMode;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TLerp, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="Current">
		/// Actual transform
		/// </param>
		/// <param name="Target">
		/// Target transform
		/// </param>
		/// <param name="DeltaTime">
		/// Time since last tick
		/// </param>
		/// <param name="InterpSpeed">
		/// Interpolation speed, if the speed given is 0, then jump to the target.
		/// </param>
		/// <returns>
		/// New interpolated transform
		/// </returns>
		public static FTransform TInterpTo(FTransform Current, FTransform Target, float DeltaTime, float InterpSpeed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Current?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Target?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = DeltaTime;

				*(float*)(__InBuffer + 20) = InterpSpeed;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TInterpTo, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public static FTimespan TimespanZeroValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __TimespanZeroValue, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		public static float TimespanRatio(FTimespan A, FTimespan B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __TimespanRatio, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static FTimespan TimespanMinValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __TimespanMinValue, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		public static FTimespan TimespanMaxValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __TimespanMaxValue, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		public static bool TimespanFromString(FString TimespanString, ref FTimespan Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TimespanString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Result?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __TimespanFromString, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(FTimespan*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FTransform TEase(FTransform A, FTransform B, float Alpha, EEasingFunc EasingFunc, float BlendExp = 2.000000f, int Steps = 2)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Alpha;

				*(byte*)(__InBuffer + 20) = (byte)EasingFunc;

				*(float*)(__InBuffer + 21) = BlendExp;

				*(int*)(__InBuffer + 25) = Steps;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TEase, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public static double Tan(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Tan, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FVector Subtract_VectorVector(FVector A, FVector B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Subtract_VectorVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Subtract_VectorInt(FVector A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Subtract_VectorInt, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Subtract_VectorFloat(FVector A, double B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Subtract_VectorFloat, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector4 Subtract_Vector4Vector4(FVector4 A, FVector4 B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Subtract_Vector4Vector4, __InBuffer, __ReturnBuffer);

				return *(FVector4*)__ReturnBuffer;
			}
		}

		public static FVector2D Subtract_Vector2DVector2D(FVector2D A, FVector2D B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Subtract_Vector2DVector2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FVector2D Subtract_Vector2DFloat(FVector2D A, double B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Subtract_Vector2DFloat, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FTimespan Subtract_TimespanTimespan(FTimespan A, FTimespan B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Subtract_TimespanTimespan, __InBuffer, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		public static FQuat Subtract_QuatQuat(FQuat A, FQuat B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Subtract_QuatQuat, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		public static FLinearColor Subtract_LinearColorLinearColor(FLinearColor A, FLinearColor B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Subtract_LinearColorLinearColor, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static FIntPoint Subtract_IntPointIntPoint(FIntPoint A, FIntPoint B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Subtract_IntPointIntPoint, __InBuffer, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public static FIntPoint Subtract_IntPointInt(FIntPoint A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Subtract_IntPointInt, __InBuffer, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public static int Subtract_IntInt(int A, int B = 1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = A;

				*(int*)(__InBuffer + 4) = B;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Subtract_IntInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static long Subtract_Int64Int64(long A, long B = 1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(long*)(__InBuffer) = A;

				*(long*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Subtract_Int64Int64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static double Subtract_DoubleDouble(double A, double B = 1.000000)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Subtract_DoubleDouble, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FDateTime Subtract_DateTimeTimespan(FDateTime A, FTimespan B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Subtract_DateTimeTimespan, __InBuffer, __ReturnBuffer);

				return *(FDateTime*)__ReturnBuffer;
			}
		}

		public static FTimespan Subtract_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Subtract_DateTimeDateTime, __InBuffer, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		public static byte Subtract_ByteByte(byte A, byte B = 1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = A;

				*(byte*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Subtract_ByteByte, __InBuffer, __ReturnBuffer);

				return *(byte*)__ReturnBuffer;
			}
		}

		public static double Square(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Square, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double Sqrt(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Sqrt, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FVector Spherical2DToUnitCartesian(FVector2D A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Spherical2DToUnitCartesian, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static double Sin(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Sin, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static long SignOfInteger64(long A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(long*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SignOfInteger64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static int SignOfInteger(int A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SignOfInteger, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static double SignOfFloat(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SignOfFloat, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static void SetVectorSpringStateVelocity(ref FVectorSpringState SpringState, FVector Velocity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SpringState?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Velocity?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetVectorSpringStateVelocity, __InBuffer, __OutBuffer);

				SpringState = *(FVectorSpringState*)(__OutBuffer);

			}
		}

		public static void SetRandomStreamSeed(ref FRandomStream Stream, int NewSeed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Stream?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = NewSeed;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetRandomStreamSeed, __InBuffer, __OutBuffer);

				Stream = *(FRandomStream*)(__OutBuffer);

			}
		}

		public static void SetQuaternionSpringStateAngularVelocity(ref FQuaternionSpringState SpringState, FVector AngularVelocity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SpringState?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AngularVelocity?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetQuaternionSpringStateAngularVelocity, __InBuffer, __OutBuffer);

				SpringState = *(FQuaternionSpringState*)(__OutBuffer);

			}
		}

		public static void SetFloatSpringStateVelocity(ref FFloatSpringState SpringState, float Velocity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SpringState?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Velocity;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetFloatSpringStateVelocity, __InBuffer, __OutBuffer);

				SpringState = *(FFloatSpringState*)(__OutBuffer);

			}
		}

		/// <param name="InX">
		/// New X coordinate.
		/// </param>
		/// <param name="InY">
		/// New Y coordinate.
		/// </param>
		public static void Set2D(ref FVector2D A, double X, double Y)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = X;

				*(double*)(__InBuffer + 16) = Y;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Set2D, __InBuffer, __OutBuffer);

				A = *(FVector2D*)(__OutBuffer);

			}
		}

		public static FVector SelectVector(FVector A, FVector B, bool bPickA)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bPickA;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SelectVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FTransform SelectTransform(FTransform A, FTransform B, bool bPickA)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bPickA;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SelectTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public static FString SelectString(FString A, FString B, bool bPickA)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bPickA;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SelectString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FRotator SelectRotator(FRotator A, FRotator B, bool bPickA)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bPickA;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SelectRotator, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static UObject SelectObject(UObject A, UObject B, bool bSelectA)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSelectA;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SelectObject, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public static int SelectInt(int A, int B, bool bPickA)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(int*)(__InBuffer) = A;

				*(int*)(__InBuffer + 4) = B;

				*(bool*)(__InBuffer + 8) = bPickA;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SelectInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static double SelectFloat(double A, double B, bool bPickA)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = B;

				*(bool*)(__InBuffer + 16) = bPickA;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SelectFloat, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FLinearColor SelectColor(FLinearColor A, FLinearColor B, bool bPickA)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bPickA;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SelectColor, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static UClass SelectClass(UClass A, UClass B, bool bSelectA)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSelectA;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SelectClass, __InBuffer, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		public static void SeedRandomStream(ref FRandomStream Stream)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Stream?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SeedRandomStream, __InBuffer, __OutBuffer);

				Stream = *(FRandomStream*)(__OutBuffer);

			}
		}

		public static double SafeDivide(double A, double B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SafeDivide, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static long Round64(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Round64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static int Round(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Round, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static FRotator RotatorFromAxisAndAngle(FVector Axis, float Angle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Axis?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Angle;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RotatorFromAxisAndAngle, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static FVector RotateAngleAxis(FVector InVect, float AngleDeg, FVector Axis)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InVect?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = AngleDeg;

				*(nint*)(__InBuffer + 12) = Axis?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RotateAngleAxis, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FRotator RLerp(FRotator A, FRotator B, float Alpha, bool bShortestPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Alpha;

				*(bool*)(__InBuffer + 20) = bShortestPath;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RLerp, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <param name="Current">
		/// Actual rotation
		/// </param>
		/// <param name="Target">
		/// Target rotation
		/// </param>
		/// <param name="DeltaTime">
		/// Time since last tick
		/// </param>
		/// <param name="InterpSpeed">
		/// Interpolation speed
		/// </param>
		/// <returns>
		/// New interpolated position
		/// </returns>
		public static FRotator RInterpTo_Constant(FRotator Current, FRotator Target, float DeltaTime, float InterpSpeed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Current?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Target?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = DeltaTime;

				*(float*)(__InBuffer + 20) = InterpSpeed;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RInterpTo_Constant, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <param name="Current">
		/// Actual rotation
		/// </param>
		/// <param name="Target">
		/// Target rotation
		/// </param>
		/// <param name="DeltaTime">
		/// Time since last tick
		/// </param>
		/// <param name="InterpSpeed">
		/// Interpolation speed, if the speed given is 0, then jump to the target.
		/// </param>
		/// <returns>
		/// New interpolated position
		/// </returns>
		public static FRotator RInterpTo(FRotator Current, FRotator Target, float DeltaTime, float InterpSpeed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Current?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Target?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = DeltaTime;

				*(float*)(__InBuffer + 20) = InterpSpeed;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RInterpTo, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static void RGBToHSV_Vector(FLinearColor RGB, ref FLinearColor HSV)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = RGB?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = HSV?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __RGBToHSV_Vector, __InBuffer, __OutBuffer);

				HSV = *(FLinearColor*)(__OutBuffer);

			}
		}

		public static void RGBToHSV(FLinearColor InColor, ref float H, ref float S, ref float V, ref float A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = H;

				*(float*)(__InBuffer + 12) = S;

				*(float*)(__InBuffer + 16) = V;

				*(float*)(__InBuffer + 20) = A;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __RGBToHSV, __InBuffer, __OutBuffer);

				H = *(float*)(__OutBuffer);

				S = *(float*)(__OutBuffer + 4);

				V = *(float*)(__OutBuffer + 8);

				A = *(float*)(__OutBuffer + 12);

			}
		}

		public static FLinearColor RGBLinearToHSV(FLinearColor RGB)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = RGB?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RGBLinearToHSV, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static void ResetVectorSpringState(ref FVectorSpringState SpringState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SpringState?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ResetVectorSpringState, __InBuffer, __OutBuffer);

				SpringState = *(FVectorSpringState*)(__OutBuffer);

			}
		}

		public static void ResetRandomStream(FRandomStream Stream)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Stream?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ResetRandomStream, __InBuffer);
			}
		}

		public static void ResetQuaternionSpringState(ref FQuaternionSpringState SpringState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SpringState?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ResetQuaternionSpringState, __InBuffer, __OutBuffer);

				SpringState = *(FQuaternionSpringState*)(__OutBuffer);

			}
		}

		public static void ResetFloatSpringState(ref FFloatSpringState SpringState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SpringState?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ResetFloatSpringState, __InBuffer, __OutBuffer);

				SpringState = *(FFloatSpringState*)(__OutBuffer);

			}
		}

		public static FRotator REase(FRotator A, FRotator B, float Alpha, bool bShortestPath, EEasingFunc EasingFunc, float BlendExp = 2.000000f, int Steps = 2)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[30];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Alpha;

				*(bool*)(__InBuffer + 20) = bShortestPath;

				*(byte*)(__InBuffer + 21) = (byte)EasingFunc;

				*(float*)(__InBuffer + 22) = BlendExp;

				*(int*)(__InBuffer + 26) = Steps;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __REase, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <param name="MaxYawInRadians">
		/// The yaw angle of the cone (from ConeDir to horizontal edge), in radians.
		/// </param>
		/// <param name="MaxPitchInRadians">
		/// The pitch angle of the cone (from ConeDir to vertical edge), in radians.
		/// </param>
		/// <param name="Stream">
		/// The random stream from which to obtain the vector.
		/// </param>
		public static FVector RandomUnitVectorInEllipticalConeInRadiansFromStream(FRandomStream Stream, FVector ConeDir, float MaxYawInRadians, float MaxPitchInRadians)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Stream?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ConeDir?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = MaxYawInRadians;

				*(float*)(__InBuffer + 20) = MaxPitchInRadians;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomUnitVectorInEllipticalConeInRadiansFromStream, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="MaxYawInRadians">
		/// The yaw angle of the cone (from ConeDir to horizontal edge), in radians.
		/// </param>
		/// <param name="MaxPitchInRadians">
		/// The pitch angle of the cone (from ConeDir to vertical edge), in radians.	
		/// </param>
		public static FVector RandomUnitVectorInEllipticalConeInRadians(FVector ConeDir, float MaxYawInRadians, float MaxPitchInRadians)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ConeDir?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = MaxYawInRadians;

				*(float*)(__InBuffer + 12) = MaxPitchInRadians;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomUnitVectorInEllipticalConeInRadians, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="MaxYawInDegrees">
		/// The yaw angle of the cone (from ConeDir to horizontal edge), in degrees.
		/// </param>
		/// <param name="MaxPitchInDegrees">
		/// The pitch angle of the cone (from ConeDir to vertical edge), in degrees.
		/// </param>
		/// <param name="Stream">
		/// The random stream from which to obtain the vector.
		/// </param>
		public static FVector RandomUnitVectorInEllipticalConeInDegreesFromStream(FRandomStream Stream, FVector ConeDir, float MaxYawInDegrees, float MaxPitchInDegrees)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Stream?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ConeDir?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = MaxYawInDegrees;

				*(float*)(__InBuffer + 20) = MaxPitchInDegrees;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomUnitVectorInEllipticalConeInDegreesFromStream, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="MaxYawInDegrees">
		/// The yaw angle of the cone (from ConeDir to horizontal edge), in degrees.
		/// </param>
		/// <param name="MaxPitchInDegrees">
		/// The pitch angle of the cone (from ConeDir to vertical edge), in degrees.	
		/// </param>
		public static FVector RandomUnitVectorInEllipticalConeInDegrees(FVector ConeDir, float MaxYawInDegrees, float MaxPitchInDegrees)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ConeDir?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = MaxYawInDegrees;

				*(float*)(__InBuffer + 12) = MaxPitchInDegrees;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomUnitVectorInEllipticalConeInDegrees, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="ConeDir">
		/// The base "center" direction of the cone.
		/// </param>
		/// <param name="ConeHalfAngleInRadians">
		/// The half-angle of the cone (from ConeDir to edge), in radians.
		/// </param>
		/// <param name="Stream">
		/// The random stream from which to obtain the vector.
		/// </param>
		public static FVector RandomUnitVectorInConeInRadiansFromStream(FRandomStream Stream, FVector ConeDir, float ConeHalfAngleInRadians)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Stream?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ConeDir?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = ConeHalfAngleInRadians;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomUnitVectorInConeInRadiansFromStream, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="ConeDir">
		/// The base "center" direction of the cone.
		/// </param>
		/// <param name="ConeHalfAngleInRadians">
		/// The half-angle of the cone (from ConeDir to edge), in radians.
		/// </param>
		public static FVector RandomUnitVectorInConeInRadians(FVector ConeDir, float ConeHalfAngleInRadians)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ConeDir?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = ConeHalfAngleInRadians;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomUnitVectorInConeInRadians, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="ConeDir">
		/// The base "center" direction of the cone.
		/// </param>
		/// <param name="ConeHalfAngleInDegrees">
		/// The half-angle of the cone (from ConeDir to edge), in degrees.
		/// </param>
		/// <param name="Stream">
		/// The random stream from which to obtain the vector.
		/// </param>
		public static FVector RandomUnitVectorInConeInDegreesFromStream(FRandomStream Stream, FVector ConeDir, float ConeHalfAngleInDegrees)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Stream?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ConeDir?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = ConeHalfAngleInDegrees;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomUnitVectorInConeInDegreesFromStream, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="ConeDir">
		/// The base "center" direction of the cone.
		/// </param>
		/// <param name="ConeHalfAngleInDegrees">
		/// The half-angle of the cone (from ConeDir to edge), in degrees.
		/// </param>
		public static FVector RandomUnitVectorInConeInDegrees(FVector ConeDir, float ConeHalfAngleInDegrees)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ConeDir?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = ConeHalfAngleInDegrees;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomUnitVectorInConeInDegrees, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector RandomUnitVectorFromStream(FRandomStream Stream)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Stream?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomUnitVectorFromStream, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector RandomUnitVector()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __RandomUnitVector, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FRotator RandomRotatorFromStream(FRandomStream Stream, bool bRoll)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Stream?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bRoll;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomRotatorFromStream, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static FRotator RandomRotator(bool bRoll = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bRoll;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomRotator, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static FVector RandomPointInBoundingBoxFromStream_Box(FRandomStream Stream, FBox Box)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Stream?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Box?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomPointInBoundingBoxFromStream_Box, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector RandomPointInBoundingBoxFromStream(FRandomStream Stream, FVector Center, FVector HalfSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Stream?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Center?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = HalfSize?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomPointInBoundingBoxFromStream, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector RandomPointInBoundingBox_Box(FBox Box)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Box?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomPointInBoundingBox_Box, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector RandomPointInBoundingBox(FVector Center, FVector HalfSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Center?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = HalfSize?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomPointInBoundingBox, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static int RandomIntegerInRangeFromStream(FRandomStream Stream, int Min, int Max)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Stream?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Min;

				*(int*)(__InBuffer + 12) = Max;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomIntegerInRangeFromStream, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int RandomIntegerInRange(int Min, int Max)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = Min;

				*(int*)(__InBuffer + 4) = Max;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomIntegerInRange, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int RandomIntegerFromStream(FRandomStream Stream, int Max)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Stream?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Max;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomIntegerFromStream, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static long RandomInteger64InRange(long Min, long Max)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(long*)(__InBuffer) = Min;

				*(long*)(__InBuffer + 8) = Max;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomInteger64InRange, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static long RandomInteger64(long Max)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(long*)(__InBuffer) = Max;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomInteger64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static int RandomInteger(int Max)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Max;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomInteger, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static float RandomFloatInRangeFromStream(FRandomStream Stream, float Min, float Max)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Stream?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Min;

				*(float*)(__InBuffer + 12) = Max;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomFloatInRangeFromStream, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static double RandomFloatInRange(double Min, double Max)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = Min;

				*(double*)(__InBuffer + 8) = Max;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomFloatInRange, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static float RandomFloatFromStream(FRandomStream Stream)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Stream?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomFloatFromStream, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static double RandomFloat()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __RandomFloat, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static bool RandomBoolWithWeightFromStream(FRandomStream RandomStream, float Weight)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = RandomStream?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Weight;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomBoolWithWeightFromStream, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool RandomBoolWithWeight(float Weight)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Weight;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomBoolWithWeight, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool RandomBoolFromStream(FRandomStream Stream)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Stream?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RandomBoolFromStream, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool RandomBool()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __RandomBool, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static double RadiansToDegrees(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RadiansToDegrees, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <param name="Current">
		/// Current value
		/// </param>
		/// <param name="Target">
		/// Target value
		/// </param>
		/// <param name="SpringState">
		/// Data related to spring model (velocity, error, etc..) - Create a unique variable per spring
		/// </param>
		/// <param name="Stiffness">
		/// How stiff the spring model is (more stiffness means more oscillation around the target value)
		/// </param>
		/// <param name="CriticalDampingFactor">
		/// How much damping to apply to the spring (0 means no damping, 1 means critically damped which means no oscillation)
		/// </param>
		/// <param name="DeltaTime">
		/// Time difference since the last update
		/// </param>
		/// <param name="Mass">
		/// Multiplier that acts like mass on a spring
		/// </param>
		/// <param name="TargetVelocityAmount">
		/// If 1 then the target velocity will be calculated and used, which results following the target more closely/without lag. Values down to zero (recommended when using this to smooth data) will progressively disable this effect.
		/// </param>
		/// <param name="bInitializeFromTarget">
		/// If set then the current value will be set from the target on the first update
		/// </param>
		public static FQuat QuaternionSpringInterp(FQuat Current, FQuat Target, ref FQuaternionSpringState SpringState, float Stiffness, float CriticalDampingFactor, float DeltaTime, float Mass, float TargetVelocityAmount, bool bInitializeFromTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[45];

				*(nint*)(__InBuffer) = Current?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Target?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SpringState?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Stiffness;

				*(float*)(__InBuffer + 28) = CriticalDampingFactor;

				*(float*)(__InBuffer + 32) = DeltaTime;

				*(float*)(__InBuffer + 36) = Mass;

				*(float*)(__InBuffer + 40) = TargetVelocityAmount;

				*(bool*)(__InBuffer + 44) = bInitializeFromTarget;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __QuaternionSpringInterp, __InBuffer, __OutBuffer, __ReturnBuffer);

				SpringState = *(FQuaternionSpringState*)(__OutBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		public static FVector Quat_VectorUp(FQuat Q)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_VectorUp, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Quat_VectorRight(FQuat Q)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_VectorRight, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Quat_VectorForward(FQuat Q)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_VectorForward, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="V">
		/// the vector to be rotated
		/// </param>
		/// <returns>
		/// vector after rotation by the inverse of this quaternion.
		/// </returns>
		public static FVector Quat_UnrotateVector(FQuat Q, FVector V)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = V?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_UnrotateVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="A">
		/// The starting quat we interp from
		/// </param>
		/// <param name="B">
		/// The target quat we interp to
		/// </param>
		/// <param name="Alpha">
		/// The interpolation amount, usually 0 to 1.
		/// </param>
		/// <returns>
		/// Quat after spherical interpolation
		/// </returns>
		public static FQuat Quat_Slerp(FQuat A, FQuat B, double Alpha)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 16) = Alpha;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_Slerp, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The squared length of the quaternion.
		/// </returns>
		public static float Quat_SizeSquared(FQuat Q)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_SizeSquared, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The length of the quaternion.
		/// </returns>
		public static float Quat_Size(FQuat Q)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_Size, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Q">
		/// Quaternion to update
		/// </param>
		/// <param name="Euler">
		/// the Euler angles
		/// </param>
		public static void Quat_SetFromEuler(ref FQuat Q, FVector Euler)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Euler?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Quat_SetFromEuler, __InBuffer, __OutBuffer);

				Q = *(FQuat*)(__OutBuffer);

			}
		}

		public static void Quat_SetComponents(ref FQuat Q, float X, float Y, float Z, float W)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = X;

				*(float*)(__InBuffer + 12) = Y;

				*(float*)(__InBuffer + 16) = Z;

				*(float*)(__InBuffer + 20) = W;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Quat_SetComponents, __InBuffer, __OutBuffer);

				Q = *(FQuat*)(__OutBuffer);

			}
		}

		public static FRotator Quat_Rotator(FQuat Q)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_Rotator, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <param name="V">
		/// the vector to be rotated
		/// </param>
		/// <returns>
		/// vector after rotation
		/// </returns>
		public static FVector Quat_RotateVector(FQuat Q, FVector V)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = V?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_RotateVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="Tolerance">
		/// Minimum squared length of quaternion for normalization.
		/// </param>
		public static FQuat Quat_Normalized(FQuat Q, float Tolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Tolerance;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_Normalized, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		/// <param name="Tolerance">
		/// Minimum squared length of quaternion for normalization.
		/// </param>
		public static void Quat_Normalize(ref FQuat Q, float Tolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Tolerance;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Quat_Normalize, __InBuffer, __OutBuffer);

				Q = *(FQuat*)(__OutBuffer);

			}
		}

		/// <param name="Euler">
		/// the Euler angles
		/// </param>
		/// <returns>
		/// constructed Quat
		/// </returns>
		public static FQuat Quat_MakeFromEuler(FVector Euler)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Euler?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_MakeFromEuler, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		public static FQuat Quat_Log(FQuat Q)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_Log, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		public static bool Quat_IsNormalized(FQuat Q)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_IsNormalized, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Quat_IsNonFinite(FQuat Q)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_IsNonFinite, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Tolerance">
		/// Error tolerance for comparison with Identity Quaternion.
		/// </param>
		/// <returns>
		/// true if Quaternion is a normalized Identity Quaternion.
		/// </returns>
		public static bool Quat_IsIdentity(FQuat Q, float Tolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Tolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_IsIdentity, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Quat_IsFinite(FQuat Q)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_IsFinite, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FQuat Quat_Inversed(FQuat Q)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_Inversed, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		public static FQuat Quat_Identity()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Quat_Identity, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		public static FVector Quat_GetRotationAxis(FQuat Q)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_GetRotationAxis, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Quat_GetAxisZ(FQuat Q)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_GetAxisZ, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Quat_GetAxisY(FQuat Q)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_GetAxisY, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Quat_GetAxisX(FQuat Q)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_GetAxisX, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static float Quat_GetAngle(FQuat Q)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_GetAngle, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Start">
		/// Vector the rotation starts from
		/// </param>
		/// <param name="End">
		/// Vector the rotation ends at
		/// </param>
		/// <returns>
		/// Quat that will rotate from Start to End
		/// </returns>
		public static FQuat Quat_FindBetweenVectors(FVector Start, FVector End)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = End?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_FindBetweenVectors, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		/// <param name="Start">
		/// Normalized vector the rotation starts from
		/// </param>
		/// <param name="End">
		/// Normalized vector the rotation ends at
		/// </param>
		/// <returns>
		/// Quat that will rotate from Start to End
		/// </returns>
		public static FQuat Quat_FindBetweenNormals(FVector StartNormal, FVector EndNormal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = StartNormal?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = EndNormal?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_FindBetweenNormals, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		public static FQuat Quat_Exp(FQuat Q)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_Exp, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		public static FVector Quat_Euler(FQuat Q)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Q?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_Euler, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static void Quat_EnforceShortestArcWith(ref FQuat A, FQuat B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Quat_EnforceShortestArcWith, __InBuffer, __OutBuffer);

				A = *(FQuat*)(__OutBuffer);

			}
		}

		/// <param name="B">
		/// Quaternion to find angle distance to
		/// </param>
		/// <returns>
		/// angular distance in radians
		/// </returns>
		public static float Quat_AngularDistance(FQuat A, FQuat B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Quat_AngularDistance, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="V">
		/// Vector to project.
		/// </param>
		/// <param name="Target">
		/// Vector on which we are projecting.
		/// </param>
		/// <returns>
		/// V projected on to Target.
		/// </returns>
		public static FVector ProjectVectorOnToVector(FVector V, FVector Target)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = V?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Target?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ProjectVectorOnToVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="V">
		/// Vector to project onto the plane.
		/// </param>
		/// <param name="PlaneNormal">
		/// Normal of the plane.
		/// </param>
		/// <returns>
		/// Vector projected onto the plane.
		/// </returns>
		public static FVector ProjectVectorOnToPlane(FVector V, FVector PlaneNormal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = V?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PlaneNormal?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ProjectVectorOnToPlane, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="Point">
		/// Point to project onto the plane.
		/// </param>
		/// <param name="PlaneBase">
		/// A point on the plane.
		/// </param>
		/// <param name="PlaneNormal">
		/// Normal of the plane.
		/// </param>
		/// <returns>
		/// Point projected onto the plane.
		/// </returns>
		public static FVector ProjectPointOnToPlane(FVector Point, FVector PlaneBase, FVector PlaneNormal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Point?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PlaneBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PlaneNormal?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ProjectPointOnToPlane, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="Points">
		/// - The set of points to determine coplanarity for.
		/// </param>
		/// <param name="Tolerance">
		/// - Larger numbers means more variance is allowed.
		/// </param>
		/// <returns>
		/// Whether the points are relatively coplanar, based on the tolerance
		/// </returns>
		public static bool PointsAreCoplanar(TArray<FVector> Points, float Tolerance = 0.100000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Points?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Tolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __PointsAreCoplanar, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Value">
		/// The input value that Perlin noise will be generated from.  This is usually a steadily incrementing time value.
		/// </param>
		/// <returns>
		/// Perlin noise in the range of -1.0 to 1.0
		/// </returns>
		public static float PerlinNoise1D(float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Value;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __PerlinNoise1D, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static int Percent_IntInt(int A, int B = 1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = A;

				*(int*)(__InBuffer + 4) = B;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Percent_IntInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static long Percent_Int64Int64(long A, long B = 1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(long*)(__InBuffer) = A;

				*(long*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Percent_Int64Int64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static double Percent_FloatFloat(double A, double B = 1.000000)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Percent_FloatFloat, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static byte Percent_ByteByte(byte A, byte B = 1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = A;

				*(byte*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Percent_ByteByte, __InBuffer, __ReturnBuffer);

				return *(byte*)__ReturnBuffer;
			}
		}

		public static int Or_IntInt(int A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = A;

				*(int*)(__InBuffer + 4) = B;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Or_IntInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static long Or_Int64Int64(long A, long B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(long*)(__InBuffer) = A;

				*(long*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Or_Int64Int64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static FDateTime Now()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Now, __ReturnBuffer);

				return *(FDateTime*)__ReturnBuffer;
			}
		}

		public static bool NotEqualExactly_VectorVector(FVector A, FVector B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqualExactly_VectorVector, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqualExactly_Vector4Vector4(FVector4 A, FVector4 B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqualExactly_Vector4Vector4, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqualExactly_Vector2DVector2D(FVector2D A, FVector2D B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqualExactly_Vector2DVector2D, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_VectorVector(FVector A, FVector B, float ErrorTolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = ErrorTolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_VectorVector, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_Vector4Vector4(FVector4 A, FVector4 B, float ErrorTolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = ErrorTolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_Vector4Vector4, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_Vector2DVector2D(FVector2D A, FVector2D B, float ErrorTolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = ErrorTolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_Vector2DVector2D, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_TimespanTimespan(FTimespan A, FTimespan B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_TimespanTimespan, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_RotatorRotator(FRotator A, FRotator B, float ErrorTolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = ErrorTolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_RotatorRotator, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_QuatQuat(FQuat A, FQuat B, float ErrorTolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = ErrorTolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_QuatQuat, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_ObjectObject(UObject A, UObject B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_ObjectObject, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_NameName(FName A, FName B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_NameName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Other">
		/// The other Matrix.
		/// </param>
		/// <returns>
		/// true if two Matrix are not equal, within specified tolerance, otherwise false.
		/// </returns>
		public static bool NotEqual_MatrixMatrix(FMatrix A, FMatrix B, float Tolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Tolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_MatrixMatrix, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_LinearColorLinearColor(FLinearColor A, FLinearColor B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_LinearColorLinearColor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_IntPointIntPoint(FIntPoint A, FIntPoint B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_IntPointIntPoint, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_IntInt(int A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = A;

				*(int*)(__InBuffer + 4) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_IntInt, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_Int64Int64(long A, long B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(long*)(__InBuffer) = A;

				*(long*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_Int64Int64, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_DoubleDouble(double A, double B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_DoubleDouble, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_DateTimeDateTime, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_ClassClass(UClass A, UClass B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_ClassClass, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_ByteByte(byte A, byte B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = A;

				*(byte*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_ByteByte, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_BoolBool(bool A, bool B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = A;

				*(bool*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_BoolBool, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Not_PreBool(bool A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Not_PreBool, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static long Not_Int64(long A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(long*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Not_Int64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static int Not_Int(int A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Not_Int, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Tolerance">
		/// Minimum squared length of vector for normalization.
		/// </param>
		/// <returns>
		/// A normalized copy of the vector if safe, (0,0) otherwise.
		/// </returns>
		public static FVector2D NormalSafe2D(FVector2D A, float Tolerance = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Tolerance;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __NormalSafe2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static double NormalizeToRange(double Value, double RangeMin, double RangeMax)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(double*)(__InBuffer) = Value;

				*(double*)(__InBuffer + 8) = RangeMin;

				*(double*)(__InBuffer + 16) = RangeMax;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NormalizeToRange, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FRotator NormalizedDeltaRotator(FRotator A, FRotator B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __NormalizedDeltaRotator, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <param name="Angle">
		/// The Angle to clamp.
		/// </param>
		/// <returns>
		/// The clamped angle.
		/// </returns>
		public static float NormalizeAxis(float Angle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Angle;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NormalizeAxis, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Tolerance">
		/// Minimum squared length of vector for normalization.
		/// </param>
		/// <see>
		/// NormalSafe2D()
		/// </see>
		public static void Normalize2D(ref FVector2D A, float Tolerance = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Tolerance;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Normalize2D, __InBuffer, __OutBuffer);

				A = *(FVector2D*)(__OutBuffer);

			}
		}

		public static FVector2D Normal2D(FVector2D A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Normal2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		/// <param name="Tolerance">
		/// Minimum squared vector length.
		/// </param>
		/// <returns>
		/// A normalized copy if safe, (0,0,0) otherwise.
		/// </returns>
		public static FVector Normal(FVector A, float Tolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Tolerance;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Normal, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector NegateVector(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __NegateVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FRotator NegateRotator(FRotator A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __NegateRotator, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static FVector2D Negated2D(FVector2D A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Negated2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		/// <param name="LocationTolerance">
		/// How close position of transforms need to be to be considered equal
		/// </param>
		/// <param name="RotationTolerance">
		/// How close rotations of transforms need to be to be considered equal
		/// </param>
		/// <param name="Scale3DTolerance">
		/// How close scale of transforms need to be to be considered equal
		/// </param>
		public static bool NearlyEqual_TransformTransform(FTransform A, FTransform B, float LocationTolerance = 0.000100f, float RotationTolerance = 0.000100f, float Scale3DTolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = LocationTolerance;

				*(float*)(__InBuffer + 20) = RotationTolerance;

				*(float*)(__InBuffer + 24) = Scale3DTolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NearlyEqual_TransformTransform, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NearlyEqual_FloatFloat(double A, double B, double ErrorTolerance = 0.000001)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = B;

				*(double*)(__InBuffer + 16) = ErrorTolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NearlyEqual_FloatFloat, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static double MultiplyMultiply_FloatFloat(double Base, double Exp)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = Base;

				*(double*)(__InBuffer + 8) = Exp;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MultiplyMultiply_FloatFloat, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double MultiplyByPi(double Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = Value;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MultiplyByPi, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FVector Multiply_VectorVector(FVector A, FVector B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_VectorVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Multiply_VectorInt(FVector A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_VectorInt, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Multiply_VectorFloat(FVector A, double B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_VectorFloat, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector4 Multiply_Vector4Vector4(FVector4 A, FVector4 B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_Vector4Vector4, __InBuffer, __ReturnBuffer);

				return *(FVector4*)__ReturnBuffer;
			}
		}

		public static FVector2D Multiply_Vector2DVector2D(FVector2D A, FVector2D B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_Vector2DVector2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FVector2D Multiply_Vector2DFloat(FVector2D A, double B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_Vector2DFloat, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FTimespan Multiply_TimespanFloat(FTimespan A, float Scalar)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Scalar;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_TimespanFloat, __InBuffer, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		public static FRotator Multiply_RotatorInt(FRotator A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_RotatorInt, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static FRotator Multiply_RotatorFloat(FRotator A, float B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_RotatorFloat, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <param name="B">
		/// The Quaternion to multiply by.
		/// </param>
		/// <returns>
		/// The result of multiplication (A * B).
		/// </returns>
		public static FQuat Multiply_QuatQuat(FQuat A, FQuat B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_QuatQuat, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		/// <param name="Other">
		/// The matrix to multiply this by.
		/// </param>
		/// <returns>
		/// The result of multiplication.
		/// </returns>
		public static FMatrix Multiply_MatrixMatrix(FMatrix A, FMatrix B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_MatrixMatrix, __InBuffer, __ReturnBuffer);

				return *(FMatrix*)__ReturnBuffer;
			}
		}

		public static FMatrix Multiply_MatrixFloat(FMatrix A, double B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_MatrixFloat, __InBuffer, __ReturnBuffer);

				return *(FMatrix*)__ReturnBuffer;
			}
		}

		public static FLinearColor Multiply_LinearColorLinearColor(FLinearColor A, FLinearColor B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_LinearColorLinearColor, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static FLinearColor Multiply_LinearColorFloat(FLinearColor A, float B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_LinearColorFloat, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static FIntPoint Multiply_IntPointIntPoint(FIntPoint A, FIntPoint B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_IntPointIntPoint, __InBuffer, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public static FIntPoint Multiply_IntPointInt(FIntPoint A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_IntPointInt, __InBuffer, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public static int Multiply_IntInt(int A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = A;

				*(int*)(__InBuffer + 4) = B;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_IntInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static double Multiply_IntFloat(int A, double B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = A;

				*(double*)(__InBuffer + 4) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_IntFloat, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static long Multiply_Int64Int64(long A, long B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(long*)(__InBuffer) = A;

				*(long*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_Int64Int64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static double Multiply_DoubleDouble(double A, double B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_DoubleDouble, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static byte Multiply_ByteByte(byte A, byte B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = A;

				*(byte*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_ByteByte, __InBuffer, __ReturnBuffer);

				return *(byte*)__ReturnBuffer;
			}
		}

		/// <param name="InVect">
		/// Direction vector the ray is coming from.
		/// </param>
		/// <param name="InNormal">
		/// A normal of the surface the ray should be reflected on.
		/// </param>
		/// <returns>
		/// Reflected vector.
		/// </returns>
		public static FVector MirrorVectorByNormal(FVector InVect, FVector InNormal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVect?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNormal?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MirrorVectorByNormal, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static void MinOfIntArray(TArray<int> IntArray, ref int IndexOfMinValue, ref int MinValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = IntArray?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = IndexOfMinValue;

				*(int*)(__InBuffer + 12) = MinValue;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __MinOfIntArray, __InBuffer, __OutBuffer);

				IndexOfMinValue = *(int*)(__OutBuffer);

				MinValue = *(int*)(__OutBuffer + 4);

			}
		}

		public static void MinOfFloatArray(TArray<float> FloatArray, ref int IndexOfMinValue, ref float MinValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = FloatArray?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = IndexOfMinValue;

				*(float*)(__InBuffer + 12) = MinValue;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __MinOfFloatArray, __InBuffer, __OutBuffer);

				IndexOfMinValue = *(int*)(__OutBuffer);

				MinValue = *(float*)(__OutBuffer + 4);

			}
		}

		public static void MinOfByteArray(TArray<byte> ByteArray, ref int IndexOfMinValue, ref byte MinValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = ByteArray?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = IndexOfMinValue;

				*(byte*)(__InBuffer + 12) = MinValue;

				var __OutBuffer = stackalloc byte[5];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __MinOfByteArray, __InBuffer, __OutBuffer);

				IndexOfMinValue = *(int*)(__OutBuffer);

				MinValue = *(byte*)(__OutBuffer + 4);

			}
		}

		public static long MinInt64(long A, long B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(long*)(__InBuffer) = A;

				*(long*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MinInt64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static void MinimumAreaRectangle(UObject WorldContextObject, TArray<FVector> InVerts, FVector SampleSurfaceNormal, ref FVector OutRectCenter, ref FRotator OutRectRotation, ref float OutSideLengthX, ref float OutSideLengthY, bool bDebugDraw)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[49];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InVerts?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SampleSurfaceNormal?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutRectCenter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = OutRectRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 40) = OutSideLengthX;

				*(float*)(__InBuffer + 44) = OutSideLengthY;

				*(bool*)(__InBuffer + 48) = bDebugDraw;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __MinimumAreaRectangle, __InBuffer, __OutBuffer);

				OutRectCenter = *(FVector*)(__OutBuffer);

				OutRectRotation = *(FRotator*)(__OutBuffer + 8);

				OutSideLengthX = *(float*)(__OutBuffer + 16);

				OutSideLengthY = *(float*)(__OutBuffer + 20);

			}
		}

		/// <param name="WorldContextObject">
		/// - Pointer to world context; only used when debug draw is enabled
		/// </param>
		/// <param name="InPoints">
		/// - Points to enclose in the rectangle; need to be within the same plane for correct results
		/// </param>
		/// <param name="SampleSurfaceNormal">
		/// - Normal indicating the surface direction for the points
		/// </param>
		/// <param name="OutRectCenter">
		/// - Translation for the output rectangle from the origin
		/// </param>
		/// <param name="OutRectRotation">
		/// - Rotation for the output rectangle from the XY plane
		/// </param>
		/// <param name="OutRectLengthX">
		/// - Length of the output rectangle along the X axis before rotation
		/// </param>
		/// <param name="OutRectLengthY">
		/// - Length of the output rectangle along the Y axis before rotation
		/// </param>
		/// <param name="bDebugDraw">
		/// - Draws the output rectangle for debugging purposes provided the world context is set as well
		/// </param>
		public static void MinAreaRectangle(UObject WorldContextObject, TArray<FVector> InPoints, FVector SampleSurfaceNormal, ref FVector OutRectCenter, ref FRotator OutRectRotation, ref float OutRectLengthX, ref float OutRectLengthY, bool bDebugDraw)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[49];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPoints?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SampleSurfaceNormal?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutRectCenter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = OutRectRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 40) = OutRectLengthX;

				*(float*)(__InBuffer + 44) = OutRectLengthY;

				*(bool*)(__InBuffer + 48) = bDebugDraw;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __MinAreaRectangle, __InBuffer, __OutBuffer);

				OutRectCenter = *(FVector*)(__OutBuffer);

				OutRectRotation = *(FRotator*)(__OutBuffer + 8);

				OutRectLengthX = *(float*)(__OutBuffer + 16);

				OutRectLengthY = *(float*)(__OutBuffer + 20);

			}
		}

		public static int Min(int A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = A;

				*(int*)(__InBuffer + 4) = B;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Min, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static void MedianOfIntArray(TArray<int> IntArray, ref float MedianValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = IntArray?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = MedianValue;

				var __OutBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __MedianOfIntArray, __InBuffer, __OutBuffer);

				MedianValue = *(float*)(__OutBuffer);

			}
		}

		public static void MaxOfIntArray(TArray<int> IntArray, ref int IndexOfMaxValue, ref int MaxValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = IntArray?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = IndexOfMaxValue;

				*(int*)(__InBuffer + 12) = MaxValue;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __MaxOfIntArray, __InBuffer, __OutBuffer);

				IndexOfMaxValue = *(int*)(__OutBuffer);

				MaxValue = *(int*)(__OutBuffer + 4);

			}
		}

		public static void MaxOfFloatArray(TArray<float> FloatArray, ref int IndexOfMaxValue, ref float MaxValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = FloatArray?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = IndexOfMaxValue;

				*(float*)(__InBuffer + 12) = MaxValue;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __MaxOfFloatArray, __InBuffer, __OutBuffer);

				IndexOfMaxValue = *(int*)(__OutBuffer);

				MaxValue = *(float*)(__OutBuffer + 4);

			}
		}

		public static void MaxOfByteArray(TArray<byte> ByteArray, ref int IndexOfMaxValue, ref byte MaxValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = ByteArray?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = IndexOfMaxValue;

				*(byte*)(__InBuffer + 12) = MaxValue;

				var __OutBuffer = stackalloc byte[5];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __MaxOfByteArray, __InBuffer, __OutBuffer);

				IndexOfMaxValue = *(int*)(__OutBuffer);

				MaxValue = *(byte*)(__OutBuffer + 4);

			}
		}

		public static long MaxInt64(long A, long B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(long*)(__InBuffer) = A;

				*(long*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MaxInt64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static int Max(int A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = A;

				*(int*)(__InBuffer + 4) = B;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Max, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static FVector4 Matrix_TransformVector4(FMatrix M, FVector4 V)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = V?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_TransformVector4, __InBuffer, __ReturnBuffer);

				return *(FVector4*)__ReturnBuffer;
			}
		}

		public static FVector4 Matrix_TransformVector(FMatrix M, FVector V)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = V?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_TransformVector, __InBuffer, __ReturnBuffer);

				return *(FVector4*)__ReturnBuffer;
			}
		}

		public static FVector4 Matrix_TransformPosition(FMatrix M, FVector V)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = V?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_TransformPosition, __InBuffer, __ReturnBuffer);

				return *(FVector4*)__ReturnBuffer;
			}
		}

		/// <warning>
		/// rotation part will need to be unit length for this to be right!
		/// </warning>
		public static FQuat Matrix_ToQuat(FMatrix M)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_ToQuat, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		public static void Matrix_SetOrigin(ref FMatrix M, FVector NewOrigin)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewOrigin?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Matrix_SetOrigin, __InBuffer, __OutBuffer);

				M = *(FMatrix*)(__OutBuffer);

			}
		}

		public static void Matrix_SetColumn(ref FMatrix M, EMatrixColumns Column, FVector Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Column;

				*(nint*)(__InBuffer + 9) = Value?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Matrix_SetColumn, __InBuffer, __OutBuffer);

				M = *(FMatrix*)(__OutBuffer);

			}
		}

		/// <param name="i">
		/// index into the axis of the matrix
		/// </param>
		/// <param name="Axis">
		/// vector of the axis
		/// </param>
		public static void Matrix_SetAxis(ref FMatrix M, EAxis Axis, FVector AxisVector)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Axis;

				*(nint*)(__InBuffer + 9) = AxisVector?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Matrix_SetAxis, __InBuffer, __OutBuffer);

				M = *(FMatrix*)(__OutBuffer);

			}
		}

		public static FMatrix Matrix_ScaleTranslation(FMatrix M, FVector Scale3D)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Scale3D?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_ScaleTranslation, __InBuffer, __ReturnBuffer);

				return *(FMatrix*)__ReturnBuffer;
			}
		}

		public static FMatrix Matrix_RemoveTranslation(FMatrix M)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_RemoveTranslation, __InBuffer, __ReturnBuffer);

				return *(FMatrix*)__ReturnBuffer;
			}
		}

		public static void Matrix_RemoveScaling(ref FMatrix M, float Tolerance = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Tolerance;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Matrix_RemoveScaling, __InBuffer, __OutBuffer);

				M = *(FMatrix*)(__OutBuffer);

			}
		}

		public static FMatrix Matrix_Mirror(FMatrix M, EAxis MirrorAxis, EAxis FlipAxis)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)MirrorAxis;

				*(byte*)(__InBuffer + 9) = (byte)FlipAxis;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_Mirror, __InBuffer, __ReturnBuffer);

				return *(FMatrix*)__ReturnBuffer;
			}
		}

		public static FVector Matrix_InverseTransformVector(FMatrix M, FVector V)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = V?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_InverseTransformVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Matrix_InverseTransformPosition(FMatrix M, FVector V)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = V?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_InverseTransformPosition, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FMatrix Matrix_Identity()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Matrix_Identity, __ReturnBuffer);

				return *(FMatrix*)__ReturnBuffer;
			}
		}

		/// <param name="i">
		/// index into the axis of the matrix
		/// </param>
		/// <returns>
		/// vector of the axis
		/// </returns>
		public static FVector Matrix_GetUnitAxis(FMatrix M, EAxis Axis)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Axis;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetUnitAxis, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="X">
		/// axes returned to this param
		/// </param>
		/// <param name="Y">
		/// axes returned to this param
		/// </param>
		/// <param name="Z">
		/// axes returned to this param
		/// </param>
		public static void Matrix_GetUnitAxes(FMatrix M, ref FVector X, ref FVector Y, ref FVector Z)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = X?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Y?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Z?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetUnitAxes, __InBuffer, __OutBuffer);

				X = *(FVector*)(__OutBuffer);

				Y = *(FVector*)(__OutBuffer + 8);

				Z = *(FVector*)(__OutBuffer + 16);

			}
		}

		public static FMatrix Matrix_GetTransposed(FMatrix M)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetTransposed, __InBuffer, __ReturnBuffer);

				return *(FMatrix*)__ReturnBuffer;
			}
		}

		public static FMatrix Matrix_GetTransposeAdjoint(FMatrix M)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetTransposeAdjoint, __InBuffer, __ReturnBuffer);

				return *(FMatrix*)__ReturnBuffer;
			}
		}

		public static FVector Matrix_GetScaleVector(FMatrix M, float Tolerance = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Tolerance;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetScaleVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="i">
		/// index into the axis of the matrix
		/// </param>
		/// </>
		/// return vector of the axis
		/// <//>
		public static FVector Matrix_GetScaledAxis(FMatrix M, EAxis Axis)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Axis;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetScaledAxis, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="X">
		/// axes returned to this param
		/// </param>
		/// <param name="Y">
		/// axes returned to this param
		/// </param>
		/// <param name="Z">
		/// axes returned to this param
		/// </param>
		public static void Matrix_GetScaledAxes(FMatrix M, ref FVector X, ref FVector Y, ref FVector Z)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = X?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Y?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Z?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetScaledAxes, __InBuffer, __OutBuffer);

				X = *(FVector*)(__OutBuffer);

				Y = *(FVector*)(__OutBuffer + 8);

				Z = *(FVector*)(__OutBuffer + 16);

			}
		}

		/// <returns>
		/// the determinant of rotation 3x3 matrix 
		/// (Assumes Top Left 3x3 Submatrix represents a Rotation)
		/// </returns>
		public static float Matrix_GetRotDeterminant(FMatrix M)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetRotDeterminant, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// rotator representation of this matrix
		/// </returns>
		public static FRotator Matrix_GetRotator(FMatrix M)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetRotator, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// co-ordinate system origin
		/// </returns>
		public static FVector Matrix_GetOrigin(FMatrix InMatrix)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMatrix?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetOrigin, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the maximum magnitude of any row of the matrix.
		/// (Assumes Matrix represents a transform)
		/// </returns>
		public static float Matrix_GetMaximumAxisScale(FMatrix M)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetMaximumAxisScale, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static FMatrix Matrix_GetMatrixWithoutScale(FMatrix M, float Tolerance = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Tolerance;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetMatrixWithoutScale, __InBuffer, __ReturnBuffer);

				return *(FMatrix*)__ReturnBuffer;
			}
		}

		public static FMatrix Matrix_GetInverse(FMatrix M)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetInverse, __InBuffer, __ReturnBuffer);

				return *(FMatrix*)__ReturnBuffer;
			}
		}

		/// <param name="OutPlane">
		/// the top plane of the Frustum of this matrix 
		/// </param>
		public static bool Matrix_GetFrustumTopPlane(FMatrix M, ref FPlane OutPlane)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPlane?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetFrustumTopPlane, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPlane = *(FPlane*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="OutPlane">
		/// the right plane of the Frustum of this matrix 
		/// </param>
		public static bool Matrix_GetFrustumRightPlane(FMatrix M, ref FPlane OutPlane)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPlane?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetFrustumRightPlane, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPlane = *(FPlane*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="OutPlane">
		/// the near plane of the Frustum of this matrix 
		/// </param>
		public static bool Matrix_GetFrustumNearPlane(FMatrix M, ref FPlane OutPlane)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPlane?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetFrustumNearPlane, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPlane = *(FPlane*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="OutPlane">
		/// the left plane of the Frustum of this matrix 
		/// </param>
		public static bool Matrix_GetFrustumLeftPlane(FMatrix M, ref FPlane OutPlane)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPlane?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetFrustumLeftPlane, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPlane = *(FPlane*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="OutPlane">
		/// the far plane of the Frustum of this matrix 
		/// </param>
		public static bool Matrix_GetFrustumFarPlane(FMatrix M, ref FPlane OutPlane)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPlane?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetFrustumFarPlane, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPlane = *(FPlane*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="OutPlane">
		/// the bottom plane of the Frustum of this matrix 
		/// </param>
		public static bool Matrix_GetFrustumBottomPlane(FMatrix M, ref FPlane OutPlane)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPlane?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetFrustumBottomPlane, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPlane = *(FPlane*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// determinant of this matrix.
		/// </returns>
		public static float Matrix_GetDeterminant(FMatrix M)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetDeterminant, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="i">
		/// index into the column of the matrix
		/// </param>
		/// <returns>
		/// vector of the column
		/// </returns>
		public static FVector Matrix_GetColumn(FMatrix M, EMatrixColumns Column)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Column;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_GetColumn, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static bool Matrix_ContainsNaN(FMatrix M)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_ContainsNaN, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FMatrix Matrix_ConcatenateTranslation(FMatrix M, FVector Translation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Translation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_ConcatenateTranslation, __InBuffer, __ReturnBuffer);

				return *(FMatrix*)__ReturnBuffer;
			}
		}

		public static FMatrix Matrix_ApplyScale(FMatrix M, float Scale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = M?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Scale;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Matrix_ApplyScale, __InBuffer, __ReturnBuffer);

				return *(FMatrix*)__ReturnBuffer;
			}
		}

		public static double MapRangeUnclamped(double Value, double InRangeA, double InRangeB, double OutRangeA, double OutRangeB)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(double*)(__InBuffer) = Value;

				*(double*)(__InBuffer + 8) = InRangeA;

				*(double*)(__InBuffer + 16) = InRangeB;

				*(double*)(__InBuffer + 24) = OutRangeA;

				*(double*)(__InBuffer + 32) = OutRangeB;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MapRangeUnclamped, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double MapRangeClamped(double Value, double InRangeA, double InRangeB, double OutRangeA, double OutRangeB)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(double*)(__InBuffer) = Value;

				*(double*)(__InBuffer + 8) = InRangeA;

				*(double*)(__InBuffer + 16) = InRangeB;

				*(double*)(__InBuffer + 24) = OutRangeA;

				*(double*)(__InBuffer + 32) = OutRangeB;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MapRangeClamped, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FVector_NetQuantizeNormal MakeVector_NetQuantizeNormal(double X, double Y, double Z)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(double*)(__InBuffer) = X;

				*(double*)(__InBuffer + 8) = Y;

				*(double*)(__InBuffer + 16) = Z;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeVector_NetQuantizeNormal, __InBuffer, __ReturnBuffer);

				return *(FVector_NetQuantizeNormal*)__ReturnBuffer;
			}
		}

		public static FVector_NetQuantize100 MakeVector_NetQuantize100(double X, double Y, double Z)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(double*)(__InBuffer) = X;

				*(double*)(__InBuffer + 8) = Y;

				*(double*)(__InBuffer + 16) = Z;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeVector_NetQuantize100, __InBuffer, __ReturnBuffer);

				return *(FVector_NetQuantize100*)__ReturnBuffer;
			}
		}

		public static FVector_NetQuantize10 MakeVector_NetQuantize10(double X, double Y, double Z)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(double*)(__InBuffer) = X;

				*(double*)(__InBuffer + 8) = Y;

				*(double*)(__InBuffer + 16) = Z;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeVector_NetQuantize10, __InBuffer, __ReturnBuffer);

				return *(FVector_NetQuantize10*)__ReturnBuffer;
			}
		}

		public static FVector_NetQuantize MakeVector_NetQuantize(double X, double Y, double Z)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(double*)(__InBuffer) = X;

				*(double*)(__InBuffer + 8) = Y;

				*(double*)(__InBuffer + 16) = Z;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeVector_NetQuantize, __InBuffer, __ReturnBuffer);

				return *(FVector_NetQuantize*)__ReturnBuffer;
			}
		}

		public static FVector4 MakeVector4(double X, double Y, double Z, double W)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(double*)(__InBuffer) = X;

				*(double*)(__InBuffer + 8) = Y;

				*(double*)(__InBuffer + 16) = Z;

				*(double*)(__InBuffer + 24) = W;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeVector4, __InBuffer, __ReturnBuffer);

				return *(FVector4*)__ReturnBuffer;
			}
		}

		public static FVector2D MakeVector2D(double X, double Y)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = X;

				*(double*)(__InBuffer + 8) = Y;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeVector2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FVector MakeVector(double X, double Y, double Z)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(double*)(__InBuffer) = X;

				*(double*)(__InBuffer + 8) = Y;

				*(double*)(__InBuffer + 16) = Z;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FTransform MakeTransform(FVector Location, FRotator Rotation, FVector Scale = null)
		{
			unsafe
			{
				Scale ??= new FVector(1.000000, 1.000000, 1.000000);

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Scale?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public static FTimespan MakeTimespan2(int Days, int Hours, int Minutes, int Seconds, int FractionNano)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(int*)(__InBuffer) = Days;

				*(int*)(__InBuffer + 4) = Hours;

				*(int*)(__InBuffer + 8) = Minutes;

				*(int*)(__InBuffer + 12) = Seconds;

				*(int*)(__InBuffer + 16) = FractionNano;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeTimespan2, __InBuffer, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		public static FTimespan MakeTimespan(int Days, int Hours, int Minutes, int Seconds, int Milliseconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(int*)(__InBuffer) = Days;

				*(int*)(__InBuffer + 4) = Hours;

				*(int*)(__InBuffer + 8) = Minutes;

				*(int*)(__InBuffer + 12) = Seconds;

				*(int*)(__InBuffer + 16) = Milliseconds;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeTimespan, __InBuffer, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		public static FRotator MakeRotFromZY(FVector Z, FVector Y)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Z?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Y?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeRotFromZY, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static FRotator MakeRotFromZX(FVector Z, FVector X)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Z?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = X?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeRotFromZX, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static FRotator MakeRotFromZ(FVector Z)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Z?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeRotFromZ, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static FRotator MakeRotFromYZ(FVector Y, FVector Z)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Y?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Z?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeRotFromYZ, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static FRotator MakeRotFromYX(FVector Y, FVector X)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Y?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = X?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeRotFromYX, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static FRotator MakeRotFromY(FVector Y)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Y?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeRotFromY, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static FRotator MakeRotFromXZ(FVector X, FVector Z)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = X?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Z?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeRotFromXZ, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static FRotator MakeRotFromXY(FVector X, FVector Y)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = X?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Y?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeRotFromXY, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static FRotator MakeRotFromX(FVector X)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = X?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeRotFromX, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static FRotator MakeRotator(float Roll, float Pitch, float Yaw)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = Roll;

				*(float*)(__InBuffer + 4) = Pitch;

				*(float*)(__InBuffer + 8) = Yaw;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeRotator, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static FRotator MakeRotationFromAxes(FVector Forward, FVector Right, FVector Up)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Forward?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Right?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Up?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeRotationFromAxes, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <param name="A">
		/// The object's transform
		/// </param>
		/// <param name="RelativeTo">
		/// The transform the result is relative to (in the same space as A)
		/// </param>
		/// <returns>
		/// The new relative transform
		/// </returns>
		public static FTransform MakeRelativeTransform(FTransform A, FTransform RelativeTo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RelativeTo?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeRelativeTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public static FRandomStream MakeRandomStream(int InitialSeed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InitialSeed;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeRandomStream, __InBuffer, __ReturnBuffer);

				return *(FRandomStream*)__ReturnBuffer;
			}
		}

		public static FQuat MakeQuat(float X, float Y, float Z, float W)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(float*)(__InBuffer) = X;

				*(float*)(__InBuffer + 4) = Y;

				*(float*)(__InBuffer + 8) = Z;

				*(float*)(__InBuffer + 12) = W;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeQuat, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		public static FQualifiedFrameTime MakeQualifiedFrameTime(FFrameNumber Frame, FFrameRate FrameRate, float SubFrame = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FrameRate?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = SubFrame;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeQualifiedFrameTime, __InBuffer, __ReturnBuffer);

				return *(FQualifiedFrameTime*)__ReturnBuffer;
			}
		}

		/// <param name="InCurrentTime">
		/// Current absolute time
		/// </param>
		/// <param name="InPulsesPerSecond">
		/// How many full pulses per second?
		/// </param>
		/// <param name="InPhase">
		/// Optional phase amount, between 0.0 and 1.0 (to synchronize pulses)
		/// </param>
		/// <returns>
		/// Pulsating value (0.0-1.0)
		/// </returns>
		public static float MakePulsatingValue(float InCurrentTime, float InPulsesPerSecond = 1.000000f, float InPhase = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = InCurrentTime;

				*(float*)(__InBuffer + 4) = InPulsesPerSecond;

				*(float*)(__InBuffer + 8) = InPhase;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MakePulsatingValue, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Point">
		/// A point on the plane
		/// </param>
		/// <param name="Normal">
		/// The Normal of the plane at Point
		/// </param>
		/// <returns>
		/// Plane instance
		/// </returns>
		public static FPlane MakePlaneFromPointAndNormal(FVector Point, FVector Normal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Point?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Normal?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakePlaneFromPointAndNormal, __InBuffer, __ReturnBuffer);

				return *(FPlane*)__ReturnBuffer;
			}
		}

		public static FFrameRate MakeFrameRate(int Numerator, int Denominator = 1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = Numerator;

				*(int*)(__InBuffer + 4) = Denominator;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeFrameRate, __InBuffer, __ReturnBuffer);

				return *(FFrameRate*)__ReturnBuffer;
			}
		}

		public static FDateTime MakeDateTime(int Year, int Month, int Day, int Hour = 0, int Minute = 0, int Second = 0, int Millisecond = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(int*)(__InBuffer) = Year;

				*(int*)(__InBuffer + 4) = Month;

				*(int*)(__InBuffer + 8) = Day;

				*(int*)(__InBuffer + 12) = Hour;

				*(int*)(__InBuffer + 16) = Minute;

				*(int*)(__InBuffer + 20) = Second;

				*(int*)(__InBuffer + 24) = Millisecond;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeDateTime, __InBuffer, __ReturnBuffer);

				return *(FDateTime*)__ReturnBuffer;
			}
		}

		public static FLinearColor MakeColor(float R, float G, float B, float A = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(float*)(__InBuffer) = R;

				*(float*)(__InBuffer + 4) = G;

				*(float*)(__InBuffer + 8) = B;

				*(float*)(__InBuffer + 12) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeColor, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static FBoxSphereBounds MakeBoxSphereBounds(FVector Origin, FVector BoxExtent, float SphereRadius)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoxExtent?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = SphereRadius;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeBoxSphereBounds, __InBuffer, __ReturnBuffer);

				return *(FBoxSphereBounds*)__ReturnBuffer;
			}
		}

		public static FBox2D MakeBox2D(FVector2D Min, FVector2D Max)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Min?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Max?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeBox2D, __InBuffer, __ReturnBuffer);

				return *(FBox2D*)__ReturnBuffer;
			}
		}

		public static FBox MakeBox(FVector Min, FVector Max)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Min?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Max?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeBox, __InBuffer, __ReturnBuffer);

				return *(FBox*)__ReturnBuffer;
			}
		}

		public static double Loge(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Loge, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double Log(double A, double Base = 1.000000)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = Base;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Log, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <param name="T">
		/// - The t of the intersection between the line and the plane
		/// </param>
		/// <param name="Intersection">
		/// - The point of intersection between the line and the plane
		/// </param>
		/// <returns>
		/// True if the intersection test was successful.
		/// </returns>
		public static bool LinePlaneIntersection_OriginNormal(FVector LineStart, FVector LineEnd, FVector PlaneOrigin, FVector PlaneNormal, ref float T, ref FVector Intersection)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[44];

				*(nint*)(__InBuffer) = LineStart?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LineEnd?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PlaneOrigin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = PlaneNormal?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = T;

				*(nint*)(__InBuffer + 36) = Intersection?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[12];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __LinePlaneIntersection_OriginNormal, __InBuffer, __OutBuffer, __ReturnBuffer);

				T = *(float*)(__OutBuffer);

				Intersection = *(FVector*)(__OutBuffer + 4);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="T">
		/// - The t of the intersection between the line and the plane
		/// </param>
		/// <param name="Intersection">
		/// - The point of intersection between the line and the plane
		/// </param>
		/// <returns>
		/// True if the intersection test was successful.
		/// </returns>
		public static bool LinePlaneIntersection(FVector LineStart, FVector LineEnd, FPlane APlane, ref float T, ref FVector Intersection)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = LineStart?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LineEnd?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = APlane?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = T;

				*(nint*)(__InBuffer + 28) = Intersection?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[12];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __LinePlaneIntersection, __InBuffer, __OutBuffer, __ReturnBuffer);

				T = *(float*)(__OutBuffer);

				Intersection = *(FVector*)(__OutBuffer + 4);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="A">
		/// The color and alpha to interpolate from as linear RGBA
		/// </param>
		/// <param name="B">
		/// The color and alpha to interpolate to as linear RGBA
		/// </param>
		/// <param name="Alpha">
		/// Scalar interpolation amount (usually between 0.0 and 1.0 inclusive)
		/// </param>
		/// <returns>
		/// The interpolated color in linear RGB space along with the interpolated alpha value
		/// </returns>
		public static FLinearColor LinearColorLerpUsingHSV(FLinearColor A, FLinearColor B, float Alpha)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Alpha;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LinearColorLerpUsingHSV, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static FLinearColor LinearColorLerp(FLinearColor A, FLinearColor B, float Alpha)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Alpha;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LinearColorLerp, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static FLinearColor LinearColor_Yellow()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_Yellow, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static FLinearColor LinearColor_White()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_White, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static FLinearColor LinearColor_Transparent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_Transparent, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static FColor LinearColor_ToRGBE(FLinearColor InLinearColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InLinearColor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_ToRGBE, __InBuffer, __ReturnBuffer);

				return *(FColor*)__ReturnBuffer;
			}
		}

		public static FLinearColor LinearColor_ToNewOpacity(FLinearColor InColor, float InOpacity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InOpacity;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_ToNewOpacity, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static void LinearColor_SetTemperature(ref FLinearColor InOutColor, float InTemperature)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InOutColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InTemperature;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_SetTemperature, __InBuffer, __OutBuffer);

				InOutColor = *(FLinearColor*)(__OutBuffer);

			}
		}

		public static void LinearColor_SetRGBA(ref FLinearColor InOutColor, float R, float G, float B, float A = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InOutColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = R;

				*(float*)(__InBuffer + 12) = G;

				*(float*)(__InBuffer + 16) = B;

				*(float*)(__InBuffer + 20) = A;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_SetRGBA, __InBuffer, __OutBuffer);

				InOutColor = *(FLinearColor*)(__OutBuffer);

			}
		}

		public static void LinearColor_SetRandomHue(ref FLinearColor InOutColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InOutColor?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_SetRandomHue, __InBuffer, __OutBuffer);

				InOutColor = *(FLinearColor*)(__OutBuffer);

			}
		}

		/// <param name="InSRGB">
		/// The sRGB color that needs to be converted into linear space.
		/// </param>
		public static void LinearColor_SetFromSRGB(ref FLinearColor InOutColor, FColor InSRGB)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InOutColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSRGB?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_SetFromSRGB, __InBuffer, __OutBuffer);

				InOutColor = *(FLinearColor*)(__OutBuffer);

			}
		}

		/// <param name="InColor">
		/// The Pow(1/2.2) color that needs to be converted into linear space.
		/// </param>
		public static void LinearColor_SetFromPow22(ref FLinearColor InOutColor, FColor InColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InOutColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_SetFromPow22, __InBuffer, __OutBuffer);

				InOutColor = *(FLinearColor*)(__OutBuffer);

			}
		}

		public static void LinearColor_SetFromHSV(ref FLinearColor InOutColor, float H, float S, float V, float A = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InOutColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = H;

				*(float*)(__InBuffer + 12) = S;

				*(float*)(__InBuffer + 16) = V;

				*(float*)(__InBuffer + 20) = A;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_SetFromHSV, __InBuffer, __OutBuffer);

				InOutColor = *(FLinearColor*)(__OutBuffer);

			}
		}

		public static void LinearColor_Set(ref FLinearColor InOutColor, FLinearColor InColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InOutColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_Set, __InBuffer, __OutBuffer);

				InOutColor = *(FLinearColor*)(__OutBuffer);

			}
		}

		public static FLinearColor LinearColor_Red()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_Red, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static FColor LinearColor_QuantizeRound(FLinearColor InColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_QuantizeRound, __InBuffer, __ReturnBuffer);

				return *(FColor*)__ReturnBuffer;
			}
		}

		public static FColor LinearColor_Quantize(FLinearColor InColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_Quantize, __InBuffer, __ReturnBuffer);

				return *(FColor*)__ReturnBuffer;
			}
		}

		public static bool LinearColor_IsNearEqual(FLinearColor A, FLinearColor B, float Tolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Tolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_IsNearEqual, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FLinearColor LinearColor_Green()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_Green, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static FLinearColor LinearColor_Gray()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_Gray, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The minimum color channel value
		/// </returns>
		public static float LinearColor_GetMin(FLinearColor InColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_GetMin, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The maximum color channel value
		/// </returns>
		public static float LinearColor_GetMax(FLinearColor InColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_GetMax, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static float LinearColor_GetLuminance(FLinearColor InColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_GetLuminance, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static float LinearColor_Distance(FLinearColor C1, FLinearColor C2)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = C1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = C2?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_Distance, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Desaturation">
		/// Desaturation factor in range [0..1]
		/// </param>
		/// <returns>
		/// Desaturated color
		/// </returns>
		public static FLinearColor LinearColor_Desaturated(FLinearColor InColor, float InDesaturation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InDesaturation;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_Desaturated, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static FLinearColor LinearColor_Blue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_Blue, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static FLinearColor LinearColor_Black()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __LinearColor_Black, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static FVector LessLess_VectorRotator(FVector A, FRotator B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LessLess_VectorRotator, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static bool LessEqual_TimespanTimespan(FTimespan A, FTimespan B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LessEqual_TimespanTimespan, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool LessEqual_IntInt(int A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = A;

				*(int*)(__InBuffer + 4) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LessEqual_IntInt, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool LessEqual_Int64Int64(long A, long B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(long*)(__InBuffer) = A;

				*(long*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LessEqual_Int64Int64, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool LessEqual_DoubleDouble(double A, double B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LessEqual_DoubleDouble, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool LessEqual_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LessEqual_DateTimeDateTime, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool LessEqual_ByteByte(byte A, byte B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = A;

				*(byte*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LessEqual_ByteByte, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Less_TimespanTimespan(FTimespan A, FTimespan B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Less_TimespanTimespan, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Less_IntInt(int A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = A;

				*(int*)(__InBuffer + 4) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Less_IntInt, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Less_Int64Int64(long A, long B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(long*)(__InBuffer) = A;

				*(long*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Less_Int64Int64, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Less_DoubleDouble(double A, double B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Less_DoubleDouble, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Less_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Less_DateTimeDateTime, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Less_ByteByte(byte A, byte B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = A;

				*(byte*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Less_ByteByte, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static double Lerp(double A, double B, double Alpha)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = B;

				*(double*)(__InBuffer + 16) = Alpha;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Lerp, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if vector is exactly zero, otherwise false.
		/// </returns>
		public static bool IsZero2D(FVector2D A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsZero2D, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Point">
		/// Point to test
		/// </param>
		/// <param name="BoxWorldTransform">
		/// Component-to-World transform of the box.
		/// </param>
		/// <param name="Box">
		/// Box to test agains in component space.
		/// </param>
		/// <returns>
		/// Whether the point is in the box.
		/// </returns>
		public static bool IsPointInBoxWithTransform_Box(FVector Point, FTransform BoxWorldTransform, FBox BoxExtent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Point?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoxWorldTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BoxExtent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsPointInBoxWithTransform_Box, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Point">
		/// Point to test
		/// </param>
		/// <param name="BoxWorldTransform">
		/// Component-to-World transform of the box.
		/// </param>
		/// <param name="BoxExtent">
		/// Extents of the box (distance in each axis from origin), in component space.
		/// </param>
		/// <returns>
		/// Whether the point is in the box.
		/// </returns>
		public static bool IsPointInBoxWithTransform(FVector Point, FTransform BoxWorldTransform, FVector BoxExtent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Point?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoxWorldTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BoxExtent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsPointInBoxWithTransform, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Point">
		/// Point to test
		/// </param>
		/// <param name="Box">
		/// Box to test against
		/// </param>
		/// <returns>
		/// Whether the point is in the box.
		/// </returns>
		public static bool IsPointInBox_Box(FVector Point, FBox Box)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Point?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Box?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsPointInBox_Box, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Point">
		/// Point to test
		/// </param>
		/// <param name="BoxOrigin">
		/// Origin of the box
		/// </param>
		/// <param name="BoxExtent">
		/// Extents of the box (distance in each axis from origin)
		/// </param>
		/// <returns>
		/// Whether the point is in the box.
		/// </returns>
		public static bool IsPointInBox(FVector Point, FVector BoxOrigin, FVector BoxExtent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Point?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoxOrigin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BoxExtent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsPointInBox, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Tolerance">
		/// Error tolerance.
		/// </param>
		/// <returns>
		/// true if vector is in tolerance to zero, otherwise false.
		/// </returns>
		public static bool IsNearlyZero2D(FVector2D A, float Tolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Tolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsNearlyZero2D, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsMorning(FDateTime A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsMorning, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsLeapYear(int Year)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Year;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsLeapYear, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsAfternoon(FDateTime A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsAfternoon, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="T">
		/// The transform you wish to invert
		/// </param>
		/// <returns>
		/// The inverse of T.
		/// </returns>
		public static FTransform InvertTransform(FTransform T)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = T?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __InvertTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public static FRotator InverseTransformRotation(FTransform T, FRotator Rotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = T?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __InverseTransformRotation, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static FVector InverseTransformLocation(FTransform T, FVector Location)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = T?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Location?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __InverseTransformLocation, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector InverseTransformDirection(FTransform T, FVector Direction)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = T?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Direction?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __InverseTransformDirection, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FIntPoint IntPoint_Zero()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __IntPoint_Zero, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public static FIntPoint IntPoint_Up()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __IntPoint_Up, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public static FIntPoint IntPoint_Right()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __IntPoint_Right, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public static FIntPoint IntPoint_One()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __IntPoint_One, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public static FIntPoint IntPoint_Left()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __IntPoint_Left, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public static FIntPoint IntPoint_Down()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __IntPoint_Down, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public static bool InRange_IntInt(int Value, int Min, int Max, bool InclusiveMin = true, bool InclusiveMax = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[14];

				*(int*)(__InBuffer) = Value;

				*(int*)(__InBuffer + 4) = Min;

				*(int*)(__InBuffer + 8) = Max;

				*(bool*)(__InBuffer + 12) = InclusiveMin;

				*(bool*)(__InBuffer + 13) = InclusiveMax;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __InRange_IntInt, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool InRange_Int64Int64(long Value, long Min, long Max, bool InclusiveMin = true, bool InclusiveMax = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(long*)(__InBuffer) = Value;

				*(long*)(__InBuffer + 8) = Min;

				*(long*)(__InBuffer + 16) = Max;

				*(bool*)(__InBuffer + 24) = InclusiveMin;

				*(bool*)(__InBuffer + 25) = InclusiveMax;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __InRange_Int64Int64, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool InRange_FloatFloat(double Value, double Min, double Max, bool InclusiveMin = true, bool InclusiveMax = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(double*)(__InBuffer) = Value;

				*(double*)(__InBuffer + 8) = Min;

				*(double*)(__InBuffer + 16) = Max;

				*(bool*)(__InBuffer + 24) = InclusiveMin;

				*(bool*)(__InBuffer + 25) = InclusiveMax;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __InRange_FloatFloat, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static double Hypotenuse(double Width, double Height)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = Width;

				*(double*)(__InBuffer + 8) = Height;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Hypotenuse, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FLinearColor HSVToRGBLinear(FLinearColor HSV)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = HSV?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __HSVToRGBLinear, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static void HSVToRGB_Vector(FLinearColor HSV, ref FLinearColor RGB)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = HSV?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RGB?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __HSVToRGB_Vector, __InBuffer, __OutBuffer);

				RGB = *(FLinearColor*)(__OutBuffer);

			}
		}

		public static FLinearColor HSVToRGB(float H, float S, float V, float A = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(float*)(__InBuffer) = H;

				*(float*)(__InBuffer + 4) = S;

				*(float*)(__InBuffer + 8) = V;

				*(float*)(__InBuffer + 12) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __HSVToRGB, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static double GridSnap_Float(double Location, double GridSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = Location;

				*(double*)(__InBuffer + 8) = GridSize;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GridSnap_Float, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FVector GreaterGreater_VectorRotator(FVector A, FRotator B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GreaterGreater_VectorRotator, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static bool GreaterEqual_TimespanTimespan(FTimespan A, FTimespan B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GreaterEqual_TimespanTimespan, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GreaterEqual_IntInt(int A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = A;

				*(int*)(__InBuffer + 4) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GreaterEqual_IntInt, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GreaterEqual_Int64Int64(long A, long B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(long*)(__InBuffer) = A;

				*(long*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GreaterEqual_Int64Int64, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GreaterEqual_DoubleDouble(double A, double B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GreaterEqual_DoubleDouble, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GreaterEqual_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GreaterEqual_DateTimeDateTime, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GreaterEqual_ByteByte(byte A, byte B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = A;

				*(byte*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GreaterEqual_ByteByte, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Greater_TimespanTimespan(FTimespan A, FTimespan B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Greater_TimespanTimespan, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Greater_IntInt(int A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = A;

				*(int*)(__InBuffer + 4) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Greater_IntInt, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Greater_Int64Int64(long A, long B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(long*)(__InBuffer) = A;

				*(long*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Greater_Int64Int64, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Greater_DoubleDouble(double A, double B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Greater_DoubleDouble, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Greater_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Greater_DateTimeDateTime, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Greater_ByteByte(byte A, byte B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = A;

				*(byte*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Greater_ByteByte, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static int GetYear(FDateTime A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetYear, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static void GetYawPitchFromVector(FVector InVec, ref float Yaw, ref float Pitch)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InVec?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Yaw;

				*(float*)(__InBuffer + 12) = Pitch;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetYawPitchFromVector, __InBuffer, __OutBuffer);

				Yaw = *(float*)(__OutBuffer);

				Pitch = *(float*)(__OutBuffer + 4);

			}
		}

		public static FVector GetVectorArrayAverage(TArray<FVector> Vectors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Vectors?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetVectorArrayAverage, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector GetUpVector(FRotator InRot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InRot?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetUpVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static float GetTotalSeconds(FTimespan A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTotalSeconds, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static float GetTotalMinutes(FTimespan A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTotalMinutes, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static float GetTotalMilliseconds(FTimespan A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTotalMilliseconds, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static float GetTotalHours(FTimespan A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTotalHours, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static float GetTotalDays(FTimespan A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTotalDays, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static FTimespan GetTimeOfDay(FDateTime A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTimeOfDay, __InBuffer, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		public static double GetTAU()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetTAU, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <param name="MyRightYAxis">
		/// Right (Y) direction unit vector of Actor standing on Slope.
		/// </param>
		/// <param name="FloorNormal">
		/// Floor Normal (unit) vector.
		/// </param>
		/// <param name="UpVector">
		/// UpVector of reference frame.
		/// </param>
		/// <outparam>
		/// OutSlopePitchDegreeAngle	Slope Pitch angle (degrees)
		/// </outparam>
		/// <outparam>
		/// OutSlopeRollDegreeAngle		Slope Roll angle (degrees)
		/// </outparam>
		public static void GetSlopeDegreeAngles(FVector MyRightYAxis, FVector FloorNormal, FVector UpVector, ref float OutSlopePitchDegreeAngle, ref float OutSlopeRollDegreeAngle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = MyRightYAxis?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FloorNormal?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = UpVector?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = OutSlopePitchDegreeAngle;

				*(float*)(__InBuffer + 28) = OutSlopeRollDegreeAngle;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetSlopeDegreeAngles, __InBuffer, __OutBuffer);

				OutSlopePitchDegreeAngle = *(float*)(__OutBuffer);

				OutSlopeRollDegreeAngle = *(float*)(__OutBuffer + 4);

			}
		}

		public static int GetSeconds(FTimespan A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSeconds, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetSecond(FDateTime A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSecond, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="AngleDeg">
		/// Angle to rotate (in degrees)
		/// </param>
		/// <returns>
		/// Rotated Vector
		/// </returns>
		public static FVector2D GetRotated2D(FVector2D A, float AngleDeg)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = AngleDeg;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetRotated2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FVector GetRightVector(FRotator InRot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InRot?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetRightVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="Direction">
		/// Direction vector the ray is coming from.
		/// </param>
		/// <param name="SurfaceNormal">
		/// A normal of the surface the ray should be reflected on.
		/// </param>
		/// <returns>
		/// Reflected vector.
		/// </returns>
		public static FVector GetReflectionVector(FVector Direction, FVector SurfaceNormal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Direction?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SurfaceNormal?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetReflectionVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="Point">
		/// Point for which we find the distance to the closest point on the segment.
		/// </param>
		/// <param name="SegmentStart">
		/// Start of the segment.
		/// </param>
		/// <param name="SegmentEnd">
		/// End of the segment.
		/// </param>
		/// <returns>
		/// The distance from the given point to the closest point on the segment.
		/// </returns>
		public static float GetPointDistanceToSegment(FVector Point, FVector SegmentStart, FVector SegmentEnd)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Point?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SegmentStart?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SegmentEnd?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPointDistanceToSegment, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Point">
		/// Point for which we find the distance to the closest point on the line.
		/// </param>
		/// <param name="LineOrigin">
		/// Point of reference on the line.
		/// </param>
		/// <param name="LineDirection">
		/// Direction of the line. Not required to be normalized.
		/// </param>
		/// <returns>
		/// The distance from the given point to the closest point on the line.
		/// </returns>
		public static float GetPointDistanceToLine(FVector Point, FVector LineOrigin, FVector LineDirection)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Point?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LineOrigin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = LineDirection?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPointDistanceToLine, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static double GetPI()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetPI, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static int GetMonth(FDateTime A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMonth, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetMinutes(FTimespan A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMinutes, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetMinute(FDateTime A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMinute, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static double GetMinElement(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMinElement, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The minimum value of the vector's components.
		/// </returns>
		public static double GetMin2D(FVector2D A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMin2D, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static int GetMilliseconds(FTimespan A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMilliseconds, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetMillisecond(FDateTime A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMillisecond, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static double GetMaxElement(FVector A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMaxElement, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The maximum value of the vector's components.
		/// </returns>
		public static double GetMax2D(FVector2D A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMax2D, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static int GetHours(FTimespan A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetHours, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetHour12(FDateTime A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetHour12, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetHour(FDateTime A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetHour, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static FVector GetForwardVector(FRotator InRot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InRot?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetForwardVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FTimespan GetDuration(FTimespan A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDuration, __InBuffer, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		public static FVector GetDirectionUnitVector(FVector From, FVector To)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = From?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = To?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDirectionUnitVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static int GetDays(FTimespan A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDays, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetDayOfYear(FDateTime A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDayOfYear, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetDay(FDateTime A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDay, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static FDateTime GetDate(FDateTime A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDate, __InBuffer, __ReturnBuffer);

				return *(FDateTime*)__ReturnBuffer;
			}
		}

		public static void GetAzimuthAndElevation(FVector InDirection, FTransform ReferenceFrame, ref float Azimuth, ref float Elevation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InDirection?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ReferenceFrame?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Azimuth;

				*(float*)(__InBuffer + 20) = Elevation;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAzimuthAndElevation, __InBuffer, __OutBuffer);

				Azimuth = *(float*)(__OutBuffer);

				Elevation = *(float*)(__OutBuffer + 4);

			}
		}

		public static void GetAxes(FRotator A, ref FVector X, ref FVector Y, ref FVector Z)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = X?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Y?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Z?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAxes, __InBuffer, __OutBuffer);

				X = *(FVector*)(__OutBuffer);

				Y = *(FVector*)(__OutBuffer + 8);

				Z = *(FVector*)(__OutBuffer + 16);

			}
		}

		/// <returns>
		/// The maximum absolute value of the vector's components.
		/// </returns>
		public static double GetAbsMax2D(FVector2D A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAbsMax2D, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// A copy of this vector with absolute value of each component.
		/// </returns>
		public static FVector2D GetAbs2D(FVector2D A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAbs2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static double FWrap(double Value, double Min, double Max)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(double*)(__InBuffer) = Value;

				*(double*)(__InBuffer + 8) = Min;

				*(double*)(__InBuffer + 16) = Max;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FWrap, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FIntVector FTruncVector(FVector InVector)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVector?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FTruncVector, __InBuffer, __ReturnBuffer);

				return *(FIntVector*)__ReturnBuffer;
			}
		}

		public static long FTrunc64(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FTrunc64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static int FTrunc(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FTrunc, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="UnixTime">
		/// Unix time (seconds from midnight 1970-01-01)
		/// </param>
		/// <see>
		/// ToUnixTimestamp
		/// </see>
		/// <returns>
		/// Gregorian date and time.
		/// </returns>
		public static FDateTime FromUnixTimestamp(long UnixTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(long*)(__InBuffer) = UnixTime;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FromUnixTimestamp, __InBuffer, __ReturnBuffer);

				return *(FDateTime*)__ReturnBuffer;
			}
		}

		public static FTimespan FromSeconds(float Seconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Seconds;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FromSeconds, __InBuffer, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		public static FTimespan FromMinutes(float Minutes)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Minutes;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FromMinutes, __InBuffer, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		public static FTimespan FromMilliseconds(float Milliseconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Milliseconds;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FromMilliseconds, __InBuffer, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		public static FTimespan FromHours(float Hours)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Hours;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FromHours, __InBuffer, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		public static FTimespan FromDays(float Days)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Days;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FromDays, __InBuffer, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		public static double Fraction(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Fraction, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static long FMod64(double Dividend, double Divisor, ref double Remainder)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(double*)(__InBuffer) = Dividend;

				*(double*)(__InBuffer + 8) = Divisor;

				*(double*)(__InBuffer + 16) = Remainder;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __FMod64, __InBuffer, __OutBuffer, __ReturnBuffer);

				Remainder = *(double*)(__OutBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static int FMod(double Dividend, double Divisor, ref double Remainder)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(double*)(__InBuffer) = Dividend;

				*(double*)(__InBuffer + 8) = Divisor;

				*(double*)(__InBuffer + 16) = Remainder;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __FMod, __InBuffer, __OutBuffer, __ReturnBuffer);

				Remainder = *(double*)(__OutBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static double FMin(double A, double B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FMin, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double FMax(double A, double B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FMax, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <param name="Current">
		/// Current value
		/// </param>
		/// <param name="Target">
		/// Target value
		/// </param>
		/// <param name="SpringState">
		/// Data related to spring model (velocity, error, etc..) - Create a unique variable per spring
		/// </param>
		/// <param name="Stiffness">
		/// How stiff the spring model is (more stiffness means more oscillation around the target value)
		/// </param>
		/// <param name="CriticalDampingFactor">
		/// How much damping to apply to the spring (0 means no damping, 1 means critically damped which means no oscillation)
		/// </param>
		/// <param name="DeltaTime">
		/// Time difference since the last update
		/// </param>
		/// <param name="Mass">
		/// Multiplier that acts like mass on a spring
		/// </param>
		/// <param name="TargetVelocityAmount">
		/// If 1 then the target velocity will be calculated and used, which results following the target more closely/without lag. Values down to zero (recommended when using this to smooth data) will progressively disable this effect.
		/// </param>
		/// <param name="bClamp">
		/// Whether to use the Min/Max values to clamp the motion
		/// </param>
		/// <param name="MinValue">
		/// Clamps the minimum output value and cancels the velocity if it reaches this limit
		/// </param>
		/// <param name="MaxValue">
		/// Clamps the maximum output value and cancels the velocity if it reaches this limit
		/// </param>
		/// <param name="bInitializeFromTarget">
		/// If set then the current value will be set from the target on the first update
		/// </param>
		public static float FloatSpringInterp(float Current, float Target, ref FFloatSpringState SpringState, float Stiffness, float CriticalDampingFactor, float DeltaTime, float Mass, float TargetVelocityAmount, bool bClamp, float MinValue, float MaxValue, bool bInitializeFromTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[46];

				*(float*)(__InBuffer) = Current;

				*(float*)(__InBuffer + 4) = Target;

				*(nint*)(__InBuffer + 8) = SpringState?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Stiffness;

				*(float*)(__InBuffer + 20) = CriticalDampingFactor;

				*(float*)(__InBuffer + 24) = DeltaTime;

				*(float*)(__InBuffer + 28) = Mass;

				*(float*)(__InBuffer + 32) = TargetVelocityAmount;

				*(bool*)(__InBuffer + 36) = bClamp;

				*(float*)(__InBuffer + 37) = MinValue;

				*(float*)(__InBuffer + 41) = MaxValue;

				*(bool*)(__InBuffer + 45) = bInitializeFromTarget;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __FloatSpringInterp, __InBuffer, __OutBuffer, __ReturnBuffer);

				SpringState = *(FFloatSpringState*)(__OutBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="InCurrent">
		/// is the current rotation value
		/// </param>
		/// <param name="InDesired">
		/// is the desired rotation value
		/// </param>
		/// <param name="InDeltaRate">
		/// is the rotation amount to apply
		/// </param>
		/// <returns>
		/// a new rotation component value clamped in the range (-360,360)
		/// </returns>
		public static float FixedTurn(float InCurrent, float InDesired, float InDeltaRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = InCurrent;

				*(float*)(__InBuffer + 4) = InDesired;

				*(float*)(__InBuffer + 8) = InDeltaRate;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FixedTurn, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Current">
		/// Actual position
		/// </param>
		/// <param name="Target">
		/// Target position
		/// </param>
		/// <param name="DeltaTime">
		/// Time since last tick
		/// </param>
		/// <param name="InterpSpeed">
		/// Interpolation speed
		/// </param>
		/// <returns>
		/// New interpolated position
		/// </returns>
		public static double FInterpTo_Constant(double Current, double Target, double DeltaTime, double InterpSpeed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(double*)(__InBuffer) = Current;

				*(double*)(__InBuffer + 8) = Target;

				*(double*)(__InBuffer + 16) = DeltaTime;

				*(double*)(__InBuffer + 24) = InterpSpeed;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FInterpTo_Constant, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <param name="Current">
		/// Actual position
		/// </param>
		/// <param name="Target">
		/// Target position
		/// </param>
		/// <param name="DeltaTime">
		/// Time since last tick
		/// </param>
		/// <param name="InterpSpeed">
		/// Interpolation speed, if the speed given is 0, then jump to the target.
		/// </param>
		/// <returns>
		/// New interpolated position
		/// </returns>
		public static double FInterpTo(double Current, double Target, double DeltaTime, double InterpSpeed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(double*)(__InBuffer) = Current;

				*(double*)(__InBuffer + 8) = Target;

				*(double*)(__InBuffer + 16) = DeltaTime;

				*(double*)(__InBuffer + 24) = InterpSpeed;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FInterpTo, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double FInterpEaseInOut(double A, double B, double Alpha, double Exponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = B;

				*(double*)(__InBuffer + 16) = Alpha;

				*(double*)(__InBuffer + 24) = Exponent;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FInterpEaseInOut, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FRotator FindRelativeLookAtRotation(FTransform StartTransform, FVector TargetLocation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = StartTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TargetLocation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindRelativeLookAtRotation, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <param name="Segment1Start">
		/// Start of the 1st segment.
		/// </param>
		/// <param name="Segment1End">
		/// End of the 1st segment.
		/// </param>
		/// <param name="Segment2Start">
		/// Start of the 2nd segment.
		/// </param>
		/// <param name="Segment2End">
		/// End of the 2nd segment.
		/// </param>
		/// <param name="Segment1Point">
		/// Closest point on segment 1 to segment 2.
		/// </param>
		/// <param name="Segment2Point">
		/// Closest point on segment 2 to segment 1.
		/// </param>
		public static void FindNearestPointsOnLineSegments(FVector Segment1Start, FVector Segment1End, FVector Segment2Start, FVector Segment2End, ref FVector Segment1Point, ref FVector Segment2Point)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[48];

				*(nint*)(__InBuffer) = Segment1Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Segment1End?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Segment2Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Segment2End?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Segment1Point?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = Segment2Point?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __FindNearestPointsOnLineSegments, __InBuffer, __OutBuffer);

				Segment1Point = *(FVector*)(__OutBuffer);

				Segment2Point = *(FVector*)(__OutBuffer + 8);

			}
		}

		public static FRotator FindLookAtRotation(FVector Start, FVector Target)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Target?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindLookAtRotation, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <param name="Point">
		/// Point for which we find the closest point on the segment.
		/// </param>
		/// <param name="SegmentStart">
		/// Start of the segment.
		/// </param>
		/// <param name="SegmentEnd">
		/// End of the segment.
		/// </param>
		/// <returns>
		/// The closest point on the segment to the given point.
		/// </returns>
		public static FVector FindClosestPointOnSegment(FVector Point, FVector SegmentStart, FVector SegmentEnd)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Point?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SegmentStart?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SegmentEnd?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindClosestPointOnSegment, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="Point">
		/// Point for which we find the closest point on the line.
		/// </param>
		/// <param name="LineOrigin">
		/// Point of reference on the line.
		/// </param>
		/// <param name="LineDirection">
		/// Direction of the line. Not required to be normalized.
		/// </param>
		/// <returns>
		/// The closest point on the line to the given point.
		/// </returns>
		public static FVector FindClosestPointOnLine(FVector Point, FVector LineOrigin, FVector LineDirection)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Point?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LineOrigin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = LineDirection?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindClosestPointOnLine, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static long FFloor64(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FFloor64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static int FFloor(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FFloor, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static double FClamp(double Value, double Min, double Max)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(double*)(__InBuffer) = Value;

				*(double*)(__InBuffer + 8) = Min;

				*(double*)(__InBuffer + 16) = Max;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FClamp, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static long FCeil64(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FCeil64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static int FCeil(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FCeil, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static double Exp(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Exp, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static bool EqualExactly_VectorVector(FVector A, FVector B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualExactly_VectorVector, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualExactly_Vector4Vector4(FVector4 A, FVector4 B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualExactly_Vector4Vector4, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualExactly_Vector2DVector2D(FVector2D A, FVector2D B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualExactly_Vector2DVector2D, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_VectorVector(FVector A, FVector B, float ErrorTolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = ErrorTolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_VectorVector, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_Vector4Vector4(FVector4 A, FVector4 B, float ErrorTolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = ErrorTolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_Vector4Vector4, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_Vector2DVector2D(FVector2D A, FVector2D B, float ErrorTolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = ErrorTolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_Vector2DVector2D, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_TransformTransform(FTransform A, FTransform B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_TransformTransform, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_TimespanTimespan(FTimespan A, FTimespan B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_TimespanTimespan, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_RotatorRotator(FRotator A, FRotator B, float ErrorTolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = ErrorTolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_RotatorRotator, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_QuatQuat(FQuat A, FQuat B, float Tolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Tolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_QuatQuat, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_ObjectObject(UObject A, UObject B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_ObjectObject, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_NameName(FName A, FName B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_NameName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Other">
		/// The other Matrix.
		/// </param>
		/// <param name="Tolerance">
		/// Error Tolerance.
		/// </param>
		/// <returns>
		/// true if two Matrix are equal, within specified tolerance, otherwise false.
		/// </returns>
		public static bool EqualEqual_MatrixMatrix(FMatrix A, FMatrix B, float Tolerance = 0.000100f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Tolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_MatrixMatrix, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_LinearColorLinearColor(FLinearColor A, FLinearColor B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_LinearColorLinearColor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_IntInt(int A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = A;

				*(int*)(__InBuffer + 4) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_IntInt, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_Int64Int64(long A, long B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(long*)(__InBuffer) = A;

				*(long*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_Int64Int64, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_DoubleDouble(double A, double B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_DoubleDouble, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_DateTimeDateTime, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_ClassClass(UClass A, UClass B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_ClassClass, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_ByteByte(byte A, byte B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = A;

				*(byte*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_ByteByte, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_BoolBool(bool A, bool B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = A;

				*(bool*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_BoolBool, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool Equal_IntPointIntPoint(FIntPoint A, FIntPoint B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Equal_IntPointIntPoint, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static double Ease(double A, double B, double Alpha, EEasingFunc EasingFunc, double BlendExp = 2.000000, int Steps = 2)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[37];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = B;

				*(double*)(__InBuffer + 16) = Alpha;

				*(byte*)(__InBuffer + 24) = (byte)EasingFunc;

				*(double*)(__InBuffer + 25) = BlendExp;

				*(int*)(__InBuffer + 33) = Steps;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Ease, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <param name="CurrentSample">
		/// - The value to blend with the previous sample to get a new weighted value
		/// </param>
		/// <param name="PreviousSample">
		/// - The last value from the series
		/// </param>
		/// <param name="MaxDistance">
		/// - Distance to use as the blend between min weight or max weight
		/// </param>
		/// <param name="MinWeight">
		/// - The weight use when the distance is small
		/// </param>
		/// <param name="MaxWeight">
		/// - The weight use when the distance is large
		/// </param>
		/// <returns>
		/// the next value in the series
		/// </returns>
		public static FVector DynamicWeightedMovingAverage_FVector(FVector CurrentSample, FVector PreviousSample, float MaxDistance, float MinWeight, float MaxWeight)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = CurrentSample?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PreviousSample?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = MaxDistance;

				*(float*)(__InBuffer + 20) = MinWeight;

				*(float*)(__InBuffer + 24) = MaxWeight;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __DynamicWeightedMovingAverage_FVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="CurrentSample">
		/// - The value to blend with the previous sample to get a new weighted value
		/// </param>
		/// <param name="PreviousSample">
		/// - The last value from the series
		/// </param>
		/// <param name="MaxDistance">
		/// - Distance to use as the blend between min weight or max weight
		/// </param>
		/// <param name="MinWeight">
		/// - The weight use when the distance is small
		/// </param>
		/// <param name="MaxWeight">
		/// - The weight use when the distance is large
		/// </param>
		/// <returns>
		/// the next value in the series
		/// </returns>
		public static FRotator DynamicWeightedMovingAverage_FRotator(FRotator CurrentSample, FRotator PreviousSample, float MaxDistance, float MinWeight, float MaxWeight)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = CurrentSample?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PreviousSample?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = MaxDistance;

				*(float*)(__InBuffer + 20) = MinWeight;

				*(float*)(__InBuffer + 24) = MaxWeight;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __DynamicWeightedMovingAverage_FRotator, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <param name="CurrentSample">
		/// - The value to blend with the previous sample to get a new weighted value
		/// </param>
		/// <param name="PreviousSample">
		/// - The last value from the series
		/// </param>
		/// <param name="MaxDistance">
		/// - Distance to use as the blend between min weight or max weight
		/// </param>
		/// <param name="MinWeight">
		/// - The weight use when the distance is small
		/// </param>
		/// <param name="MaxWeight">
		/// - The weight use when the distance is large
		/// </param>
		/// <returns>
		/// the next value in the series
		/// </returns>
		public static float DynamicWeightedMovingAverage_Float(float CurrentSample, float PreviousSample, float MaxDistance, float MinWeight, float MaxWeight)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(float*)(__InBuffer) = CurrentSample;

				*(float*)(__InBuffer + 4) = PreviousSample;

				*(float*)(__InBuffer + 8) = MaxDistance;

				*(float*)(__InBuffer + 12) = MinWeight;

				*(float*)(__InBuffer + 16) = MaxWeight;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DynamicWeightedMovingAverage_Float, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static double DotProduct2D(FVector2D A, FVector2D B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DotProduct2D, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double Dot_VectorVector(FVector A, FVector B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Dot_VectorVector, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FVector Divide_VectorVector(FVector A, FVector B = null)
		{
			unsafe
			{
				B ??= new FVector(1.000000, 1.000000, 1.000000);

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Divide_VectorVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Divide_VectorInt(FVector A, int B = 1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Divide_VectorInt, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Divide_VectorFloat(FVector A, double B = 1.000000)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Divide_VectorFloat, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector4 Divide_Vector4Vector4(FVector4 A, FVector4 B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Divide_Vector4Vector4, __InBuffer, __ReturnBuffer);

				return *(FVector4*)__ReturnBuffer;
			}
		}

		public static FVector2D Divide_Vector2DVector2D(FVector2D A, FVector2D B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Divide_Vector2DVector2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FVector2D Divide_Vector2DFloat(FVector2D A, double B = 1.000000)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Divide_Vector2DFloat, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FTimespan Divide_TimespanFloat(FTimespan A, float Scalar)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Scalar;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Divide_TimespanFloat, __InBuffer, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		public static FLinearColor Divide_LinearColorLinearColor(FLinearColor A, FLinearColor B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Divide_LinearColorLinearColor, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static FIntPoint Divide_IntPointIntPoint(FIntPoint A, FIntPoint B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Divide_IntPointIntPoint, __InBuffer, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public static FIntPoint Divide_IntPointInt(FIntPoint A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Divide_IntPointInt, __InBuffer, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public static int Divide_IntInt(int A, int B = 1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = A;

				*(int*)(__InBuffer + 4) = B;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Divide_IntInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static long Divide_Int64Int64(long A, long B = 1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(long*)(__InBuffer) = A;

				*(long*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Divide_Int64Int64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static double Divide_DoubleDouble(double A, double B = 1.000000)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Divide_DoubleDouble, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static byte Divide_ByteByte(byte A, byte B = 1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = A;

				*(byte*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Divide_ByteByte, __InBuffer, __ReturnBuffer);

				return *(byte*)__ReturnBuffer;
			}
		}

		/// <param name="V1">
		/// The first point.
		/// </param>
		/// <param name="V2">
		/// The second point.
		/// </param>
		/// <returns>
		/// The squared distance between two 2D points.
		/// </returns>
		public static double DistanceSquared2D(FVector2D V1, FVector2D V2)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = V1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = V2?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DistanceSquared2D, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <param name="V1">
		/// The first point.
		/// </param>
		/// <param name="V2">
		/// The second point.
		/// </param>
		/// <returns>
		/// The distance between two 2D points.
		/// </returns>
		public static double Distance2D(FVector2D V1, FVector2D V2)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = V1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = V2?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Distance2D, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double DegTan(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DegTan, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double DegSin(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DegSin, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double DegreesToRadians(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DegreesToRadians, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double DegCos(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DegCos, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double DegAtan2(double Y, double X)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = Y;

				*(double*)(__InBuffer + 8) = X;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DegAtan2, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double DegAtan(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DegAtan, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double DegAsin(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DegAsin, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double DegAcos(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DegAcos, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static int DaysInYear(int Year)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Year;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DaysInYear, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int DaysInMonth(int Year, int Month)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = Year;

				*(int*)(__InBuffer + 4) = Month;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DaysInMonth, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static FDateTime DateTimeMinValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __DateTimeMinValue, __ReturnBuffer);

				return *(FDateTime*)__ReturnBuffer;
			}
		}

		public static FDateTime DateTimeMaxValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __DateTimeMaxValue, __ReturnBuffer);

				return *(FDateTime*)__ReturnBuffer;
			}
		}

		public static bool DateTimeFromString(FString DateTimeString, ref FDateTime Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = DateTimeString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Result?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __DateTimeFromString, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(FDateTime*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool DateTimeFromIsoString(FString IsoString, ref FDateTime Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = IsoString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Result?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __DateTimeFromIsoString, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(FDateTime*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static double CrossProduct2D(FVector2D A, FVector2D B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CrossProduct2D, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FVector Cross_VectorVector(FVector A, FVector B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Cross_VectorVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector CreateVectorFromYawPitch(float Yaw, float Pitch, float Length = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = Yaw;

				*(float*)(__InBuffer + 4) = Pitch;

				*(float*)(__InBuffer + 8) = Length;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateVectorFromYawPitch, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static double Cos(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Cos, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FVector2D Conv_VectorToVector2D(FVector InVector)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVector?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_VectorToVector2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FTransform Conv_VectorToTransform(FVector InLocation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InLocation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_VectorToTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// FRotator from the Vector's direction, without any roll.
		/// </returns>
		public static FRotator Conv_VectorToRotator(FVector InVec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVec?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_VectorToRotator, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <note>
		/// If you don't care about preserving the up vector and just want the most direct rotation, you can use the faster
		/// 'FindBetweenVectors(ForwardVector, YourVector)' or 'FindBetweenNormals(...)' if you know the vector is of unit length.
		/// </note>
		/// <returns>
		/// Quaternion from the Vector's direction, without any roll.
		/// </returns>
		public static FQuat Conv_VectorToQuaternion(FVector InVec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVec?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_VectorToQuaternion, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		public static FLinearColor Conv_VectorToLinearColor(FVector InVec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVec?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_VectorToLinearColor, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static FVector Conv_Vector4ToVector(FVector4 InVector4)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVector4?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_Vector4ToVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// FRotator from the Vector's direction, without any roll.
		/// </returns>
		public static FRotator Conv_Vector4ToRotator(FVector4 InVec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVec?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_Vector4ToRotator, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <note>
		/// If you don't care about preserving the up vector and just want the most direct rotation, you can use the faster
		/// 'FindBetweenVectors(ForwardVector, YourVector)' or 'FindBetweenNormals(...)' if you know the vector is of unit length.
		/// </note>
		/// <returns>
		/// Quaternion from the Vector's direction, without any roll.
		/// </returns>
		public static FQuat Conv_Vector4ToQuaternion(FVector4 InVec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVec?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_Vector4ToQuaternion, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		public static FVector Conv_Vector2DToVector(FVector2D InVector2D, float Z = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InVector2D?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Z;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_Vector2DToVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FIntPoint Conv_Vector2DToIntPoint(FVector2D InVector2D)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVector2D?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_Vector2DToIntPoint, __InBuffer, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public static FMatrix Conv_TransformToMatrix(FTransform Transform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Transform?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_TransformToMatrix, __InBuffer, __ReturnBuffer);

				return *(FMatrix*)__ReturnBuffer;
			}
		}

		public static FVector Conv_RotatorToVector(FRotator InRot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InRot?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_RotatorToVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FTransform Conv_RotatorToTransform(FRotator InRotator)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InRotator?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_RotatorToTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public static FQuat Conv_RotatorToQuaternion(FRotator InRot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InRot?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_RotatorToQuaternion, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		public static FTransform Conv_MatrixToTransform(FMatrix InMatrix)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMatrix?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_MatrixToTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public static FRotator Conv_MatrixToRotator(FMatrix InMatrix)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMatrix?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_MatrixToRotator, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static FVector Conv_LinearColorToVector(FLinearColor InLinearColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InLinearColor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_LinearColorToVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FColor Conv_LinearColorToColor(FLinearColor InLinearColor, bool InUseSRGB = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InLinearColor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = InUseSRGB;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_LinearColorToColor, __InBuffer, __ReturnBuffer);

				return *(FColor*)__ReturnBuffer;
			}
		}

		public static FVector Conv_IntVectorToVector(FIntVector InIntVector)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InIntVector?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_IntVectorToVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Conv_IntToVector(int InInt)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InInt;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_IntToVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FIntVector Conv_IntToIntVector(int InInt)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InInt;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_IntToIntVector, __InBuffer, __ReturnBuffer);

				return *(FIntVector*)__ReturnBuffer;
			}
		}

		public static long Conv_IntToInt64(int InInt)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InInt;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_IntToInt64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static double Conv_IntToDouble(int InInt)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InInt;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_IntToDouble, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static byte Conv_IntToByte(int InInt)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InInt;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_IntToByte, __InBuffer, __ReturnBuffer);

				return *(byte*)__ReturnBuffer;
			}
		}

		public static bool Conv_IntToBool(int InInt)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InInt;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_IntToBool, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FVector2D Conv_IntPointToVector2D(FIntPoint InIntPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InIntPoint?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_IntPointToVector2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static int Conv_Int64ToInt(long InInt)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(long*)(__InBuffer) = InInt;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_Int64ToInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static double Conv_Int64ToDouble(long InInt)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(long*)(__InBuffer) = InInt;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_Int64ToDouble, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static byte Conv_Int64ToByte(long InInt)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(long*)(__InBuffer) = InInt;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_Int64ToByte, __InBuffer, __ReturnBuffer);

				return *(byte*)__ReturnBuffer;
			}
		}

		public static double Conv_FloatToDouble(float InFloat)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InFloat;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_FloatToDouble, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FVector2D Conv_DoubleToVector2D(double InDouble)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = InDouble;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_DoubleToVector2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FVector Conv_DoubleToVector(double InDouble)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = InDouble;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_DoubleToVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FLinearColor Conv_DoubleToLinearColor(double InDouble)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = InDouble;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_DoubleToLinearColor, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static long Conv_DoubleToInt64(double InDouble)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = InDouble;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_DoubleToInt64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static float Conv_DoubleToFloat(double InDouble)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = InDouble;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_DoubleToFloat, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static FLinearColor Conv_ColorToLinearColor(FColor InColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_ColorToLinearColor, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static long Conv_ByteToInt64(byte InByte)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = InByte;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_ByteToInt64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static int Conv_ByteToInt(byte InByte)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = InByte;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_ByteToInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static double Conv_ByteToDouble(byte InByte)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = InByte;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_ByteToDouble, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static int Conv_BoolToInt(bool InBool)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InBool;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_BoolToInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static double Conv_BoolToDouble(bool InBool)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InBool;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_BoolToDouble, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static byte Conv_BoolToByte(bool InBool)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InBool;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_BoolToByte, __InBuffer, __ReturnBuffer);

				return *(byte*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// New transform: A * B
		/// </returns>
		public static FTransform ComposeTransforms(FTransform A, FTransform B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ComposeTransforms, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public static FRotator ComposeRotators(FRotator A, FRotator B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ComposeRotators, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if TestClass == ParentClass, or if TestClass is a child of ParentClass; false otherwise, or if either
		/// the value for either parameter is 'None'.
		/// </returns>
		public static bool ClassIsChildOf(TSubclassOf<UObject> TestClass, TSubclassOf<UObject> ParentClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TestClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParentClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ClassIsChildOf, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FVector ClampVectorSize(FVector A, double Min, double Max)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = Min;

				*(double*)(__InBuffer + 16) = Max;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ClampVectorSize, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static long ClampInt64(long Value, long Min, long Max)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(long*)(__InBuffer) = Value;

				*(long*)(__InBuffer + 8) = Min;

				*(long*)(__InBuffer + 16) = Max;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ClampInt64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		/// <param name="Angle">
		/// The angle to clamp.
		/// </param>
		/// <returns>
		/// The clamped angle.
		/// </returns>
		public static float ClampAxis(float Angle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Angle;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ClampAxis, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// New vector with clamped axes.
		/// </returns>
		public static FVector2D ClampAxes2D(FVector2D A, double MinAxisVal, double MaxAxisVal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = MinAxisVal;

				*(double*)(__InBuffer + 16) = MaxAxisVal;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ClampAxes2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		/// <param name="MinAngleDegrees">
		/// "from" angle that defines the beginning of the range of valid angles (sweeping clockwise)
		/// </param>
		/// <param name="MaxAngleDegrees">
		/// "to" angle that defines the end of the range of valid angles
		/// </param>
		/// <returns>
		/// Returns clamped angle in the range -180..180.
		/// </returns>
		public static double ClampAngle(double AngleDegrees, double MinAngleDegrees, double MaxAngleDegrees)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(double*)(__InBuffer) = AngleDegrees;

				*(double*)(__InBuffer + 8) = MinAngleDegrees;

				*(double*)(__InBuffer + 16) = MaxAngleDegrees;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ClampAngle, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static int Clamp(int Value, int Min, int Max)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = Value;

				*(int*)(__InBuffer + 4) = Min;

				*(int*)(__InBuffer + 8) = Max;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Clamp, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Current">
		/// Current Color
		/// </param>
		/// <param name="Target">
		/// Target Color
		/// </param>
		/// <param name="DeltaTime">
		/// Time since last tick
		/// </param>
		/// <param name="InterpSpeed">
		/// Interpolation speed, if the speed given is 0, then jump to the target.
		/// </param>
		/// <returns>
		/// New interpolated Color
		/// </returns>
		public static FLinearColor CInterpTo(FLinearColor Current, FLinearColor Target, float DeltaTime, float InterpSpeed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Current?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Target?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = DeltaTime;

				*(float*)(__InBuffer + 20) = InterpSpeed;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CInterpTo, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static void BreakVector_NetQuantizeNormal(FVector_NetQuantizeNormal InVec, ref double X, ref double Y, ref double Z)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InVec?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = X;

				*(double*)(__InBuffer + 16) = Y;

				*(double*)(__InBuffer + 24) = Z;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakVector_NetQuantizeNormal, __InBuffer, __OutBuffer);

				X = *(double*)(__OutBuffer);

				Y = *(double*)(__OutBuffer + 8);

				Z = *(double*)(__OutBuffer + 16);

			}
		}

		public static void BreakVector_NetQuantize100(FVector_NetQuantize100 InVec, ref double X, ref double Y, ref double Z)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InVec?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = X;

				*(double*)(__InBuffer + 16) = Y;

				*(double*)(__InBuffer + 24) = Z;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakVector_NetQuantize100, __InBuffer, __OutBuffer);

				X = *(double*)(__OutBuffer);

				Y = *(double*)(__OutBuffer + 8);

				Z = *(double*)(__OutBuffer + 16);

			}
		}

		public static void BreakVector_NetQuantize10(FVector_NetQuantize10 InVec, ref double X, ref double Y, ref double Z)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InVec?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = X;

				*(double*)(__InBuffer + 16) = Y;

				*(double*)(__InBuffer + 24) = Z;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakVector_NetQuantize10, __InBuffer, __OutBuffer);

				X = *(double*)(__OutBuffer);

				Y = *(double*)(__OutBuffer + 8);

				Z = *(double*)(__OutBuffer + 16);

			}
		}

		public static void BreakVector_NetQuantize(FVector_NetQuantize InVec, ref double X, ref double Y, ref double Z)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InVec?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = X;

				*(double*)(__InBuffer + 16) = Y;

				*(double*)(__InBuffer + 24) = Z;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakVector_NetQuantize, __InBuffer, __OutBuffer);

				X = *(double*)(__OutBuffer);

				Y = *(double*)(__OutBuffer + 8);

				Z = *(double*)(__OutBuffer + 16);

			}
		}

		public static void BreakVector4(FVector4 InVec, ref double X, ref double Y, ref double Z, ref double W)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = InVec?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = X;

				*(double*)(__InBuffer + 16) = Y;

				*(double*)(__InBuffer + 24) = Z;

				*(double*)(__InBuffer + 32) = W;

				var __OutBuffer = stackalloc byte[32];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakVector4, __InBuffer, __OutBuffer);

				X = *(double*)(__OutBuffer);

				Y = *(double*)(__OutBuffer + 8);

				Z = *(double*)(__OutBuffer + 16);

				W = *(double*)(__OutBuffer + 24);

			}
		}

		public static void BreakVector2D(FVector2D InVec, ref double X, ref double Y)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InVec?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = X;

				*(double*)(__InBuffer + 16) = Y;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakVector2D, __InBuffer, __OutBuffer);

				X = *(double*)(__OutBuffer);

				Y = *(double*)(__OutBuffer + 8);

			}
		}

		public static void BreakVector(FVector InVec, ref double X, ref double Y, ref double Z)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InVec?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = X;

				*(double*)(__InBuffer + 16) = Y;

				*(double*)(__InBuffer + 24) = Z;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakVector, __InBuffer, __OutBuffer);

				X = *(double*)(__OutBuffer);

				Y = *(double*)(__OutBuffer + 8);

				Z = *(double*)(__OutBuffer + 16);

			}
		}

		public static void BreakTransform(FTransform InTransform, ref FVector Location, ref FRotator Rotation, ref FVector Scale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Scale?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakTransform, __InBuffer, __OutBuffer);

				Location = *(FVector*)(__OutBuffer);

				Rotation = *(FRotator*)(__OutBuffer + 8);

				Scale = *(FVector*)(__OutBuffer + 16);

			}
		}

		public static void BreakTimespan2(FTimespan InTimespan, ref int Days, ref int Hours, ref int Minutes, ref int Seconds, ref int FractionNano)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = InTimespan?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Days;

				*(int*)(__InBuffer + 12) = Hours;

				*(int*)(__InBuffer + 16) = Minutes;

				*(int*)(__InBuffer + 20) = Seconds;

				*(int*)(__InBuffer + 24) = FractionNano;

				var __OutBuffer = stackalloc byte[20];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakTimespan2, __InBuffer, __OutBuffer);

				Days = *(int*)(__OutBuffer);

				Hours = *(int*)(__OutBuffer + 4);

				Minutes = *(int*)(__OutBuffer + 8);

				Seconds = *(int*)(__OutBuffer + 12);

				FractionNano = *(int*)(__OutBuffer + 16);

			}
		}

		public static void BreakTimespan(FTimespan InTimespan, ref int Days, ref int Hours, ref int Minutes, ref int Seconds, ref int Milliseconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = InTimespan?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Days;

				*(int*)(__InBuffer + 12) = Hours;

				*(int*)(__InBuffer + 16) = Minutes;

				*(int*)(__InBuffer + 20) = Seconds;

				*(int*)(__InBuffer + 24) = Milliseconds;

				var __OutBuffer = stackalloc byte[20];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakTimespan, __InBuffer, __OutBuffer);

				Days = *(int*)(__OutBuffer);

				Hours = *(int*)(__OutBuffer + 4);

				Minutes = *(int*)(__OutBuffer + 8);

				Seconds = *(int*)(__OutBuffer + 12);

				Milliseconds = *(int*)(__OutBuffer + 16);

			}
		}

		public static void BreakRotIntoAxes(FRotator InRot, ref FVector X, ref FVector Y, ref FVector Z)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InRot?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = X?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Y?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Z?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakRotIntoAxes, __InBuffer, __OutBuffer);

				X = *(FVector*)(__OutBuffer);

				Y = *(FVector*)(__OutBuffer + 8);

				Z = *(FVector*)(__OutBuffer + 16);

			}
		}

		public static void BreakRotator(FRotator InRot, ref float Roll, ref float Pitch, ref float Yaw)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InRot?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Roll;

				*(float*)(__InBuffer + 12) = Pitch;

				*(float*)(__InBuffer + 16) = Yaw;

				var __OutBuffer = stackalloc byte[12];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakRotator, __InBuffer, __OutBuffer);

				Roll = *(float*)(__OutBuffer);

				Pitch = *(float*)(__OutBuffer + 4);

				Yaw = *(float*)(__OutBuffer + 8);

			}
		}

		public static void BreakRandomStream(FRandomStream InRandomStream, ref int InitialSeed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InRandomStream?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InitialSeed;

				var __OutBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakRandomStream, __InBuffer, __OutBuffer);

				InitialSeed = *(int*)(__OutBuffer);

			}
		}

		public static void BreakQuat(FQuat InQuat, ref float X, ref float Y, ref float Z, ref float W)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InQuat?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = X;

				*(float*)(__InBuffer + 12) = Y;

				*(float*)(__InBuffer + 16) = Z;

				*(float*)(__InBuffer + 20) = W;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakQuat, __InBuffer, __OutBuffer);

				X = *(float*)(__OutBuffer);

				Y = *(float*)(__OutBuffer + 4);

				Z = *(float*)(__OutBuffer + 8);

				W = *(float*)(__OutBuffer + 12);

			}
		}

		public static void BreakQualifiedFrameTime(FQualifiedFrameTime InFrameTime, ref FFrameNumber Frame, ref FFrameRate FrameRate, ref float SubFrame)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = InFrameTime?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = FrameRate?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = SubFrame;

				var __OutBuffer = stackalloc byte[20];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakQualifiedFrameTime, __InBuffer, __OutBuffer);

				Frame = *(FFrameNumber*)(__OutBuffer);

				FrameRate = *(FFrameRate*)(__OutBuffer + 8);

				SubFrame = *(float*)(__OutBuffer + 16);

			}
		}

		public static void BreakFrameRate(FFrameRate InFrameRate, ref int Numerator, ref int Denominator)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InFrameRate?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Numerator;

				*(int*)(__InBuffer + 12) = Denominator;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakFrameRate, __InBuffer, __OutBuffer);

				Numerator = *(int*)(__OutBuffer);

				Denominator = *(int*)(__OutBuffer + 4);

			}
		}

		public static void BreakDateTime(FDateTime InDateTime, ref int Year, ref int Month, ref int Day, ref int Hour, ref int Minute, ref int Second, ref int Millisecond)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = InDateTime?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Year;

				*(int*)(__InBuffer + 12) = Month;

				*(int*)(__InBuffer + 16) = Day;

				*(int*)(__InBuffer + 20) = Hour;

				*(int*)(__InBuffer + 24) = Minute;

				*(int*)(__InBuffer + 28) = Second;

				*(int*)(__InBuffer + 32) = Millisecond;

				var __OutBuffer = stackalloc byte[28];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakDateTime, __InBuffer, __OutBuffer);

				Year = *(int*)(__OutBuffer);

				Month = *(int*)(__OutBuffer + 4);

				Day = *(int*)(__OutBuffer + 8);

				Hour = *(int*)(__OutBuffer + 12);

				Minute = *(int*)(__OutBuffer + 16);

				Second = *(int*)(__OutBuffer + 20);

				Millisecond = *(int*)(__OutBuffer + 24);

			}
		}

		public static void BreakColor(FLinearColor InColor, ref float R, ref float G, ref float B, ref float A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = R;

				*(float*)(__InBuffer + 12) = G;

				*(float*)(__InBuffer + 16) = B;

				*(float*)(__InBuffer + 20) = A;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakColor, __InBuffer, __OutBuffer);

				R = *(float*)(__OutBuffer);

				G = *(float*)(__OutBuffer + 4);

				B = *(float*)(__OutBuffer + 8);

				A = *(float*)(__OutBuffer + 12);

			}
		}

		public static void BreakBoxSphereBounds(FBoxSphereBounds InBoxSphereBounds, ref FVector Origin, ref FVector BoxExtent, ref float SphereRadius)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = InBoxSphereBounds?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BoxExtent?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = SphereRadius;

				var __OutBuffer = stackalloc byte[20];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakBoxSphereBounds, __InBuffer, __OutBuffer);

				Origin = *(FVector*)(__OutBuffer);

				BoxExtent = *(FVector*)(__OutBuffer + 8);

				SphereRadius = *(float*)(__OutBuffer + 16);

			}
		}

		public static bool BooleanXOR(bool A, bool B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = A;

				*(bool*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __BooleanXOR, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool BooleanOR(bool A, bool B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = A;

				*(bool*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __BooleanOR, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool BooleanNOR(bool A, bool B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = A;

				*(bool*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __BooleanNOR, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool BooleanNAND(bool A, bool B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = A;

				*(bool*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __BooleanNAND, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool BooleanAND(bool A, bool B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = A;

				*(bool*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __BooleanAND, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static byte BMin(byte A, byte B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = A;

				*(byte*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __BMin, __InBuffer, __ReturnBuffer);

				return *(byte*)__ReturnBuffer;
			}
		}

		public static byte BMax(byte A, byte B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = A;

				*(byte*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __BMax, __InBuffer, __ReturnBuffer);

				return *(byte*)__ReturnBuffer;
			}
		}

		public static void AverageOfIntArray(TArray<int> IntArray, ref float AverageValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = IntArray?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = AverageValue;

				var __OutBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __AverageOfIntArray, __InBuffer, __OutBuffer);

				AverageValue = *(float*)(__OutBuffer);

			}
		}

		public static double Atan2(double Y, double X)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = Y;

				*(double*)(__InBuffer + 8) = X;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Atan2, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double Atan(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Atan, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static double Asin(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Asin, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static int And_IntInt(int A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = A;

				*(int*)(__InBuffer + 4) = B;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __And_IntInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static long And_Int64Int64(long A, long B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(long*)(__InBuffer) = A;

				*(long*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __And_Int64Int64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static FVector Add_VectorVector(FVector A, FVector B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_VectorVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Add_VectorInt(FVector A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_VectorInt, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector Add_VectorFloat(FVector A, double B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_VectorFloat, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector4 Add_Vector4Vector4(FVector4 A, FVector4 B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_Vector4Vector4, __InBuffer, __ReturnBuffer);

				return *(FVector4*)__ReturnBuffer;
			}
		}

		public static FVector2D Add_Vector2DVector2D(FVector2D A, FVector2D B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_Vector2DVector2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FVector2D Add_Vector2DFloat(FVector2D A, double B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_Vector2DFloat, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FTimespan Add_TimespanTimespan(FTimespan A, FTimespan B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_TimespanTimespan, __InBuffer, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		public static FQuat Add_QuatQuat(FQuat A, FQuat B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_QuatQuat, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		/// <param name="Other">
		/// The Matrix to add.
		/// </param>
		/// <returns>
		/// The result of addition.
		/// </returns>
		public static FMatrix Add_MatrixMatrix(FMatrix A, FMatrix B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_MatrixMatrix, __InBuffer, __ReturnBuffer);

				return *(FMatrix*)__ReturnBuffer;
			}
		}

		public static FLinearColor Add_LinearColorLinearColor(FLinearColor A, FLinearColor B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_LinearColorLinearColor, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static FIntPoint Add_IntPointIntPoint(FIntPoint A, FIntPoint B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_IntPointIntPoint, __InBuffer, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public static FIntPoint Add_IntPointInt(FIntPoint A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_IntPointInt, __InBuffer, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public static int Add_IntInt(int A, int B = 1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = A;

				*(int*)(__InBuffer + 4) = B;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_IntInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static long Add_Int64Int64(long A, long B = 1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(long*)(__InBuffer) = A;

				*(long*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_Int64Int64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static double Add_DoubleDouble(double A, double B = 1.000000)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(double*)(__InBuffer) = A;

				*(double*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_DoubleDouble, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FDateTime Add_DateTimeTimespan(FDateTime A, FTimespan B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_DateTimeTimespan, __InBuffer, __ReturnBuffer);

				return *(FDateTime*)__ReturnBuffer;
			}
		}

		public static FDateTime Add_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_DateTimeDateTime, __InBuffer, __ReturnBuffer);

				return *(FDateTime*)__ReturnBuffer;
			}
		}

		public static byte Add_ByteByte(byte A, byte B = 1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = A;

				*(byte*)(__InBuffer + 1) = B;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_ByteByte, __InBuffer, __ReturnBuffer);

				return *(byte*)__ReturnBuffer;
			}
		}

		public static double Acos(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Acos, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static long Abs_Int64(long A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(long*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Abs_Int64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static int Abs_Int(int A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Abs_Int, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static double Abs(double A)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = A;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Abs, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		private static uint __Xor_IntInt = 0;

		private static uint __Xor_Int64Int64 = 0;

		private static uint __Wrap = 0;

		private static uint __WeightedMovingAverage_FVector = 0;

		private static uint __WeightedMovingAverage_FRotator = 0;

		private static uint __WeightedMovingAverage_Float = 0;

		private static uint __VSizeXYSquared = 0;

		private static uint __VSizeXY = 0;

		private static uint __VSizeSquared = 0;

		private static uint __VSize2DSquared = 0;

		private static uint __VSize2D = 0;

		private static uint __VSize = 0;

		private static uint __VLerp = 0;

		private static uint __VInterpTo_Constant = 0;

		private static uint __VInterpTo = 0;

		private static uint __VectorSpringInterp = 0;

		private static uint __Vector_Zero = 0;

		private static uint __Vector_Up = 0;

		private static uint __Vector_UnwindEuler = 0;

		private static uint __Vector_UnitCartesianToSpherical = 0;

		private static uint __Vector_ToRadians = 0;

		private static uint __Vector_ToDegrees = 0;

		private static uint __Vector_SnappedToGrid = 0;

		private static uint __Vector_SlerpVectorToDirection = 0;

		private static uint __Vector_SlerpNormals = 0;

		private static uint __Vector_Set = 0;

		private static uint __Vector_Right = 0;

		private static uint __Vector_Reciprocal = 0;

		private static uint __Vector_ProjectOnToNormal = 0;

		private static uint __Vector_One = 0;

		private static uint __Vector_NormalUnsafe = 0;

		private static uint __Vector_Normalize = 0;

		private static uint __Vector_Normal2D = 0;

		private static uint __Vector_MirrorByPlane = 0;

		private static uint __Vector_Left = 0;

		private static uint __Vector_IsZero = 0;

		private static uint __Vector_IsUnit = 0;

		private static uint __Vector_IsUniform = 0;

		private static uint __Vector_IsNormal = 0;

		private static uint __Vector_IsNearlyZero = 0;

		private static uint __Vector_IsNAN = 0;

		private static uint __Vector_HeadingAngle = 0;

		private static uint __Vector_GetSignVector = 0;

		private static uint __Vector_GetProjection = 0;

		private static uint __Vector_GetAbsMin = 0;

		private static uint __Vector_GetAbsMax = 0;

		private static uint __Vector_GetAbs = 0;

		private static uint __Vector_Forward = 0;

		private static uint __Vector_Down = 0;

		private static uint __Vector_DistanceSquared = 0;

		private static uint __Vector_Distance2DSquared = 0;

		private static uint __Vector_Distance2D = 0;

		private static uint __Vector_Distance = 0;

		private static uint __Vector_CosineAngle2D = 0;

		private static uint __Vector_ComponentMin = 0;

		private static uint __Vector_ComponentMax = 0;

		private static uint __Vector_ClampSizeMax2D = 0;

		private static uint __Vector_ClampSizeMax = 0;

		private static uint __Vector_ClampSize2D = 0;

		private static uint __Vector_BoundedToCube = 0;

		private static uint __Vector_BoundedToBox = 0;

		private static uint __Vector_Backward = 0;

		private static uint __Vector_Assign = 0;

		private static uint __Vector_AddBounded = 0;

		private static uint __Vector4_Zero = 0;

		private static uint __Vector4_SizeSquared3 = 0;

		private static uint __Vector4_SizeSquared = 0;

		private static uint __Vector4_Size3 = 0;

		private static uint __Vector4_Size = 0;

		private static uint __Vector4_Set = 0;

		private static uint __Vector4_NormalUnsafe3 = 0;

		private static uint __Vector4_Normalize3 = 0;

		private static uint __Vector4_Normal3 = 0;

		private static uint __Vector4_Negated = 0;

		private static uint __Vector4_MirrorByVector3 = 0;

		private static uint __Vector4_IsZero = 0;

		private static uint __Vector4_IsUnit3 = 0;

		private static uint __Vector4_IsNormal3 = 0;

		private static uint __Vector4_IsNearlyZero3 = 0;

		private static uint __Vector4_IsNAN = 0;

		private static uint __Vector4_DotProduct3 = 0;

		private static uint __Vector4_DotProduct = 0;

		private static uint __Vector4_CrossProduct3 = 0;

		private static uint __Vector4_Assign = 0;

		private static uint __Vector2DInterpTo_Constant = 0;

		private static uint __Vector2DInterpTo = 0;

		private static uint __Vector2D_Zero = 0;

		private static uint __Vector2D_Unit45Deg = 0;

		private static uint __Vector2D_One = 0;

		private static uint __VEase = 0;

		private static uint __UtcNow = 0;

		private static uint __TransformVector4 = 0;

		private static uint __TransformRotation = 0;

		private static uint __TransformLocation = 0;

		private static uint __TransformDirection = 0;

		private static uint __Transform_Determinant = 0;

		private static uint __ToUnixTimestampDouble = 0;

		private static uint __ToUnixTimestamp = 0;

		private static uint __ToSign2D = 0;

		private static uint __ToRounded2D = 0;

		private static uint __ToHex_LinearColor = 0;

		private static uint __ToDirectionAndLength2D = 0;

		private static uint __Today = 0;

		private static uint __TLerp = 0;

		private static uint __TInterpTo = 0;

		private static uint __TimespanZeroValue = 0;

		private static uint __TimespanRatio = 0;

		private static uint __TimespanMinValue = 0;

		private static uint __TimespanMaxValue = 0;

		private static uint __TimespanFromString = 0;

		private static uint __TEase = 0;

		private static uint __Tan = 0;

		private static uint __Subtract_VectorVector = 0;

		private static uint __Subtract_VectorInt = 0;

		private static uint __Subtract_VectorFloat = 0;

		private static uint __Subtract_Vector4Vector4 = 0;

		private static uint __Subtract_Vector2DVector2D = 0;

		private static uint __Subtract_Vector2DFloat = 0;

		private static uint __Subtract_TimespanTimespan = 0;

		private static uint __Subtract_QuatQuat = 0;

		private static uint __Subtract_LinearColorLinearColor = 0;

		private static uint __Subtract_IntPointIntPoint = 0;

		private static uint __Subtract_IntPointInt = 0;

		private static uint __Subtract_IntInt = 0;

		private static uint __Subtract_Int64Int64 = 0;

		private static uint __Subtract_DoubleDouble = 0;

		private static uint __Subtract_DateTimeTimespan = 0;

		private static uint __Subtract_DateTimeDateTime = 0;

		private static uint __Subtract_ByteByte = 0;

		private static uint __Square = 0;

		private static uint __Sqrt = 0;

		private static uint __Spherical2DToUnitCartesian = 0;

		private static uint __Sin = 0;

		private static uint __SignOfInteger64 = 0;

		private static uint __SignOfInteger = 0;

		private static uint __SignOfFloat = 0;

		private static uint __SetVectorSpringStateVelocity = 0;

		private static uint __SetRandomStreamSeed = 0;

		private static uint __SetQuaternionSpringStateAngularVelocity = 0;

		private static uint __SetFloatSpringStateVelocity = 0;

		private static uint __Set2D = 0;

		private static uint __SelectVector = 0;

		private static uint __SelectTransform = 0;

		private static uint __SelectString = 0;

		private static uint __SelectRotator = 0;

		private static uint __SelectObject = 0;

		private static uint __SelectInt = 0;

		private static uint __SelectFloat = 0;

		private static uint __SelectColor = 0;

		private static uint __SelectClass = 0;

		private static uint __SeedRandomStream = 0;

		private static uint __SafeDivide = 0;

		private static uint __Round64 = 0;

		private static uint __Round = 0;

		private static uint __RotatorFromAxisAndAngle = 0;

		private static uint __RotateAngleAxis = 0;

		private static uint __RLerp = 0;

		private static uint __RInterpTo_Constant = 0;

		private static uint __RInterpTo = 0;

		private static uint __RGBToHSV_Vector = 0;

		private static uint __RGBToHSV = 0;

		private static uint __RGBLinearToHSV = 0;

		private static uint __ResetVectorSpringState = 0;

		private static uint __ResetRandomStream = 0;

		private static uint __ResetQuaternionSpringState = 0;

		private static uint __ResetFloatSpringState = 0;

		private static uint __REase = 0;

		private static uint __RandomUnitVectorInEllipticalConeInRadiansFromStream = 0;

		private static uint __RandomUnitVectorInEllipticalConeInRadians = 0;

		private static uint __RandomUnitVectorInEllipticalConeInDegreesFromStream = 0;

		private static uint __RandomUnitVectorInEllipticalConeInDegrees = 0;

		private static uint __RandomUnitVectorInConeInRadiansFromStream = 0;

		private static uint __RandomUnitVectorInConeInRadians = 0;

		private static uint __RandomUnitVectorInConeInDegreesFromStream = 0;

		private static uint __RandomUnitVectorInConeInDegrees = 0;

		private static uint __RandomUnitVectorFromStream = 0;

		private static uint __RandomUnitVector = 0;

		private static uint __RandomRotatorFromStream = 0;

		private static uint __RandomRotator = 0;

		private static uint __RandomPointInBoundingBoxFromStream_Box = 0;

		private static uint __RandomPointInBoundingBoxFromStream = 0;

		private static uint __RandomPointInBoundingBox_Box = 0;

		private static uint __RandomPointInBoundingBox = 0;

		private static uint __RandomIntegerInRangeFromStream = 0;

		private static uint __RandomIntegerInRange = 0;

		private static uint __RandomIntegerFromStream = 0;

		private static uint __RandomInteger64InRange = 0;

		private static uint __RandomInteger64 = 0;

		private static uint __RandomInteger = 0;

		private static uint __RandomFloatInRangeFromStream = 0;

		private static uint __RandomFloatInRange = 0;

		private static uint __RandomFloatFromStream = 0;

		private static uint __RandomFloat = 0;

		private static uint __RandomBoolWithWeightFromStream = 0;

		private static uint __RandomBoolWithWeight = 0;

		private static uint __RandomBoolFromStream = 0;

		private static uint __RandomBool = 0;

		private static uint __RadiansToDegrees = 0;

		private static uint __QuaternionSpringInterp = 0;

		private static uint __Quat_VectorUp = 0;

		private static uint __Quat_VectorRight = 0;

		private static uint __Quat_VectorForward = 0;

		private static uint __Quat_UnrotateVector = 0;

		private static uint __Quat_Slerp = 0;

		private static uint __Quat_SizeSquared = 0;

		private static uint __Quat_Size = 0;

		private static uint __Quat_SetFromEuler = 0;

		private static uint __Quat_SetComponents = 0;

		private static uint __Quat_Rotator = 0;

		private static uint __Quat_RotateVector = 0;

		private static uint __Quat_Normalized = 0;

		private static uint __Quat_Normalize = 0;

		private static uint __Quat_MakeFromEuler = 0;

		private static uint __Quat_Log = 0;

		private static uint __Quat_IsNormalized = 0;

		private static uint __Quat_IsNonFinite = 0;

		private static uint __Quat_IsIdentity = 0;

		private static uint __Quat_IsFinite = 0;

		private static uint __Quat_Inversed = 0;

		private static uint __Quat_Identity = 0;

		private static uint __Quat_GetRotationAxis = 0;

		private static uint __Quat_GetAxisZ = 0;

		private static uint __Quat_GetAxisY = 0;

		private static uint __Quat_GetAxisX = 0;

		private static uint __Quat_GetAngle = 0;

		private static uint __Quat_FindBetweenVectors = 0;

		private static uint __Quat_FindBetweenNormals = 0;

		private static uint __Quat_Exp = 0;

		private static uint __Quat_Euler = 0;

		private static uint __Quat_EnforceShortestArcWith = 0;

		private static uint __Quat_AngularDistance = 0;

		private static uint __ProjectVectorOnToVector = 0;

		private static uint __ProjectVectorOnToPlane = 0;

		private static uint __ProjectPointOnToPlane = 0;

		private static uint __PointsAreCoplanar = 0;

		private static uint __PerlinNoise1D = 0;

		private static uint __Percent_IntInt = 0;

		private static uint __Percent_Int64Int64 = 0;

		private static uint __Percent_FloatFloat = 0;

		private static uint __Percent_ByteByte = 0;

		private static uint __Or_IntInt = 0;

		private static uint __Or_Int64Int64 = 0;

		private static uint __Now = 0;

		private static uint __NotEqualExactly_VectorVector = 0;

		private static uint __NotEqualExactly_Vector4Vector4 = 0;

		private static uint __NotEqualExactly_Vector2DVector2D = 0;

		private static uint __NotEqual_VectorVector = 0;

		private static uint __NotEqual_Vector4Vector4 = 0;

		private static uint __NotEqual_Vector2DVector2D = 0;

		private static uint __NotEqual_TimespanTimespan = 0;

		private static uint __NotEqual_RotatorRotator = 0;

		private static uint __NotEqual_QuatQuat = 0;

		private static uint __NotEqual_ObjectObject = 0;

		private static uint __NotEqual_NameName = 0;

		private static uint __NotEqual_MatrixMatrix = 0;

		private static uint __NotEqual_LinearColorLinearColor = 0;

		private static uint __NotEqual_IntPointIntPoint = 0;

		private static uint __NotEqual_IntInt = 0;

		private static uint __NotEqual_Int64Int64 = 0;

		private static uint __NotEqual_DoubleDouble = 0;

		private static uint __NotEqual_DateTimeDateTime = 0;

		private static uint __NotEqual_ClassClass = 0;

		private static uint __NotEqual_ByteByte = 0;

		private static uint __NotEqual_BoolBool = 0;

		private static uint __Not_PreBool = 0;

		private static uint __Not_Int64 = 0;

		private static uint __Not_Int = 0;

		private static uint __NormalSafe2D = 0;

		private static uint __NormalizeToRange = 0;

		private static uint __NormalizedDeltaRotator = 0;

		private static uint __NormalizeAxis = 0;

		private static uint __Normalize2D = 0;

		private static uint __Normal2D = 0;

		private static uint __Normal = 0;

		private static uint __NegateVector = 0;

		private static uint __NegateRotator = 0;

		private static uint __Negated2D = 0;

		private static uint __NearlyEqual_TransformTransform = 0;

		private static uint __NearlyEqual_FloatFloat = 0;

		private static uint __MultiplyMultiply_FloatFloat = 0;

		private static uint __MultiplyByPi = 0;

		private static uint __Multiply_VectorVector = 0;

		private static uint __Multiply_VectorInt = 0;

		private static uint __Multiply_VectorFloat = 0;

		private static uint __Multiply_Vector4Vector4 = 0;

		private static uint __Multiply_Vector2DVector2D = 0;

		private static uint __Multiply_Vector2DFloat = 0;

		private static uint __Multiply_TimespanFloat = 0;

		private static uint __Multiply_RotatorInt = 0;

		private static uint __Multiply_RotatorFloat = 0;

		private static uint __Multiply_QuatQuat = 0;

		private static uint __Multiply_MatrixMatrix = 0;

		private static uint __Multiply_MatrixFloat = 0;

		private static uint __Multiply_LinearColorLinearColor = 0;

		private static uint __Multiply_LinearColorFloat = 0;

		private static uint __Multiply_IntPointIntPoint = 0;

		private static uint __Multiply_IntPointInt = 0;

		private static uint __Multiply_IntInt = 0;

		private static uint __Multiply_IntFloat = 0;

		private static uint __Multiply_Int64Int64 = 0;

		private static uint __Multiply_DoubleDouble = 0;

		private static uint __Multiply_ByteByte = 0;

		private static uint __MirrorVectorByNormal = 0;

		private static uint __MinOfIntArray = 0;

		private static uint __MinOfFloatArray = 0;

		private static uint __MinOfByteArray = 0;

		private static uint __MinInt64 = 0;

		private static uint __MinimumAreaRectangle = 0;

		private static uint __MinAreaRectangle = 0;

		private static uint __Min = 0;

		private static uint __MedianOfIntArray = 0;

		private static uint __MaxOfIntArray = 0;

		private static uint __MaxOfFloatArray = 0;

		private static uint __MaxOfByteArray = 0;

		private static uint __MaxInt64 = 0;

		private static uint __Max = 0;

		private static uint __Matrix_TransformVector4 = 0;

		private static uint __Matrix_TransformVector = 0;

		private static uint __Matrix_TransformPosition = 0;

		private static uint __Matrix_ToQuat = 0;

		private static uint __Matrix_SetOrigin = 0;

		private static uint __Matrix_SetColumn = 0;

		private static uint __Matrix_SetAxis = 0;

		private static uint __Matrix_ScaleTranslation = 0;

		private static uint __Matrix_RemoveTranslation = 0;

		private static uint __Matrix_RemoveScaling = 0;

		private static uint __Matrix_Mirror = 0;

		private static uint __Matrix_InverseTransformVector = 0;

		private static uint __Matrix_InverseTransformPosition = 0;

		private static uint __Matrix_Identity = 0;

		private static uint __Matrix_GetUnitAxis = 0;

		private static uint __Matrix_GetUnitAxes = 0;

		private static uint __Matrix_GetTransposed = 0;

		private static uint __Matrix_GetTransposeAdjoint = 0;

		private static uint __Matrix_GetScaleVector = 0;

		private static uint __Matrix_GetScaledAxis = 0;

		private static uint __Matrix_GetScaledAxes = 0;

		private static uint __Matrix_GetRotDeterminant = 0;

		private static uint __Matrix_GetRotator = 0;

		private static uint __Matrix_GetOrigin = 0;

		private static uint __Matrix_GetMaximumAxisScale = 0;

		private static uint __Matrix_GetMatrixWithoutScale = 0;

		private static uint __Matrix_GetInverse = 0;

		private static uint __Matrix_GetFrustumTopPlane = 0;

		private static uint __Matrix_GetFrustumRightPlane = 0;

		private static uint __Matrix_GetFrustumNearPlane = 0;

		private static uint __Matrix_GetFrustumLeftPlane = 0;

		private static uint __Matrix_GetFrustumFarPlane = 0;

		private static uint __Matrix_GetFrustumBottomPlane = 0;

		private static uint __Matrix_GetDeterminant = 0;

		private static uint __Matrix_GetColumn = 0;

		private static uint __Matrix_ContainsNaN = 0;

		private static uint __Matrix_ConcatenateTranslation = 0;

		private static uint __Matrix_ApplyScale = 0;

		private static uint __MapRangeUnclamped = 0;

		private static uint __MapRangeClamped = 0;

		private static uint __MakeVector_NetQuantizeNormal = 0;

		private static uint __MakeVector_NetQuantize100 = 0;

		private static uint __MakeVector_NetQuantize10 = 0;

		private static uint __MakeVector_NetQuantize = 0;

		private static uint __MakeVector4 = 0;

		private static uint __MakeVector2D = 0;

		private static uint __MakeVector = 0;

		private static uint __MakeTransform = 0;

		private static uint __MakeTimespan2 = 0;

		private static uint __MakeTimespan = 0;

		private static uint __MakeRotFromZY = 0;

		private static uint __MakeRotFromZX = 0;

		private static uint __MakeRotFromZ = 0;

		private static uint __MakeRotFromYZ = 0;

		private static uint __MakeRotFromYX = 0;

		private static uint __MakeRotFromY = 0;

		private static uint __MakeRotFromXZ = 0;

		private static uint __MakeRotFromXY = 0;

		private static uint __MakeRotFromX = 0;

		private static uint __MakeRotator = 0;

		private static uint __MakeRotationFromAxes = 0;

		private static uint __MakeRelativeTransform = 0;

		private static uint __MakeRandomStream = 0;

		private static uint __MakeQuat = 0;

		private static uint __MakeQualifiedFrameTime = 0;

		private static uint __MakePulsatingValue = 0;

		private static uint __MakePlaneFromPointAndNormal = 0;

		private static uint __MakeFrameRate = 0;

		private static uint __MakeDateTime = 0;

		private static uint __MakeColor = 0;

		private static uint __MakeBoxSphereBounds = 0;

		private static uint __MakeBox2D = 0;

		private static uint __MakeBox = 0;

		private static uint __Loge = 0;

		private static uint __Log = 0;

		private static uint __LinePlaneIntersection_OriginNormal = 0;

		private static uint __LinePlaneIntersection = 0;

		private static uint __LinearColorLerpUsingHSV = 0;

		private static uint __LinearColorLerp = 0;

		private static uint __LinearColor_Yellow = 0;

		private static uint __LinearColor_White = 0;

		private static uint __LinearColor_Transparent = 0;

		private static uint __LinearColor_ToRGBE = 0;

		private static uint __LinearColor_ToNewOpacity = 0;

		private static uint __LinearColor_SetTemperature = 0;

		private static uint __LinearColor_SetRGBA = 0;

		private static uint __LinearColor_SetRandomHue = 0;

		private static uint __LinearColor_SetFromSRGB = 0;

		private static uint __LinearColor_SetFromPow22 = 0;

		private static uint __LinearColor_SetFromHSV = 0;

		private static uint __LinearColor_Set = 0;

		private static uint __LinearColor_Red = 0;

		private static uint __LinearColor_QuantizeRound = 0;

		private static uint __LinearColor_Quantize = 0;

		private static uint __LinearColor_IsNearEqual = 0;

		private static uint __LinearColor_Green = 0;

		private static uint __LinearColor_Gray = 0;

		private static uint __LinearColor_GetMin = 0;

		private static uint __LinearColor_GetMax = 0;

		private static uint __LinearColor_GetLuminance = 0;

		private static uint __LinearColor_Distance = 0;

		private static uint __LinearColor_Desaturated = 0;

		private static uint __LinearColor_Blue = 0;

		private static uint __LinearColor_Black = 0;

		private static uint __LessLess_VectorRotator = 0;

		private static uint __LessEqual_TimespanTimespan = 0;

		private static uint __LessEqual_IntInt = 0;

		private static uint __LessEqual_Int64Int64 = 0;

		private static uint __LessEqual_DoubleDouble = 0;

		private static uint __LessEqual_DateTimeDateTime = 0;

		private static uint __LessEqual_ByteByte = 0;

		private static uint __Less_TimespanTimespan = 0;

		private static uint __Less_IntInt = 0;

		private static uint __Less_Int64Int64 = 0;

		private static uint __Less_DoubleDouble = 0;

		private static uint __Less_DateTimeDateTime = 0;

		private static uint __Less_ByteByte = 0;

		private static uint __Lerp = 0;

		private static uint __IsZero2D = 0;

		private static uint __IsPointInBoxWithTransform_Box = 0;

		private static uint __IsPointInBoxWithTransform = 0;

		private static uint __IsPointInBox_Box = 0;

		private static uint __IsPointInBox = 0;

		private static uint __IsNearlyZero2D = 0;

		private static uint __IsMorning = 0;

		private static uint __IsLeapYear = 0;

		private static uint __IsAfternoon = 0;

		private static uint __InvertTransform = 0;

		private static uint __InverseTransformRotation = 0;

		private static uint __InverseTransformLocation = 0;

		private static uint __InverseTransformDirection = 0;

		private static uint __IntPoint_Zero = 0;

		private static uint __IntPoint_Up = 0;

		private static uint __IntPoint_Right = 0;

		private static uint __IntPoint_One = 0;

		private static uint __IntPoint_Left = 0;

		private static uint __IntPoint_Down = 0;

		private static uint __InRange_IntInt = 0;

		private static uint __InRange_Int64Int64 = 0;

		private static uint __InRange_FloatFloat = 0;

		private static uint __Hypotenuse = 0;

		private static uint __HSVToRGBLinear = 0;

		private static uint __HSVToRGB_Vector = 0;

		private static uint __HSVToRGB = 0;

		private static uint __GridSnap_Float = 0;

		private static uint __GreaterGreater_VectorRotator = 0;

		private static uint __GreaterEqual_TimespanTimespan = 0;

		private static uint __GreaterEqual_IntInt = 0;

		private static uint __GreaterEqual_Int64Int64 = 0;

		private static uint __GreaterEqual_DoubleDouble = 0;

		private static uint __GreaterEqual_DateTimeDateTime = 0;

		private static uint __GreaterEqual_ByteByte = 0;

		private static uint __Greater_TimespanTimespan = 0;

		private static uint __Greater_IntInt = 0;

		private static uint __Greater_Int64Int64 = 0;

		private static uint __Greater_DoubleDouble = 0;

		private static uint __Greater_DateTimeDateTime = 0;

		private static uint __Greater_ByteByte = 0;

		private static uint __GetYear = 0;

		private static uint __GetYawPitchFromVector = 0;

		private static uint __GetVectorArrayAverage = 0;

		private static uint __GetUpVector = 0;

		private static uint __GetTotalSeconds = 0;

		private static uint __GetTotalMinutes = 0;

		private static uint __GetTotalMilliseconds = 0;

		private static uint __GetTotalHours = 0;

		private static uint __GetTotalDays = 0;

		private static uint __GetTimeOfDay = 0;

		private static uint __GetTAU = 0;

		private static uint __GetSlopeDegreeAngles = 0;

		private static uint __GetSeconds = 0;

		private static uint __GetSecond = 0;

		private static uint __GetRotated2D = 0;

		private static uint __GetRightVector = 0;

		private static uint __GetReflectionVector = 0;

		private static uint __GetPointDistanceToSegment = 0;

		private static uint __GetPointDistanceToLine = 0;

		private static uint __GetPI = 0;

		private static uint __GetMonth = 0;

		private static uint __GetMinutes = 0;

		private static uint __GetMinute = 0;

		private static uint __GetMinElement = 0;

		private static uint __GetMin2D = 0;

		private static uint __GetMilliseconds = 0;

		private static uint __GetMillisecond = 0;

		private static uint __GetMaxElement = 0;

		private static uint __GetMax2D = 0;

		private static uint __GetHours = 0;

		private static uint __GetHour12 = 0;

		private static uint __GetHour = 0;

		private static uint __GetForwardVector = 0;

		private static uint __GetDuration = 0;

		private static uint __GetDirectionUnitVector = 0;

		private static uint __GetDays = 0;

		private static uint __GetDayOfYear = 0;

		private static uint __GetDay = 0;

		private static uint __GetDate = 0;

		private static uint __GetAzimuthAndElevation = 0;

		private static uint __GetAxes = 0;

		private static uint __GetAbsMax2D = 0;

		private static uint __GetAbs2D = 0;

		private static uint __FWrap = 0;

		private static uint __FTruncVector = 0;

		private static uint __FTrunc64 = 0;

		private static uint __FTrunc = 0;

		private static uint __FromUnixTimestamp = 0;

		private static uint __FromSeconds = 0;

		private static uint __FromMinutes = 0;

		private static uint __FromMilliseconds = 0;

		private static uint __FromHours = 0;

		private static uint __FromDays = 0;

		private static uint __Fraction = 0;

		private static uint __FMod64 = 0;

		private static uint __FMod = 0;

		private static uint __FMin = 0;

		private static uint __FMax = 0;

		private static uint __FloatSpringInterp = 0;

		private static uint __FixedTurn = 0;

		private static uint __FInterpTo_Constant = 0;

		private static uint __FInterpTo = 0;

		private static uint __FInterpEaseInOut = 0;

		private static uint __FindRelativeLookAtRotation = 0;

		private static uint __FindNearestPointsOnLineSegments = 0;

		private static uint __FindLookAtRotation = 0;

		private static uint __FindClosestPointOnSegment = 0;

		private static uint __FindClosestPointOnLine = 0;

		private static uint __FFloor64 = 0;

		private static uint __FFloor = 0;

		private static uint __FClamp = 0;

		private static uint __FCeil64 = 0;

		private static uint __FCeil = 0;

		private static uint __Exp = 0;

		private static uint __EqualExactly_VectorVector = 0;

		private static uint __EqualExactly_Vector4Vector4 = 0;

		private static uint __EqualExactly_Vector2DVector2D = 0;

		private static uint __EqualEqual_VectorVector = 0;

		private static uint __EqualEqual_Vector4Vector4 = 0;

		private static uint __EqualEqual_Vector2DVector2D = 0;

		private static uint __EqualEqual_TransformTransform = 0;

		private static uint __EqualEqual_TimespanTimespan = 0;

		private static uint __EqualEqual_RotatorRotator = 0;

		private static uint __EqualEqual_QuatQuat = 0;

		private static uint __EqualEqual_ObjectObject = 0;

		private static uint __EqualEqual_NameName = 0;

		private static uint __EqualEqual_MatrixMatrix = 0;

		private static uint __EqualEqual_LinearColorLinearColor = 0;

		private static uint __EqualEqual_IntInt = 0;

		private static uint __EqualEqual_Int64Int64 = 0;

		private static uint __EqualEqual_DoubleDouble = 0;

		private static uint __EqualEqual_DateTimeDateTime = 0;

		private static uint __EqualEqual_ClassClass = 0;

		private static uint __EqualEqual_ByteByte = 0;

		private static uint __EqualEqual_BoolBool = 0;

		private static uint __Equal_IntPointIntPoint = 0;

		private static uint __Ease = 0;

		private static uint __DynamicWeightedMovingAverage_FVector = 0;

		private static uint __DynamicWeightedMovingAverage_FRotator = 0;

		private static uint __DynamicWeightedMovingAverage_Float = 0;

		private static uint __DotProduct2D = 0;

		private static uint __Dot_VectorVector = 0;

		private static uint __Divide_VectorVector = 0;

		private static uint __Divide_VectorInt = 0;

		private static uint __Divide_VectorFloat = 0;

		private static uint __Divide_Vector4Vector4 = 0;

		private static uint __Divide_Vector2DVector2D = 0;

		private static uint __Divide_Vector2DFloat = 0;

		private static uint __Divide_TimespanFloat = 0;

		private static uint __Divide_LinearColorLinearColor = 0;

		private static uint __Divide_IntPointIntPoint = 0;

		private static uint __Divide_IntPointInt = 0;

		private static uint __Divide_IntInt = 0;

		private static uint __Divide_Int64Int64 = 0;

		private static uint __Divide_DoubleDouble = 0;

		private static uint __Divide_ByteByte = 0;

		private static uint __DistanceSquared2D = 0;

		private static uint __Distance2D = 0;

		private static uint __DegTan = 0;

		private static uint __DegSin = 0;

		private static uint __DegreesToRadians = 0;

		private static uint __DegCos = 0;

		private static uint __DegAtan2 = 0;

		private static uint __DegAtan = 0;

		private static uint __DegAsin = 0;

		private static uint __DegAcos = 0;

		private static uint __DaysInYear = 0;

		private static uint __DaysInMonth = 0;

		private static uint __DateTimeMinValue = 0;

		private static uint __DateTimeMaxValue = 0;

		private static uint __DateTimeFromString = 0;

		private static uint __DateTimeFromIsoString = 0;

		private static uint __CrossProduct2D = 0;

		private static uint __Cross_VectorVector = 0;

		private static uint __CreateVectorFromYawPitch = 0;

		private static uint __Cos = 0;

		private static uint __Conv_VectorToVector2D = 0;

		private static uint __Conv_VectorToTransform = 0;

		private static uint __Conv_VectorToRotator = 0;

		private static uint __Conv_VectorToQuaternion = 0;

		private static uint __Conv_VectorToLinearColor = 0;

		private static uint __Conv_Vector4ToVector = 0;

		private static uint __Conv_Vector4ToRotator = 0;

		private static uint __Conv_Vector4ToQuaternion = 0;

		private static uint __Conv_Vector2DToVector = 0;

		private static uint __Conv_Vector2DToIntPoint = 0;

		private static uint __Conv_TransformToMatrix = 0;

		private static uint __Conv_RotatorToVector = 0;

		private static uint __Conv_RotatorToTransform = 0;

		private static uint __Conv_RotatorToQuaternion = 0;

		private static uint __Conv_MatrixToTransform = 0;

		private static uint __Conv_MatrixToRotator = 0;

		private static uint __Conv_LinearColorToVector = 0;

		private static uint __Conv_LinearColorToColor = 0;

		private static uint __Conv_IntVectorToVector = 0;

		private static uint __Conv_IntToVector = 0;

		private static uint __Conv_IntToIntVector = 0;

		private static uint __Conv_IntToInt64 = 0;

		private static uint __Conv_IntToDouble = 0;

		private static uint __Conv_IntToByte = 0;

		private static uint __Conv_IntToBool = 0;

		private static uint __Conv_IntPointToVector2D = 0;

		private static uint __Conv_Int64ToInt = 0;

		private static uint __Conv_Int64ToDouble = 0;

		private static uint __Conv_Int64ToByte = 0;

		private static uint __Conv_FloatToDouble = 0;

		private static uint __Conv_DoubleToVector2D = 0;

		private static uint __Conv_DoubleToVector = 0;

		private static uint __Conv_DoubleToLinearColor = 0;

		private static uint __Conv_DoubleToInt64 = 0;

		private static uint __Conv_DoubleToFloat = 0;

		private static uint __Conv_ColorToLinearColor = 0;

		private static uint __Conv_ByteToInt64 = 0;

		private static uint __Conv_ByteToInt = 0;

		private static uint __Conv_ByteToDouble = 0;

		private static uint __Conv_BoolToInt = 0;

		private static uint __Conv_BoolToDouble = 0;

		private static uint __Conv_BoolToByte = 0;

		private static uint __ComposeTransforms = 0;

		private static uint __ComposeRotators = 0;

		private static uint __ClassIsChildOf = 0;

		private static uint __ClampVectorSize = 0;

		private static uint __ClampInt64 = 0;

		private static uint __ClampAxis = 0;

		private static uint __ClampAxes2D = 0;

		private static uint __ClampAngle = 0;

		private static uint __Clamp = 0;

		private static uint __CInterpTo = 0;

		private static uint __BreakVector_NetQuantizeNormal = 0;

		private static uint __BreakVector_NetQuantize100 = 0;

		private static uint __BreakVector_NetQuantize10 = 0;

		private static uint __BreakVector_NetQuantize = 0;

		private static uint __BreakVector4 = 0;

		private static uint __BreakVector2D = 0;

		private static uint __BreakVector = 0;

		private static uint __BreakTransform = 0;

		private static uint __BreakTimespan2 = 0;

		private static uint __BreakTimespan = 0;

		private static uint __BreakRotIntoAxes = 0;

		private static uint __BreakRotator = 0;

		private static uint __BreakRandomStream = 0;

		private static uint __BreakQuat = 0;

		private static uint __BreakQualifiedFrameTime = 0;

		private static uint __BreakFrameRate = 0;

		private static uint __BreakDateTime = 0;

		private static uint __BreakColor = 0;

		private static uint __BreakBoxSphereBounds = 0;

		private static uint __BooleanXOR = 0;

		private static uint __BooleanOR = 0;

		private static uint __BooleanNOR = 0;

		private static uint __BooleanNAND = 0;

		private static uint __BooleanAND = 0;

		private static uint __BMin = 0;

		private static uint __BMax = 0;

		private static uint __AverageOfIntArray = 0;

		private static uint __Atan2 = 0;

		private static uint __Atan = 0;

		private static uint __Asin = 0;

		private static uint __And_IntInt = 0;

		private static uint __And_Int64Int64 = 0;

		private static uint __Add_VectorVector = 0;

		private static uint __Add_VectorInt = 0;

		private static uint __Add_VectorFloat = 0;

		private static uint __Add_Vector4Vector4 = 0;

		private static uint __Add_Vector2DVector2D = 0;

		private static uint __Add_Vector2DFloat = 0;

		private static uint __Add_TimespanTimespan = 0;

		private static uint __Add_QuatQuat = 0;

		private static uint __Add_MatrixMatrix = 0;

		private static uint __Add_LinearColorLinearColor = 0;

		private static uint __Add_IntPointIntPoint = 0;

		private static uint __Add_IntPointInt = 0;

		private static uint __Add_IntInt = 0;

		private static uint __Add_Int64Int64 = 0;

		private static uint __Add_DoubleDouble = 0;

		private static uint __Add_DateTimeTimespan = 0;

		private static uint __Add_DateTimeDateTime = 0;

		private static uint __Add_ByteByte = 0;

		private static uint __Acos = 0;

		private static uint __Abs_Int64 = 0;

		private static uint __Abs_Int = 0;

		private static uint __Abs = 0;
	}
}