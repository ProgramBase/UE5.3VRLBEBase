using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimationModifierLibrary
{
	[PathName("/Script/AnimationModifierLibrary.MotionExtractorUtilityLibrary")]
	public partial class UMotionExtractorUtilityLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationModifierLibrary.MotionExtractorUtilityLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="AnimSequence">
		/// Anim sequence to check
		/// </param>
		/// <param name="StopSpeedThreshold">
		/// Root motion speed under which the animation is considered stopped.
		/// </param>
		/// <param name="SampleRate">
		/// Sample rate of the animation. It's recommended to use high values if the animation has very sudden direction changes.
		/// </param>
		public static TArray<FVector2D> GetStoppedRangesFromRootMotion(UAnimSequence AnimSequence, float StopSpeedThreshold = 10.000000f, float SampleRate = 120.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = StopSpeedThreshold;

				*(float*)(__InBuffer + 12) = SampleRate;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetStoppedRangesFromRootMotion, __InBuffer, __ReturnBuffer);

				return *(TArray<FVector2D>*)__ReturnBuffer;
			}
		}

		/// <param name="AnimSequence">
		/// Anim sequence to check
		/// </param>
		/// <param name="StopSpeedThreshold">
		/// Root motion speed over which the animation is considered moving.
		/// </param>
		/// <param name="SampleRate">
		/// Sample rate of the animation. It's recommended to use high values if the animation has very sudden direction changes.
		/// </param>
		public static TArray<FVector2D> GetMovingRangesFromRootMotion(UAnimSequence AnimSequence, float StopSpeedThreshold = 10.000000f, float SampleRate = 120.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = StopSpeedThreshold;

				*(float*)(__InBuffer + 12) = SampleRate;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMovingRangesFromRootMotion, __InBuffer, __ReturnBuffer);

				return *(TArray<FVector2D>*)__ReturnBuffer;
			}
		}

		/// <param name="BoneTransform">
		/// Current frame's bone transform
		/// </param>
		/// <param name="LastBoneTransform">
		/// Last frame's bone transform. Unused when not calculating speeds.
		/// </param>
		/// <param name="DeltaTime">
		/// Time step used between current and last bone transforms. Unused when not calculating speeds.
		/// </param>
		/// <param name="MotionType">
		/// What type of motion to extract (translation, rotation, speed, etc.)
		/// </param>
		/// <param name="Axis">
		/// Which axis/axes to extract motion from
		/// </param>
		public static float GetDesiredValue(FTransform BoneTransform, FTransform LastBoneTransform, float DeltaTime, EMotionExtractor_MotionType MotionType, EMotionExtractor_Axis Axis)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[22];

				*(nint*)(__InBuffer) = BoneTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LastBoneTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = DeltaTime;

				*(byte*)(__InBuffer + 20) = (byte)MotionType;

				*(byte*)(__InBuffer + 21) = (byte)Axis;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDesiredValue, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// The name of the bone
		/// </param>
		/// <param name="MotionType">
		/// What type of motion this curve represents (translation, rotation, speed, etc.)
		/// </param>
		/// <param name="Axis">
		/// Which axis/axes the motion for this curve was extracted from
		/// </param>
		public static FName GenerateCurveName(FName BoneName, EMotionExtractor_MotionType MotionType, EMotionExtractor_Axis Axis)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)MotionType;

				*(byte*)(__InBuffer + 9) = (byte)Axis;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GenerateCurveName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		private static uint __GetStoppedRangesFromRootMotion = 0;

		private static uint __GetMovingRangesFromRootMotion = 0;

		private static uint __GetDesiredValue = 0;

		private static uint __GenerateCurveName = 0;
	}
}