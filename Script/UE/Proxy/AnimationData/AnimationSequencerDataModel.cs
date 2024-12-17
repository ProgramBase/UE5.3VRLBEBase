using Script.CoreUObject;
using Script.MovieScene;
using Script.Engine;
using Script.Library;

namespace Script.AnimationData
{
	[PathName("/Script/AnimationData.AnimationSequencerDataModel")]
	public partial class UAnimationSequencerDataModel : UMovieSceneSequence, IStaticClass, IAnimationDataModel
	{
		public FAnimDataModelModifiedDynamicEvent ModifiedEventDynamic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ModifiedEventDynamic, __ReturnBuffer);

					return *(FAnimDataModelModifiedDynamicEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ModifiedEventDynamic, __InBuffer);
				}
			}
		}

		public FAnimationCurveData LegacyCurveData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LegacyCurveData, __ReturnBuffer);

					return *(FAnimationCurveData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LegacyCurveData, __InBuffer);
				}
			}
		}

		public TArray<FAnimatedBoneAttribute> AnimatedBoneAttributes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimatedBoneAttributes, __ReturnBuffer);

					return *(TArray<FAnimatedBoneAttribute>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimatedBoneAttributes, __InBuffer);
				}
			}
		}

		public UMovieScene MovieScene
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MovieScene, __ReturnBuffer);

					return *(UMovieScene*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MovieScene, __InBuffer);
				}
			}
		}

		public TMap<FAnimationCurveIdentifier, FAnimationCurveMetaData> CurveIdentifierToMetaData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurveIdentifierToMetaData, __ReturnBuffer);

					return *(TMap<FAnimationCurveIdentifier, FAnimationCurveMetaData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurveIdentifierToMetaData, __InBuffer);
				}
			}
		}

		public bool bPopulated
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPopulated, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPopulated, __InBuffer);
				}
			}
		}

		public FGuid CachedRawDataGUID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedRawDataGUID, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedRawDataGUID, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationData.AnimationSequencerDataModel");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool IsValidBoneTrackName(FName TrackName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TrackName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsValidBoneTrackName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsValidBoneTrackIndex(int TrackIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = TrackIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsValidBoneTrackIndex, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Total length of play-able animation data 
		/// </returns>
		public virtual double GetPlayLength()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPlayLength, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Total number of bone animation tracks
		/// </returns>
		public virtual int GetNumBoneTracks()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumBoneTracks, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Total number of stored FTransform curves
		/// </returns>
		public virtual int GetNumberOfTransformCurves()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumberOfTransformCurves, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Total number of animation data keys stored 
		/// </returns>
		public virtual int GetNumberOfKeys()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumberOfKeys, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Total number of frames of animation data stored 
		/// </returns>
		public virtual int GetNumberOfFrames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumberOfFrames, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Total number of stored float curves
		/// </returns>
		public virtual int GetNumberOfFloatCurves()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumberOfFloatCurves, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Frame rate at which the animation data is key-ed 
		/// </returns>
		public virtual FFrameRate GetFrameRate()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetFrameRate, __ReturnBuffer);

				return *(FFrameRate*)__ReturnBuffer;
			}
		}

		/// <param name="OutNames">
		/// [out] Array containing all bone track names
		/// </param>
		public virtual void GetBoneTrackNames(ref TArray<FName> OutNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetBoneTrackNames, __InBuffer, __OutBuffer);

				OutNames = *(TArray<FName>*)(__OutBuffer);

			}
		}

		public virtual int GetBoneTrackIndexByName(FName TrackName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TrackName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetBoneTrackIndexByName, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetBoneTrackIndex(FBoneAnimationTrack Track)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetBoneTrackIndex, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual FBoneAnimationTrack GetBoneTrackByName(FName TrackName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TrackName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoneTrackByName, __InBuffer, __ReturnBuffer);

				return *(FBoneAnimationTrack*)__ReturnBuffer;
			}
		}

		public virtual FBoneAnimationTrack GetBoneTrackByIndex(int TrackIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = TrackIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoneTrackByIndex, __InBuffer, __ReturnBuffer);

				return *(FBoneAnimationTrack*)__ReturnBuffer;
			}
		}

		public virtual TArray<FBoneAnimationTrack> GetBoneAnimationTracks()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetBoneAnimationTracks, __ReturnBuffer);

				return *(TArray<FBoneAnimationTrack>*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The outer UAnimSequence object if found, otherwise returns a nullptr 
		/// </returns>
		public virtual UAnimSequence GetAnimationSequence()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAnimationSequence, __ReturnBuffer);

				return *(UAnimSequence*)__ReturnBuffer;
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

		private static uint __ModifiedEventDynamic = 0;

		private static uint __LegacyCurveData = 0;

		private static uint __AnimatedBoneAttributes = 0;

		private static uint __MovieScene = 0;

		private static uint __CurveIdentifierToMetaData = 0;

		private static uint __bPopulated = 0;

		private static uint __CachedRawDataGUID = 0;

		private static uint __IsValidBoneTrackName = 0;

		private static uint __IsValidBoneTrackIndex = 0;

		private static uint __GetPlayLength = 0;

		private static uint __GetNumBoneTracks = 0;

		private static uint __GetNumberOfTransformCurves = 0;

		private static uint __GetNumberOfKeys = 0;

		private static uint __GetNumberOfFrames = 0;

		private static uint __GetNumberOfFloatCurves = 0;

		private static uint __GetFrameRate = 0;

		private static uint __GetBoneTrackNames = 0;

		private static uint __GetBoneTrackIndexByName = 0;

		private static uint __GetBoneTrackIndex = 0;

		private static uint __GetBoneTrackByName = 0;

		private static uint __GetBoneTrackByIndex = 0;

		private static uint __GetBoneAnimationTracks = 0;

		private static uint __GetAnimationSequence = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}