using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.LevelSequence;
using Script.ControlRig;
using Script.SequencerScripting;
using Script.MovieScene;
using Script.MovieSceneTools;
using Script.AnimationCore;
using Script.Constraints;
using Script.UnrealEd;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigSequencerEditorLibrary")]
	public partial class UControlRigSequencerEditorLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigEditor.ControlRigSequencerEditorLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="LevelSequence">
		/// The LevelSequence that's loaded in the editor
		/// </param>
		/// <param name="ControlRig">
		/// The Control Rig to tween.
		/// </param>
		/// <param name="TweenValue">
		/// The tween value to use, range from -1(blend to previous) to 1(blend to next)
		/// </param>
		public static bool TweenControlRig(ULevelSequence LevelSequence, UControlRig ControlRig, float TweenValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = TweenValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __TweenControlRig, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to snap
		/// </param>
		/// <param name="StartFrame">
		/// Beginning of the snap
		/// </param>
		/// <param name="EndFrame">
		/// End of the snap
		/// </param>
		/// <param name="ChildrenToSnap">
		/// The children objects that snap and get keys set onto. They need to live in an active Sequencer in the level editor
		/// </param>
		/// <param name="ParentToSnap">
		/// The parent object to snap relative to. If animated, it needs to live in an active Sequencer in the level editor
		/// </param>
		/// <param name="SnapSettings">
		/// Settings to use
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <param name="Returns">
		/// True if successful
		/// </param>
		public static bool SnapControlRig(ULevelSequence LevelSequence, FFrameNumber StartFrame, FFrameNumber EndFrame, FControlRigSnapperSelection ChildrenToSnap, FControlRigSnapperSelection ParentToSnap, UControlRigSnapSettings SnapSettings, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[49];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StartFrame?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = EndFrame?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ChildrenToSnap?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = ParentToSnap?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = SnapSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 48) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SnapControlRig, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void ShowAllControls(UMovieSceneSection InSection)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSection?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ShowAllControls, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Vector2D control
		/// </param>
		/// <param name="Frames">
		/// Times to set the values
		/// </param>
		/// <param name="Values">
		/// The values to set at those times
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		public static void SetLocalControlRigVector2Ds(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, TArray<FVector2D> Values, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Values?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigVector2Ds, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Vector2D control
		/// </param>
		/// <param name="Frame">
		/// Time to set the value
		/// </param>
		/// <param name="Value">
		/// The value to set
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <param name="bSetKey">
		/// If True set a key, if not just set the value
		/// </param>
		public static void SetLocalControlRigVector2D(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, FVector2D Value, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate, bool bSetKey = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[42];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				*(bool*)(__InBuffer + 41) = bSetKey;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigVector2D, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Transform control
		/// </param>
		/// <param name="Frames">
		/// Times to set the values
		/// </param>
		/// <param name="Values">
		/// The values to set at those times
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		public static void SetLocalControlRigTransforms(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, TArray<FTransform> Values, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Values?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigTransforms, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a TransformNoScale control
		/// </param>
		/// <param name="Frames">
		/// Times to set the values
		/// </param>
		/// <param name="Values">
		/// The values to set at those times
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		public static void SetLocalControlRigTransformNoScales(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, TArray<FTransformNoScale> Values, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Values?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigTransformNoScales, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a TransformNoScale control
		/// </param>
		/// <param name="Frame">
		/// Time to set the value
		/// </param>
		/// <param name="Value">
		/// The value to set
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <param name="bSetKey">
		/// If True set a key, if not just set the value
		/// </param>
		public static void SetLocalControlRigTransformNoScale(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, FTransformNoScale Value, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate, bool bSetKey = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[42];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				*(bool*)(__InBuffer + 41) = bSetKey;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigTransformNoScale, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Transform control
		/// </param>
		/// <param name="Frame">
		/// Time to set the value
		/// </param>
		/// <param name="Value">
		/// The value to set 
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <param name="bSetKey">
		/// If True set a key, if not just set the value
		/// </param>
		public static void SetLocalControlRigTransform(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, FTransform Value, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate, bool bSetKey = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[42];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				*(bool*)(__InBuffer + 41) = bSetKey;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigTransform, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Scale control
		/// </param>
		/// <param name="Frames">
		/// Times to set the values
		/// </param>
		/// <param name="Values">
		/// The values to set at those times
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		public static void SetLocalControlRigScales(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, TArray<FVector> Values, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Values?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigScales, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Scale control
		/// </param>
		/// <param name="Frame">
		/// Time to set the value
		/// </param>
		/// <param name="Value">
		/// The value to set
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <param name="bSetKey">
		/// If True set a key, if not just set the value
		/// </param>
		public static void SetLocalControlRigScale(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, FVector Value, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate, bool bSetKey = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[42];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				*(bool*)(__InBuffer + 41) = bSetKey;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigScale, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Rotator control
		/// </param>
		/// <param name="Frames">
		/// Times to set the values
		/// </param>
		/// <param name="Values">
		/// The values to set at those times
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		public static void SetLocalControlRigRotators(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, TArray<FRotator> Values, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Values?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigRotators, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Rotator control
		/// </param>
		/// <param name="Frame">
		/// Time to set the value
		/// </param>
		/// <param name="Value">
		/// The value to set
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <param name="bSetKey">
		/// If True set a key, if not just set the value
		/// </param>
		public static void SetLocalControlRigRotator(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, FRotator Value, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate, bool bSetKey = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[42];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				*(bool*)(__InBuffer + 41) = bSetKey;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigRotator, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Position control
		/// </param>
		/// <param name="Frames">
		/// Times to set the values
		/// </param>
		/// <param name="Values">
		/// The values to set at those times
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		public static void SetLocalControlRigPositions(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, TArray<FVector> Values, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Values?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigPositions, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Position control
		/// </param>
		/// <param name="Frame">
		/// Time to set the value
		/// </param>
		/// <param name="Value">
		/// The value to set
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <param name="bSetKey">
		/// If True set a key, if not just set the value
		/// </param>
		public static void SetLocalControlRigPosition(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, FVector Value, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate, bool bSetKey = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[42];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				*(bool*)(__InBuffer + 41) = bSetKey;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigPosition, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a int control
		/// </param>
		/// <param name="Frames">
		/// Times to set the values
		/// </param>
		/// <param name="Values">
		/// The values to set at those times
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		public static void SetLocalControlRigInts(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, TArray<int> Values, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Values?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigInts, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a int control
		/// </param>
		/// <param name="Frame">
		/// Time to set the value
		/// </param>
		/// <param name="Value">
		/// The value to set
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <param name="bSetKey">
		/// If True set a key, if not just set the value
		/// </param>
		public static void SetLocalControlRigInt(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, int Value, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate, bool bSetKey = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[38];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 32) = Value;

				*(byte*)(__InBuffer + 36) = (byte)TimeUnit;

				*(bool*)(__InBuffer + 37) = bSetKey;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigInt, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a float control
		/// </param>
		/// <param name="Frames">
		/// Times to set the values
		/// </param>
		/// <param name="Values">
		/// The values to set at those times
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		public static void SetLocalControlRigFloats(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, TArray<float> Values, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Values?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigFloats, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a float control
		/// </param>
		/// <param name="Frame">
		/// Time to set the value
		/// </param>
		/// <param name="Value">
		/// The value to set
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <param name="bSetKey">
		/// If True set a key, if not just set the value
		/// </param>
		public static void SetLocalControlRigFloat(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, float Value, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate, bool bSetKey = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[38];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = Value;

				*(byte*)(__InBuffer + 36) = (byte)TimeUnit;

				*(bool*)(__InBuffer + 37) = bSetKey;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigFloat, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a EulerTransform control
		/// </param>
		/// <param name="Frames">
		/// Times to set the values
		/// </param>
		/// <param name="Values">
		/// The values to set at those times
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		public static void SetLocalControlRigEulerTransforms(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, TArray<FEulerTransform> Values, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Values?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigEulerTransforms, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a EulerTransform control
		/// </param>
		/// <param name="Frame">
		/// Time to set the value
		/// </param>
		/// <param name="Value">
		/// The value to set
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <param name="bSetKey">
		/// If True set a key, if not just set the value
		/// </param>
		public static void SetLocalControlRigEulerTransform(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, FEulerTransform Value, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate, bool bSetKey = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[42];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				*(bool*)(__InBuffer + 41) = bSetKey;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigEulerTransform, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a bool control
		/// </param>
		/// <param name="Frames">
		/// Times to set the values
		/// </param>
		/// <param name="Values">
		/// The values to set at those times
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		public static void SetLocalControlRigBools(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, TArray<bool> Values, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Values?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigBools, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set value on
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a bool control
		/// </param>
		/// <param name="Frame">
		/// Time to set the value
		/// </param>
		/// <param name="Value">
		/// The value to set
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <param name="bSetKey">
		/// If True set a key, if not just set the value
		/// </param>
		public static void SetLocalControlRigBool(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, bool Value, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate, bool bSetKey = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[35];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = Value;

				*(byte*)(__InBuffer + 33) = (byte)TimeUnit;

				*(bool*)(__InBuffer + 34) = bSetKey;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLocalControlRigBool, __InBuffer);
			}
		}

		public static void SetControlsMask(UMovieSceneSection InSection, TArray<FName> ControlNames, bool bVisible)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InSection?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlNames?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bVisible;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetControlsMask, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set transforms for. Must be loaded in Level Editor.
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control
		/// </param>
		/// <param name="Frames">
		/// Times to set the transform
		/// </param>
		/// <param name="WorldTransform">
		/// World Transform to set
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		public static void SetControlRigWorldTransforms(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, TArray<FTransform> WorldTransforms, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = WorldTransforms?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetControlRigWorldTransforms, __InBuffer);
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to set transforms for. Must be loaded in Level Editor.
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control
		/// </param>
		/// <param name="Frame">
		/// Time to set the transform
		/// </param>
		/// <param name="WorldTransform">
		/// World Transform to set
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <param name="bSetKey">
		/// Whether or not to set a key.
		/// </param>
		public static void SetControlRigWorldTransform(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, FTransform WorldTransform, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate, bool bSetKey = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[42];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = WorldTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				*(bool*)(__InBuffer + 41) = bSetKey;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetControlRigWorldTransform, __InBuffer);
			}
		}

		/// <param name="InSequence">
		/// Sequence to set the space
		/// </param>
		/// <param name="InControlRig">
		/// ControlRig with the Control
		/// </param>
		/// <param name="InControlName">
		/// The name of the Control
		/// </param>
		/// <param name="InSpaceKey">
		/// The new space for the Control
		/// </param>
		/// <param name="InTime">
		/// Time to change the space.
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for the InTime, either in display rate or tick resolution
		/// </param>
		public static bool SetControlRigSpace(ULevelSequence InSequence, UControlRig InControlRig, FName InControlName, FRigElementKey InSpaceKey, FFrameNumber InTime, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InSpaceKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = InTime?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetControlRigSpace, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InControlRig">
		/// Rig to set 
		/// </param>
		/// <param name="InApplyMode">
		/// Set the EControlRigFKRigExecuteMode mode (Replace,Addtiive or Direct)
		/// </param>
		/// <returns>
		/// returns True if the mode was set, may not be set if the Control Rig doesn't support these modes currently only FKControlRig's do.
		/// </returns>
		public static bool SetControlRigApplyMode(UControlRig InControlRig, EControlRigFKRigExecuteMode InApplyMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InApplyMode;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetControlRigApplyMode, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InConstraint">
		/// The constraint to set the key
		/// </param>
		/// <param name="bActive">
		/// Whether or not it's active
		/// </param>
		/// <param name="FrameTime">
		/// Time to set the value
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for the time params, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns true if we set the constraint to be the passed in value, false if not. We may not do so if the value is the same.
		/// </returns>
		public static bool SetConstraintActiveKey(UTickableConstraint InConstraint, bool bActive, FFrameNumber InFrame, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InConstraint?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bActive;

				*(nint*)(__InBuffer + 9) = InFrame?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 17) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetConstraintActiveKey, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InSequence">
		/// Sequence to rename controls
		/// </param>
		/// <param name="InControlRig">
		/// ControlRig to rename controls
		/// </param>
		/// <param name="InOldControlNames">
		/// The name of the old Control Rig Control Channels to change. Will be replaced by the corresponding name in the InNewControlNames array
		/// </param>
		/// <param name="InNewControlNames">
		/// The name of the new Control Rig Channels 
		/// </param>
		/// <returns>
		/// Return true if the function succeeds, false if it doesn't which can happen if the name arrays don't match in size or any of the new Control Names aren't valid
		/// </returns>
		public static bool RenameControlRigControlChannels(ULevelSequence InSequence, UControlRig InControlRig, TArray<FName> InOldControlNames, TArray<FName> InNewControlNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InOldControlNames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InNewControlNames?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RenameControlRigControlChannels, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InSequence">
		/// Sequence to set the space
		/// </param>
		/// <param name="InControlRig">
		/// ControlRig with the Control
		/// </param>
		/// <param name="InControlName">
		/// The name of the Control
		/// </param>
		/// <param name="InTime">
		/// Original time of the space key
		/// </param>
		/// <param name="InNewTime">
		/// New time for the space key
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for the time params, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Will return false if function fails, for example if there is no key at this time it will fail, or if the new time is invalid it could fail also
		/// </returns>
		public static bool MoveControlRigSpace(ULevelSequence InSequence, UControlRig InControlRig, FName InControlName, FFrameNumber InTime, FFrameNumber InNewTime, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InTime?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = InNewTime?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MoveControlRigSpace, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InConstraint">
		/// The constraint whose key to move
		/// </param>
		/// <param name="ConstraintSection">
		/// Section containing Cosntraint Key
		/// </param>
		/// <param name="InTime">
		/// Original time of the constraint key
		/// </param>
		/// <param name="InNewTime">
		/// New time for the constraint key
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for the time params, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Will return false if function fails, for example if there is no key at this time it will fail, or if the new time is invalid it could fail also
		/// </returns>
		public static bool MoveConstraintKey(UTickableConstraint Constraint, UMovieSceneSection ConstraintSection, FFrameNumber InTime, FFrameNumber InNewTime, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = Constraint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ConstraintSection?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InTime?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InNewTime?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MoveConstraintKey, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="MovieSceneSection">
		/// The MovieSceneSectionto load into
		/// </param>
		/// <param name="AnimSequence">
		/// The Sequence to load
		/// </param>
		/// <param name="MovieScene">
		/// The MovieScene getting loaded into
		/// </param>
		/// <param name="SkelMeshComponent">
		/// The Skeletal Mesh component getting loaded into.
		/// </param>
		/// <param name="InStartFrame">
		/// Frame to insert the animation
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for all frame and time values, either in display rate or tick resolution
		/// </param>
		/// <param name="bKeyReduce">
		/// If true do key reduction based upon Tolerance, if false don't
		/// </param>
		/// <param name="Tolerance">
		/// If reducing keys, tolerance about which keys will be removed, smaller tolerance, more keys usually.
		/// </param>
		/// <returns>
		/// returns True if successful, False otherwise
		/// </returns>
		public static bool LoadAnimSequenceIntoControlRigSection(UMovieSceneSection MovieSceneSection, UAnimSequence AnimSequence, USkeletalMeshComponent SkelMeshComp, FFrameNumber InStartFrame, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate, bool bKeyReduce = false, float Tolerance = 0.001000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[38];

				*(nint*)(__InBuffer) = MovieSceneSection?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AnimSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SkelMeshComp?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InStartFrame?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				*(bool*)(__InBuffer + 33) = bKeyReduce;

				*(float*)(__InBuffer + 34) = Tolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LoadAnimSequenceIntoControlRigSection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InControlRig">
		/// Rig to test to see if FK Control Rig
		/// </param>
		public static bool IsFKControlRig(UControlRig InControlRig)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InControlRig?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsFKControlRig, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InWorld">
		/// World to import to
		/// </param>
		/// <param name="InSequence">
		/// Sequence to import
		/// </param>
		/// <param name="InTrack">
		/// Track to import onto
		/// </param>
		/// <param name="InSection">
		/// Section to import onto, may be null in which case we use the track's section to key
		/// </param>
		/// <param name="SelectedControlRigNames">
		/// List of selected control rig names. Will use them if  ImportFBXControlRigSettings->bImportOntoSelectedControls is true
		/// </param>
		/// <param name="ImportFBXControlRigSettings">
		/// Settings to control import.
		/// </param>
		/// <param name="InImportFileName">
		/// Path to fbx file to create
		/// </param>
		public static bool ImportFBXToControlRigTrack(UWorld World, ULevelSequence InSequence, UMovieSceneControlRigParameterTrack InTrack, UMovieSceneControlRigParameterSection InSection, TArray<FString> SelectedControlRigNames, UMovieSceneUserImportFBXControlRigSettings ImportFBXControlRigSettings, FString ImportFilename)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[56];

				*(nint*)(__InBuffer) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InTrack?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InSection?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = SelectedControlRigNames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = ImportFBXControlRigSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 48) = ImportFilename?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ImportFBXToControlRigTrack, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void HideAllControls(UMovieSceneSection InSection)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSection?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __HideAllControls, __InBuffer);
			}
		}

		public static FRigElementKey GetWorldSpaceReferenceKey()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetWorldSpaceReferenceKey, __ReturnBuffer);

				return *(FRigElementKey*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// returns list of visible Control Rigs
		/// </returns>
		public static TArray<UControlRig> GetVisibleControlRigs()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetVisibleControlRigs, __ReturnBuffer);

				return *(TArray<UControlRig>*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get transform for
		/// </param>
		/// <param name="SkeletalMeshComponent">
		/// The SkeletalMeshComponent
		/// </param>
		/// <param name="Frames">
		/// Times to get the transform
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <param name="ReferenceName">
		/// Optional name of the referencer
		/// </param>
		/// <returns>
		/// Returns World Transforms
		/// </returns>
		public static TArray<FTransform> GetSkeletalMeshComponentWorldTransforms(ULevelSequence LevelSequence, USkeletalMeshComponent SkeletalMeshComponent, TArray<FFrameNumber> Frames, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate, FName ReferenceName = null)
		{
			unsafe
			{
				ReferenceName ??= new FName("None");

				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SkeletalMeshComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)TimeUnit;

				*(nint*)(__InBuffer + 25) = ReferenceName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSkeletalMeshComponentWorldTransforms, __InBuffer, __ReturnBuffer);

				return *(TArray<FTransform>*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get transform for
		/// </param>
		/// <param name="SkeletalMeshComponent">
		/// The SkeletalMeshComponent
		/// </param>
		/// <param name="Frame">
		/// Time to get the transform
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <param name="ReferenceName">
		/// Optional name of the referencer
		/// </param>
		/// <returns>
		/// Returns World Transform
		/// </returns>
		public static FTransform GetSkeletalMeshComponentWorldTransform(ULevelSequence LevelSequence, USkeletalMeshComponent SkeletalMeshComponent, FFrameNumber Frame, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate, FName ReferenceName = null)
		{
			unsafe
			{
				ReferenceName ??= new FName("None");

				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SkeletalMeshComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)TimeUnit;

				*(nint*)(__InBuffer + 25) = ReferenceName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSkeletalMeshComponentWorldTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Vector2D control
		/// </param>
		/// <param name="Frames">
		/// Times to get the values
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Values at those times
		/// </returns>
		public static TArray<FVector2D> GetLocalControlRigVector2Ds(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigVector2Ds, __InBuffer, __ReturnBuffer);

				return *(TArray<FVector2D>*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Vector2D control
		/// </param>
		/// <param name="Frame">
		/// Time to get the value
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Value at that time
		/// </returns>
		public static FVector2D GetLocalControlRigVector2D(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigVector2D, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Transform control
		/// </param>
		/// <param name="Frames">
		/// Times to get the values
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Values at those times
		/// </returns>
		public static TArray<FTransform> GetLocalControlRigTransforms(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigTransforms, __InBuffer, __ReturnBuffer);

				return *(TArray<FTransform>*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a TransformNoScale control
		/// </param>
		/// <param name="Frames">
		/// Times to get the values
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Values at those times
		/// </returns>
		public static TArray<FTransformNoScale> GetLocalControlRigTransformNoScales(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigTransformNoScales, __InBuffer, __ReturnBuffer);

				return *(TArray<FTransformNoScale>*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a TransformNoScale control
		/// </param>
		/// <param name="Frame">
		/// Time to get the value
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Value at that time
		/// </returns>
		public static FTransformNoScale GetLocalControlRigTransformNoScale(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigTransformNoScale, __InBuffer, __ReturnBuffer);

				return *(FTransformNoScale*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Transform control
		/// </param>
		/// <param name="Frame">
		/// Time to get the value
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Value at that time
		/// </returns>
		public static FTransform GetLocalControlRigTransform(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Scale control
		/// </param>
		/// <param name="Frames">
		/// Times to get the values
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Values at those times
		/// </returns>
		public static TArray<FVector> GetLocalControlRigScales(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigScales, __InBuffer, __ReturnBuffer);

				return *(TArray<FVector>*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Scale control
		/// </param>
		/// <param name="Frame">
		/// Time to get the value
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Value at that time
		/// </returns>
		public static FVector GetLocalControlRigScale(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigScale, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Rotator control
		/// </param>
		/// <param name="Frames">
		/// Times to get the values
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Values at those times
		/// </returns>
		public static TArray<FRotator> GetLocalControlRigRotators(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigRotators, __InBuffer, __ReturnBuffer);

				return *(TArray<FRotator>*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Rotator control
		/// </param>
		/// <param name="Frame">
		/// Time to get the value
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Value at that time
		/// </returns>
		public static FRotator GetLocalControlRigRotator(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigRotator, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Position control
		/// </param>
		/// <param name="Frames">
		/// Times to get the values
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Values at those times
		/// </returns>
		public static TArray<FVector> GetLocalControlRigPositions(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigPositions, __InBuffer, __ReturnBuffer);

				return *(TArray<FVector>*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a Position control
		/// </param>
		/// <param name="Frame">
		/// Time to get the value
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Value at that time
		/// </returns>
		public static FVector GetLocalControlRigPosition(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigPosition, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a intteger control
		/// </param>
		/// <param name="Frames">
		/// Times to get the values
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Values at those times
		/// </returns>
		public static TArray<int> GetLocalControlRigInts(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigInts, __InBuffer, __ReturnBuffer);

				return *(TArray<int>*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a integer control
		/// </param>
		/// <param name="Frame">
		/// Time to get the value
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Value at that time
		/// </returns>
		public static int GetLocalControlRigInt(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a float control
		/// </param>
		/// <param name="Frames">
		/// Times to get the values
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Values at those times
		/// </returns>
		public static TArray<float> GetLocalControlRigFloats(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigFloats, __InBuffer, __ReturnBuffer);

				return *(TArray<float>*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a float control
		/// </param>
		/// <param name="Frame">
		/// Time to get the value
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Value at that time
		/// </returns>
		public static float GetLocalControlRigFloat(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigFloat, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a EulerTransform control
		/// </param>
		/// <param name="Frames">
		/// Times to get the values
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Values at those times
		/// </returns>
		public static TArray<FEulerTransform> GetLocalControlRigEulerTransforms(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigEulerTransforms, __InBuffer, __ReturnBuffer);

				return *(TArray<FEulerTransform>*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a EulerTransfom control
		/// </param>
		/// <param name="Frame">
		/// Time to get the value
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Value at that time
		/// </returns>
		public static FEulerTransform GetLocalControlRigEulerTransform(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigEulerTransform, __InBuffer, __ReturnBuffer);

				return *(FEulerTransform*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a bool control
		/// </param>
		/// <param name="Frames">
		/// Times to get the values
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Values at those times
		/// </returns>
		public static TArray<bool> GetLocalControlRigBools(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigBools, __InBuffer, __ReturnBuffer);

				return *(TArray<bool>*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get value for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control, should be a bool control
		/// </param>
		/// <param name="Frame">
		/// Time to get the value
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns Value at that time
		/// </returns>
		public static bool GetLocalControlRigBool(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalControlRigBool, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InControlRig">
		/// Rig to test
		/// </param>
		/// <returns>
		/// The EControlRigFKRigExecuteMode mode it is in, either Replace,Additive or Direct
		/// </returns>
		public static EControlRigFKRigExecuteMode GetFKControlRigApplyMode(UControlRig InControlRig)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InControlRig?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetFKControlRigApplyMode, __InBuffer, __ReturnBuffer);

				return *(EControlRigFKRigExecuteMode*)__ReturnBuffer;
			}
		}

		public static FRigElementKey GetDefaultParentKey()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetDefaultParentKey, __ReturnBuffer);

				return *(FRigElementKey*)__ReturnBuffer;
			}
		}

		public static bool GetControlsMask(UMovieSceneSection InSection, FName ControlName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InSection?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetControlsMask, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get transform for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control 
		/// </param>
		/// <param name="Frames">
		/// Times to get the transform
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns World Transforms
		/// </returns>
		public static TArray<FTransform> GetControlRigWorldTransforms(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, TArray<FFrameNumber> Frames, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetControlRigWorldTransforms, __InBuffer, __ReturnBuffer);

				return *(TArray<FTransform>*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get transform for
		/// </param>
		/// <param name="ControlRig">
		/// The ControlRig
		/// </param>
		/// <param name="ControlName">
		/// Name of the Control
		/// </param>
		/// <param name="Frame">
		/// Time to get the transform
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns World Transform
		/// </returns>
		public static FTransform GetControlRigWorldTransform(ULevelSequence LevelSequence, UControlRig ControlRig, FName ControlName, FFrameNumber Frame, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetControlRigWorldTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// The movie scene sequence to look for Control Rigs
		/// </param>
		/// <returns>
		/// returns list of Control Rigs in the level sequence.
		/// </returns>
		public static TArray<FControlRigSequencerBindingProxy> GetControlRigs(ULevelSequence LevelSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetControlRigs, __InBuffer, __ReturnBuffer);

				return *(TArray<FControlRigSequencerBindingProxy>*)__ReturnBuffer;
			}
		}

		/// <param name="InChild">
		/// The handle to look for constraints controlling it
		/// </param>
		/// <returns>
		/// Returns array of Constraints this handle is constrained to.
		/// </returns>
		public static TArray<UTickableConstraint> GetConstraintsForHandle(UWorld InWorld, UTransformableHandle InChild)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InWorld?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InChild?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetConstraintsForHandle, __InBuffer, __ReturnBuffer);

				return *(TArray<UTickableConstraint>*)__ReturnBuffer;
			}
		}

		/// <param name="InConstraint">
		/// The constraint to get
		/// </param>
		/// <param name="ConstraintSection">
		/// Section containing Cosntraint Key
		/// </param>
		/// <param name="OutBools">
		/// Array of whether or not it's active at the specified times
		/// </param>
		/// <param name="OutFrames">
		/// The Times for the keys
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for the time params, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns true if we got the keys from this constraint
		/// </returns>
		public static bool GetConstraintKeys(UTickableConstraint InConstraint, UMovieSceneSection ConstraintSection, ref TArray<bool> OutBools, ref TArray<FFrameNumber> OutFrames, ESequenceTimeUnit TimeUnit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = InConstraint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ConstraintSection?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutBools?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutFrames?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetConstraintKeys, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutBools = *(TArray<bool>*)(__OutBuffer);

				OutFrames = *(TArray<FFrameNumber>*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get transform for
		/// </param>
		/// <param name="Actor">
		/// The actor
		/// </param>
		/// <param name="Frames">
		/// Times to get the transform
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns World Transforms
		/// </returns>
		public static TArray<FTransform> GetActorWorldTransforms(ULevelSequence LevelSequence, AActor Actor, TArray<FFrameNumber> Frames, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetActorWorldTransforms, __InBuffer, __ReturnBuffer);

				return *(TArray<FTransform>*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// Active Sequence to get transform for
		/// </param>
		/// <param name="Actor">
		/// The actor
		/// </param>
		/// <param name="Frame">
		/// Time to get the transform
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for frame values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns World Transform
		/// </returns>
		public static FTransform GetActorWorldTransform(ULevelSequence LevelSequence, AActor Actor, FFrameNumber Frame, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Frame?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetActorWorldTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="World">
		/// The world used to spawn into temporarily if binding is a spawnable
		/// </param>
		/// <param name="LevelSequence">
		/// The LevelSequence to find or create
		/// </param>
		/// <param name="ControlRigClass">
		/// The class of the Control Rig
		/// </param>
		/// <param name="InBinding">
		/// The binding (actor or component binding) to find or create the Control Rig track
		/// </param>
		/// <returns>
		/// returns Return the found or created track
		/// </returns>
		public static UMovieSceneTrack FindOrCreateControlRigTrack(UWorld World, ULevelSequence LevelSequence, UClass ControlRigClass, FMovieSceneBindingProxy InBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlRigClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindOrCreateControlRigTrack, __InBuffer, __ReturnBuffer);

				return *(UMovieSceneTrack*)__ReturnBuffer;
			}
		}

		/// <param name="World">
		/// The world used to spawn into temporarily if binding is a spawnable
		/// </param>
		/// <param name="LevelSequence">
		/// The LevelSequence to find or create
		/// </param>
		/// <param name="InBinding">
		/// The binding (actor or component binding) to find or create the Control Rig tracks
		/// </param>
		/// <returns>
		/// returns Find array of component Control Rigs that were found or created
		/// </returns>
		public static TArray<UMovieSceneTrack> FindOrCreateControlRigComponentTrack(UWorld World, ULevelSequence LevelSequence, FMovieSceneBindingProxy InBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindOrCreateControlRigComponentTrack, __InBuffer, __ReturnBuffer);

				return *(TArray<UMovieSceneTrack>*)__ReturnBuffer;
			}
		}

		public static bool ExportFBXFromControlRigSection(ULevelSequence Sequence, UMovieSceneControlRigParameterSection Section, UMovieSceneUserExportFBXControlRigSettings ExportFBXControlRigSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Section?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ExportFBXControlRigSettings?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ExportFBXFromControlRigSection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InSequence">
		/// Sequence to set the space
		/// </param>
		/// <param name="InControlRig">
		/// ControlRig with the Control
		/// </param>
		/// <param name="InControlName">
		/// The name of the Control
		/// </param>
		/// <param name="InTime">
		/// Time to delete the space.
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for the InTime, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Will return false if function fails,  for example if there is no key at this time it will fail.
		/// </returns>
		public static bool DeleteControlRigSpace(ULevelSequence InSequence, UControlRig InControlRig, FName InControlName, FFrameNumber InTime, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InControlName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InTime?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DeleteControlRigSpace, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InConstraint">
		/// The constraint whose key to move
		/// </param>
		/// <param name="ConstraintSection">
		/// Section containing Cosntraint Key
		/// </param>
		/// <param name="InTime">
		/// Time to delete the constraint.
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for the InTime, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Will return false if function fails,  for example if there is no key at this time it will fail.
		/// </returns>
		public static bool DeleteConstraintKey(UTickableConstraint Constraint, UMovieSceneSection ConstraintSection, FFrameNumber InTime, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Constraint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ConstraintSection?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InTime?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DeleteConstraintKey, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InConstraint">
		/// The constraint to compensate
		/// </param>
		/// <returns>
		/// Returns true if it can compensate
		/// </returns>
		public static bool CompensateAll(UTickableConstraint InConstraint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InConstraint?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CompensateAll, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InConstraint">
		/// The constraint to compensate
		/// </param>
		/// <param name="InTime">
		/// Time to compensate
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for the InTime, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns true if it can compensate
		/// </returns>
		public static bool Compensate(UTickableConstraint InConstraint, FFrameNumber InTime, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InConstraint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTime?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Compensate, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InSequence">
		/// Sequence that has track to collapse
		/// </param>
		/// <param name="InTrack">
		/// Track for layers to collapse
		/// </param>
		/// <param name="InSettings">
		/// Settings that determine how to collapse
		/// </param>
		public static bool CollapseControlRigAnimLayersWithSettings(ULevelSequence InSequence, UMovieSceneControlRigParameterTrack InTrack, FBakingAnimationKeySettings InSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTrack?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CollapseControlRigAnimLayersWithSettings, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InSequence">
		/// Sequence that has track to collapse
		/// </param>
		/// <param name="InTrack">
		/// Track for layers to collapse
		/// </param>
		/// <param name="bKeyReduce">
		/// If true do key reduction based upon Tolerance, if false don't
		/// </param>
		/// <param name="Tolerance">
		/// If reducing keys, tolerance about which keys will be removed, smaller tolerance, more keys usually.
		/// </param>
		public static bool CollapseControlRigAnimLayers(ULevelSequence InSequence, UMovieSceneControlRigParameterTrack InTrack, bool bKeyReduce = false, float Tolerance = 0.001000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTrack?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bKeyReduce;

				*(float*)(__InBuffer + 17) = Tolerance;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CollapseControlRigAnimLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="LevelSequence">
		/// The LevelSequence that's loaded in the editor
		/// </param>
		/// <param name="EAnimToolBlendOperation">
		/// The operation to perform
		/// </param>
		/// <param name="BlendValue">
		/// The blend value to use, range from -1(blend to previous) to 1(blend to next)
		/// </param>
		public static bool BlendValuesOnSelected(ULevelSequence LevelSequence, EAnimToolBlendOperation BlendOperation, float BlendValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)BlendOperation;

				*(float*)(__InBuffer + 9) = BlendValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __BlendValuesOnSelected, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="World">
		/// The active world
		/// </param>
		/// <param name="LevelSequence">
		/// The LevelSequence we are baking
		/// </param>
		/// <param name="ControlRigClass">
		/// The class of the Control Rig
		/// </param>
		/// <param name="ExportOptions">
		/// Export options for creating an animation sequence
		/// </param>
		/// <param name="bKeyReduce">
		/// If true do key reduction based upon Tolerance, if false don't
		/// </param>
		/// <param name="Tolerance">
		/// If reducing keys, tolerance about which keys will be removed, smaller tolerance, more keys usually.
		/// </param>
		/// <param name="Binding">
		/// The binding upon which to bake
		/// </param>
		/// <returns>
		/// returns True if successful, False otherwise
		/// </returns>
		public static bool BakeToControlRig(UWorld World, ULevelSequence LevelSequence, UClass ControlRigClass, UAnimSeqExportOption ExportOptions, bool bReduceKeys, float Tolerance, FMovieSceneBindingProxy Binding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[45];

				*(nint*)(__InBuffer) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ControlRigClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ExportOptions?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bReduceKeys;

				*(float*)(__InBuffer + 33) = Tolerance;

				*(nint*)(__InBuffer + 37) = Binding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __BakeToControlRig, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InSequence">
		/// Sequence to bake
		/// </param>
		/// <param name="InControlRig">
		/// ControlRig to bake
		/// </param>
		/// <param name="InControlNames">
		/// The name of the Controls to bake
		/// </param>
		/// <param name="InSettings">
		/// The settings for the bake, e.g, how long to bake, to key reduce etc.
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for the start and end times in the InSettings parameter.
		/// </param>
		public static bool BakeControlRigSpace(ULevelSequence InSequence, UControlRig InControlRig, TArray<FName> InControlNames, FRigSpacePickerBakeSettings InSettings, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InControlNames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __BakeControlRigSpace, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="World">
		/// The active world
		/// </param>
		/// <param name="InConstraints">
		/// The Constraints tobake.  After baking they will be keyed to be inactive of the range of frames that are baked
		/// </param>
		/// <param name="InSettings">
		/// Settings to use for baking
		/// </param>
		/// <returns>
		/// Returns True if successful, False otherwise
		/// </returns>
		public static bool BakeConstraints(UWorld World, ref TArray<UTickableConstraint> InConstraints, FBakingAnimationKeySettings InSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InConstraints?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __BakeConstraints, __InBuffer, __OutBuffer, __ReturnBuffer);

				InConstraints = *(TArray<UTickableConstraint>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="World">
		/// The active world
		/// </param>
		/// <param name="Constraint">
		/// The Constraint to bake. After baking it will be keyed to be inactive of the range of frames that are baked
		/// </param>
		/// <param name="Frames">
		/// The frames to bake, if the array is empty it will use the active time ranges of the constraint to determine where it should bake
		/// </param>
		/// <param name="TimeUnit">
		/// Unit for all frame and time values, either in display rate or tick resolution
		/// </param>
		/// <returns>
		/// Returns True if successful, False otherwise
		/// </returns>
		public static bool BakeConstraint(UWorld World, UTickableConstraint Constraint, TArray<FFrameNumber> Frames, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Constraint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Frames?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __BakeConstraint, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="World">
		/// The active world
		/// </param>
		/// <param name="InType">
		/// Type of constraint to create
		/// </param>
		/// <param name="InChild">
		/// The handle to the transormable to be constrainted
		/// </param>
		/// <param name="InParent">
		/// The handle to the parent of the constraint
		/// </param>
		/// <param name="bMaintainOffset">
		/// Whether to maintain offset between child and parent when setting the constraint
		/// </param>
		/// <returns>
		/// Returns the constraint if created all nullptr if not
		/// </returns>
		public static UTickableConstraint AddConstraint(UWorld World, ETransformConstraintType InType, UTransformableHandle InChild, UTransformableHandle InParent, bool bMaintainOffset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InType;

				*(nint*)(__InBuffer + 9) = InChild?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = InParent?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 25) = bMaintainOffset;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AddConstraint, __InBuffer, __ReturnBuffer);

				return *(UTickableConstraint*)__ReturnBuffer;
			}
		}

		private static uint __TweenControlRig = 0;

		private static uint __SnapControlRig = 0;

		private static uint __ShowAllControls = 0;

		private static uint __SetLocalControlRigVector2Ds = 0;

		private static uint __SetLocalControlRigVector2D = 0;

		private static uint __SetLocalControlRigTransforms = 0;

		private static uint __SetLocalControlRigTransformNoScales = 0;

		private static uint __SetLocalControlRigTransformNoScale = 0;

		private static uint __SetLocalControlRigTransform = 0;

		private static uint __SetLocalControlRigScales = 0;

		private static uint __SetLocalControlRigScale = 0;

		private static uint __SetLocalControlRigRotators = 0;

		private static uint __SetLocalControlRigRotator = 0;

		private static uint __SetLocalControlRigPositions = 0;

		private static uint __SetLocalControlRigPosition = 0;

		private static uint __SetLocalControlRigInts = 0;

		private static uint __SetLocalControlRigInt = 0;

		private static uint __SetLocalControlRigFloats = 0;

		private static uint __SetLocalControlRigFloat = 0;

		private static uint __SetLocalControlRigEulerTransforms = 0;

		private static uint __SetLocalControlRigEulerTransform = 0;

		private static uint __SetLocalControlRigBools = 0;

		private static uint __SetLocalControlRigBool = 0;

		private static uint __SetControlsMask = 0;

		private static uint __SetControlRigWorldTransforms = 0;

		private static uint __SetControlRigWorldTransform = 0;

		private static uint __SetControlRigSpace = 0;

		private static uint __SetControlRigApplyMode = 0;

		private static uint __SetConstraintActiveKey = 0;

		private static uint __RenameControlRigControlChannels = 0;

		private static uint __MoveControlRigSpace = 0;

		private static uint __MoveConstraintKey = 0;

		private static uint __LoadAnimSequenceIntoControlRigSection = 0;

		private static uint __IsFKControlRig = 0;

		private static uint __ImportFBXToControlRigTrack = 0;

		private static uint __HideAllControls = 0;

		private static uint __GetWorldSpaceReferenceKey = 0;

		private static uint __GetVisibleControlRigs = 0;

		private static uint __GetSkeletalMeshComponentWorldTransforms = 0;

		private static uint __GetSkeletalMeshComponentWorldTransform = 0;

		private static uint __GetLocalControlRigVector2Ds = 0;

		private static uint __GetLocalControlRigVector2D = 0;

		private static uint __GetLocalControlRigTransforms = 0;

		private static uint __GetLocalControlRigTransformNoScales = 0;

		private static uint __GetLocalControlRigTransformNoScale = 0;

		private static uint __GetLocalControlRigTransform = 0;

		private static uint __GetLocalControlRigScales = 0;

		private static uint __GetLocalControlRigScale = 0;

		private static uint __GetLocalControlRigRotators = 0;

		private static uint __GetLocalControlRigRotator = 0;

		private static uint __GetLocalControlRigPositions = 0;

		private static uint __GetLocalControlRigPosition = 0;

		private static uint __GetLocalControlRigInts = 0;

		private static uint __GetLocalControlRigInt = 0;

		private static uint __GetLocalControlRigFloats = 0;

		private static uint __GetLocalControlRigFloat = 0;

		private static uint __GetLocalControlRigEulerTransforms = 0;

		private static uint __GetLocalControlRigEulerTransform = 0;

		private static uint __GetLocalControlRigBools = 0;

		private static uint __GetLocalControlRigBool = 0;

		private static uint __GetFKControlRigApplyMode = 0;

		private static uint __GetDefaultParentKey = 0;

		private static uint __GetControlsMask = 0;

		private static uint __GetControlRigWorldTransforms = 0;

		private static uint __GetControlRigWorldTransform = 0;

		private static uint __GetControlRigs = 0;

		private static uint __GetConstraintsForHandle = 0;

		private static uint __GetConstraintKeys = 0;

		private static uint __GetActorWorldTransforms = 0;

		private static uint __GetActorWorldTransform = 0;

		private static uint __FindOrCreateControlRigTrack = 0;

		private static uint __FindOrCreateControlRigComponentTrack = 0;

		private static uint __ExportFBXFromControlRigSection = 0;

		private static uint __DeleteControlRigSpace = 0;

		private static uint __DeleteConstraintKey = 0;

		private static uint __CompensateAll = 0;

		private static uint __Compensate = 0;

		private static uint __CollapseControlRigAnimLayersWithSettings = 0;

		private static uint __CollapseControlRigAnimLayers = 0;

		private static uint __BlendValuesOnSelected = 0;

		private static uint __BakeToControlRig = 0;

		private static uint __BakeControlRigSpace = 0;

		private static uint __BakeConstraints = 0;

		private static uint __BakeConstraint = 0;

		private static uint __AddConstraint = 0;
	}
}