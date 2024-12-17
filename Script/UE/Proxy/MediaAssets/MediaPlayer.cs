using Script.CoreUObject;
using Script.Library;
using Script.MediaUtils;
using Script.Engine;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.MediaPlayer")]
	public partial class UMediaPlayer : UObject, IStaticClass
	{
		public FOnMediaPlayerMediaEvent OnEndReached
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnEndReached, __ReturnBuffer);

					return *(FOnMediaPlayerMediaEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnEndReached, __InBuffer);
				}
			}
		}

		public FOnMediaPlayerMediaEvent OnMediaClosed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnMediaClosed, __ReturnBuffer);

					return *(FOnMediaPlayerMediaEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnMediaClosed, __InBuffer);
				}
			}
		}

		public FOnMediaPlayerMediaOpened OnMediaOpened
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnMediaOpened, __ReturnBuffer);

					return *(FOnMediaPlayerMediaOpened*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnMediaOpened, __InBuffer);
				}
			}
		}

		public FOnMediaPlayerMediaOpenFailed OnMediaOpenFailed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnMediaOpenFailed, __ReturnBuffer);

					return *(FOnMediaPlayerMediaOpenFailed*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnMediaOpenFailed, __InBuffer);
				}
			}
		}

		public FOnMediaPlayerMediaEvent OnPlaybackResumed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPlaybackResumed, __ReturnBuffer);

					return *(FOnMediaPlayerMediaEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPlaybackResumed, __InBuffer);
				}
			}
		}

		public FOnMediaPlayerMediaEvent OnPlaybackSuspended
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPlaybackSuspended, __ReturnBuffer);

					return *(FOnMediaPlayerMediaEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPlaybackSuspended, __InBuffer);
				}
			}
		}

		public FOnMediaPlayerMediaEvent OnSeekCompleted
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSeekCompleted, __ReturnBuffer);

					return *(FOnMediaPlayerMediaEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnSeekCompleted, __InBuffer);
				}
			}
		}

		public FOnMediaPlayerMediaEvent OnTracksChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnTracksChanged, __ReturnBuffer);

					return *(FOnMediaPlayerMediaEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnTracksChanged, __InBuffer);
				}
			}
		}

		public FOnMediaPlayerMediaEvent OnMetadataChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnMetadataChanged, __ReturnBuffer);

					return *(FOnMediaPlayerMediaEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnMetadataChanged, __InBuffer);
				}
			}
		}

		public FTimespan CacheAhead
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CacheAhead, __ReturnBuffer);

					return *(FTimespan*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CacheAhead, __InBuffer);
				}
			}
		}

		public FTimespan CacheBehind
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CacheBehind, __ReturnBuffer);

					return *(FTimespan*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CacheBehind, __InBuffer);
				}
			}
		}

		public FTimespan CacheBehindGame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CacheBehindGame, __ReturnBuffer);

					return *(FTimespan*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CacheBehindGame, __InBuffer);
				}
			}
		}

		public bool NativeAudioOut
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NativeAudioOut, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NativeAudioOut, __InBuffer);
				}
			}
		}

		public bool PlayOnOpen
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlayOnOpen, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlayOnOpen, __InBuffer);
				}
			}
		}

		public bool Shuffle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Shuffle, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Shuffle, __InBuffer);
				}
			}
		}

		public bool Loop
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Loop, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Loop, __InBuffer);
				}
			}
		}

		public UMediaPlaylist Playlist
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Playlist, __ReturnBuffer);

					return *(UMediaPlaylist*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Playlist, __InBuffer);
				}
			}
		}

		public int PlaylistIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlaylistIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlaylistIndex, __InBuffer);
				}
			}
		}

		public FTimespan TimeDelay
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TimeDelay, __ReturnBuffer);

					return *(FTimespan*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TimeDelay, __InBuffer);
				}
			}
		}

		public float HorizontalFieldOfView
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HorizontalFieldOfView, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HorizontalFieldOfView, __InBuffer);
				}
			}
		}

		public float VerticalFieldOfView
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VerticalFieldOfView, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VerticalFieldOfView, __InBuffer);
				}
			}
		}

		public FRotator ViewRotation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ViewRotation, __ReturnBuffer);

					return *(FRotator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ViewRotation, __InBuffer);
				}
			}
		}

		public FGuid PlayerGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerGuid, __InBuffer);
				}
			}
		}

		public bool AffectedByPIEHandling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AffectedByPIEHandling, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AffectedByPIEHandling, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaAssets.MediaPlayer");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <see>
		/// SupportsRate, SupportsScrubbing
		/// </see>
		/// <returns>
		/// true if seeking is supported, false otherwise.
		/// </returns>
		public virtual bool SupportsSeeking()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __SupportsSeeking, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// SupportsRate, SupportsSeeking
		/// </see>
		/// <returns>
		/// true if scrubbing is supported, false otherwise.
		/// </returns>
		public virtual bool SupportsScrubbing()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __SupportsScrubbing, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Rate">
		/// The playback rate to check.
		/// </param>
		/// <param name="Unthinned">
		/// Whether no frames should be dropped at the given rate.
		/// </param>
		/// <see>
		/// SupportsScrubbing, SupportsSeeking
		/// </see>
		public virtual bool SupportsRate(float Rate, bool Unthinned)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = Rate;

				*(bool*)(__InBuffer + 4) = Unthinned;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SupportsRate, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Rotation">
		/// The desired view rotation.
		/// </param>
		/// <param name="Whether">
		/// the rotation change should be absolute (true) or relative (false).
		/// </param>
		/// <see>
		/// GetViewRotation, SetViewField
		/// </see>
		/// <returns>
		/// true on success, false otherwise.
		/// </returns>
		public virtual bool SetViewRotation(FRotator Rotation, bool Absolute)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = Absolute;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetViewRotation, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Horizontal">
		/// Horizontal field of view (in Euler degrees).
		/// </param>
		/// <param name="Vertical">
		/// Vertical field of view (in Euler degrees).
		/// </param>
		/// <param name="Whether">
		/// the field of view change should be absolute (true) or relative (false).
		/// </param>
		/// <see>
		/// GetHorizontalFieldOfView, GetVerticalFieldOfView, SetViewRotation
		/// </see>
		/// <returns>
		/// true on success, false otherwise.
		/// </returns>
		public virtual bool SetViewField(float Horizontal, float Vertical, bool Absolute)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(float*)(__InBuffer) = Horizontal;

				*(float*)(__InBuffer + 4) = Vertical;

				*(bool*)(__InBuffer + 8) = Absolute;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetViewField, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TrackIndex">
		/// The index of the track, or INDEX_NONE for the selected one.
		/// </param>
		/// <param name="FormatIndex">
		/// Index of the track format, or INDEX_NONE for the selected one.
		/// </param>
		/// <param name="FrameRate">
		/// The frame rate to set (must be in range of format's supported frame rates).
		/// </param>
		/// <see>
		/// GetVideoTrackAspectRatio, GetVideoTrackDimensions, GetVideoTrackFrameRate, GetVideoTrackFrameRates, GetVideoTrackType
		/// </see>
		/// <returns>
		/// true on success, false otherwise.
		/// </returns>
		public virtual bool SetVideoTrackFrameRate(int TrackIndex, int FormatIndex, float FrameRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = TrackIndex;

				*(int*)(__InBuffer + 4) = FormatIndex;

				*(float*)(__InBuffer + 8) = FrameRate;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetVideoTrackFrameRate, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TrackType">
		/// The type of track to update.
		/// </param>
		/// <param name="TrackIndex">
		/// The index of the track to update.
		/// </param>
		/// <param name="FormatIndex">
		/// The index of the format to select (must be valid).
		/// </param>
		/// <see>
		/// GetNumTrackFormats, GetNumTracks, GetTrackFormat, SelectTrack
		/// </see>
		/// <returns>
		/// true if the track was selected, false otherwise.
		/// </returns>
		public virtual bool SetTrackFormat(EMediaPlayerTrack TrackType, int TrackIndex, int FormatIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)TrackType;

				*(int*)(__InBuffer + 1) = TrackIndex;

				*(int*)(__InBuffer + 5) = FormatIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetTrackFormat, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// GetTimeDelay
		/// </see>
		/// <returns>
		/// true on success, false otherwise.
		/// </returns>
		public virtual void SetTimeDelay(FTimespan TimeDelay)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TimeDelay?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTimeDelay, __InBuffer);
			}
		}

		/// <param name="Rate">
		/// The playback rate to set.
		/// </param>
		/// <see>
		/// GetRate, SupportsRate
		/// </see>
		/// <returns>
		/// true on success, false otherwise.
		/// </returns>
		public virtual bool SetRate(float Rate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Rate;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetRate, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Volume">
		/// The volume to set.
		/// </param>
		/// <see>
		/// NativeAudioOut
		/// </see>
		/// <returns>
		/// true on success, false otherwise.
		/// </returns>
		public virtual bool SetNativeVolume(float Volume)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Volume;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetNativeVolume, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Options">
		/// Options to pass to the player.
		/// </param>
		public virtual void SetMediaOptions(UMediaSource Options)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Options?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMediaOptions, __InBuffer);
			}
		}

		/// <param name="Looping">
		/// Whether playback should be looped.
		/// </param>
		/// <see>
		/// IsLooping
		/// </see>
		/// <returns>
		/// true on success, false otherwise.
		/// </returns>
		public virtual bool SetLooping(bool Looping)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = Looping;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetLooping, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PlayerName">
		/// The name of the player to set.
		/// </param>
		/// <see>
		/// GetDesiredPlayerName
		/// </see>
		public virtual void SetDesiredPlayerName(FName PlayerName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDesiredPlayerName, __InBuffer);
			}
		}

		/// <param name="Time">
		/// The time to block on, or FTimespan::MinValue to disable.
		/// </param>
		public virtual void SetBlockOnTime(FTimespan Time)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Time?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBlockOnTime, __InBuffer);
			}
		}

		/// <param name="TrackType">
		/// The type of track to select.
		/// </param>
		/// <param name="TrackIndex">
		/// The index of the track to select, or INDEX_NONE to deselect.
		/// </param>
		/// <see>
		/// GetNumTracks, GetSelectedTrack, SetTrackFormat
		/// </see>
		/// <returns>
		/// true if the track was selected, false otherwise.
		/// </returns>
		public virtual bool SelectTrack(EMediaPlayerTrack TrackType, int TrackIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(byte*)(__InBuffer) = (byte)TrackType;

				*(int*)(__InBuffer + 1) = TrackIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SelectTrack, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Time">
		/// The playback time to set.
		/// </param>
		/// <see>
		/// GetTime, Rewind
		/// </see>
		/// <returns>
		/// true on success, false otherwise.
		/// </returns>
		public virtual bool Seek(FTimespan Time)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Time?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Seek, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// GetTime, Seek
		/// </see>
		/// <returns>
		/// true if rewinding, false otherwise.
		/// </returns>
		public virtual bool Rewind()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __Rewind, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// Close, Open, OpenFile, OpenPlaylist, OpenPlaylistIndex, OpenSource, OpenUrl
		/// </see>
		/// <returns>
		/// true if the media will be opened, false otherwise.
		/// </returns>
		public virtual bool Reopen()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __Reopen, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// Close, Next, OpenUrl, OpenSource, Play, SetPlaylist
		/// </see>
		/// <returns>
		/// true on success, false otherwise.
		/// </returns>
		public virtual bool Previous()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __Previous, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void PlayAndSeek()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __PlayAndSeek);
			}
		}

		/// <see>
		/// CanPlay, GetRate, Next, Pause, Previous, SetRate
		/// </see>
		/// <returns>
		/// true if playback is starting, false otherwise.
		/// </returns>
		public virtual bool Play()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __Play, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// CanPause, Close, Next, Play, Previous, Rewind, Seek
		/// </see>
		/// <returns>
		/// true if playback is being paused, false otherwise.
		/// </returns>
		public virtual bool Pause()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __Pause, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Url">
		/// The URL to open.
		/// </param>
		/// <see>
		/// GetUrl, Close, OpenFile, OpenPlaylist, OpenPlaylistIndex, OpenSource, Reopen
		/// </see>
		/// <returns>
		/// true if the URL will be opened, false otherwise.
		/// </returns>
		public virtual bool OpenUrl(FString Url)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Url?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __OpenUrl, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="MediaSource">
		/// The media source to open.
		/// </param>
		/// <param name="Options">
		/// The media player options to apply.
		/// </param>
		/// <see>
		/// Close, OpenFile, OpenPlaylist, OpenPlaylistIndex, OpenUrl, Reopen
		/// </see>
		/// <returns>
		/// true if the source will be opened, false otherwise.
		/// </returns>
		public virtual bool OpenSourceWithOptions(UMediaSource MediaSource, FMediaPlayerOptions Options)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MediaSource?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Options?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __OpenSourceWithOptions, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="MediaSource">
		/// The media source to open.
		/// </param>
		/// <param name="Options">
		/// The media player options to apply.
		/// </param>
		/// <param name="bSuccess">
		/// All requested operations have completed successfully.
		/// </param>
		/// <see>
		/// Close, OpenFile, OpenPlaylist, OpenPlaylistIndex, OpenUrl, Reopen
		/// </see>
		public virtual void OpenSourceLatent(UObject WorldContextObject, FLatentActionInfo LatentInfo, UMediaSource MediaSource, FMediaPlayerOptions Options, ref bool bSuccess)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LatentInfo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = MediaSource?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Options?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bSuccess;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __OpenSourceLatent, __InBuffer, __OutBuffer);

				bSuccess = *(bool*)(__OutBuffer);

			}
		}

		/// <param name="MediaSource">
		/// The media source to open.
		/// </param>
		/// <see>
		/// Close, OpenFile, OpenPlaylist, OpenPlaylistIndex, OpenUrl, Reopen
		/// </see>
		/// <returns>
		/// true if the source will be opened, false otherwise.
		/// </returns>
		public virtual bool OpenSource(UMediaSource MediaSource)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MediaSource?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __OpenSource, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InPlaylist">
		/// The play list to open.
		/// </param>
		/// <param name="Index">
		/// The index of the source to open.
		/// </param>
		/// <see>
		/// Close, OpenFile, OpenPlaylist, OpenSource, OpenUrl, Reopen
		/// </see>
		/// <returns>
		/// true if the source will be opened, false otherwise.
		/// </returns>
		public virtual bool OpenPlaylistIndex(UMediaPlaylist InPlaylist, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InPlaylist?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __OpenPlaylistIndex, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InPlaylist">
		/// The play list to open.
		/// </param>
		/// <see>
		/// Close, OpenFile, OpenPlaylistIndex, OpenSource, OpenUrl, Reopen
		/// </see>
		/// <returns>
		/// true if the source will be opened, false otherwise.
		/// </returns>
		public virtual bool OpenPlaylist(UMediaPlaylist InPlaylist)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPlaylist?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __OpenPlaylist, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="FilePath">
		/// The file path to open.
		/// </param>
		/// <see>
		/// GetUrl, Close, OpenPlaylist, OpenPlaylistIndex, OpenSource, OpenUrl, Reopen
		/// </see>
		/// <returns>
		/// true if the file path will be opened, false otherwise.
		/// </returns>
		public virtual bool OpenFile(FString FilePath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = FilePath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __OpenFile, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// Close, OpenUrl, OpenSource, Play, Previous, SetPlaylist
		/// </see>
		/// <returns>
		/// true on success, false otherwise.
		/// </returns>
		public virtual bool Next()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __Next, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// HasError, IsBuffering, IsConnecting, IsLooping, IsPaused, IsPlaying, IsPreparing
		/// </see>
		/// <returns>
		/// true if media is ready, false otherwise.
		/// </returns>
		public virtual bool IsReady()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsReady, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// CanPlay, IsBuffering, IsConnecting, IsLooping, IsPaused, IsPlaying, IsReady, Play
		/// </see>
		/// <returns>
		/// true if playback is being prepared, false otherwise.
		/// </returns>
		public virtual bool IsPreparing()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPreparing, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// CanPlay, IsBuffering, IsConnecting, IsLooping, IsPaused, IsPlaying, IsPreparing, IsReady, Play
		/// </see>
		/// <returns>
		/// true if playback has started, false otherwise.
		/// </returns>
		public virtual bool IsPlaying()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPlaying, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// CanPause, IsBuffering, IsConnecting, IsLooping, IsPaused, IsPlaying, IsPreparing, IsReady, Pause
		/// </see>
		/// <returns>
		/// true if playback is paused, false otherwise.
		/// </returns>
		public virtual bool IsPaused()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPaused, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// IsBuffering, IsConnecting, IsPaused, IsPlaying, IsPreparing, IsReady, SetLooping
		/// </see>
		/// <returns>
		/// true if looping, false otherwise.
		/// </returns>
		public virtual bool IsLooping()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsLooping, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// IsBuffering, IsLooping, IsPaused, IsPlaying, IsPreparing, IsReady
		/// </see>
		/// <returns>
		/// true if connecting, false otherwise.
		/// </returns>
		public virtual bool IsConnecting()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsConnecting, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if media is closed, false otherwise.
		/// </returns>
		public virtual bool IsClosed()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsClosed, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// IsConnecting, IsLooping, IsPaused, IsPlaying, IsPreparing, IsReady
		/// </see>
		/// <returns>
		/// true if looping, false otherwise.
		/// </returns>
		public virtual bool IsBuffering()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsBuffering, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// IsReady
		/// </see>
		public virtual bool HasError()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasError, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// GetHorizontalFieldOfView, GetVerticalFieldOfView, SetViewRotation
		/// </see>
		/// <returns>
		/// View rotation, or zero rotator if not available.
		/// </returns>
		public virtual FRotator GetViewRotation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetViewRotation, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		/// <param name="TrackIndex">
		/// The index of the track, or INDEX_NONE for the selected one.
		/// </param>
		/// <param name="FormatIndex">
		/// Index of the track format, or INDEX_NONE for the selected one.
		/// </param>
		/// <see>
		/// GetVideoTrackAspectRatio, GetVideoTrackDimensions, GetVideoTrackFrameRate, GetVideoTrackFrameRates
		/// </see>
		/// <returns>
		/// Video format type string.
		/// </returns>
		public virtual FString GetVideoTrackType(int TrackIndex, int FormatIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = TrackIndex;

				*(int*)(__InBuffer + 4) = FormatIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVideoTrackType, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="TrackIndex">
		/// The index of the track, or INDEX_NONE for the selected one.
		/// </param>
		/// <param name="FormatIndex">
		/// Index of the track format, or INDEX_NONE for the selected one.
		/// </param>
		/// <see>
		/// GetVideoTrackAspectRatio, GetVideoTrackDimensions, GetVideoTrackFrameRate, GetVideoTrackType
		/// </see>
		/// <returns>
		/// Frame rate range (in frames per second).
		/// </returns>
		public virtual FFloatRange GetVideoTrackFrameRates(int TrackIndex, int FormatIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = TrackIndex;

				*(int*)(__InBuffer + 4) = FormatIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVideoTrackFrameRates, __InBuffer, __ReturnBuffer);

				return *(FFloatRange*)__ReturnBuffer;
			}
		}

		/// <param name="TrackIndex">
		/// The index of the track, or INDEX_NONE for the selected one.
		/// </param>
		/// <param name="FormatIndex">
		/// Index of the track format, or INDEX_NONE for the selected one.
		/// </param>
		/// <see>
		/// GetVideoTrackAspectRatio, GetVideoTrackDimensions, GetVideoTrackFrameRates, GetVideoTrackType, SetVideoTrackFrameRate
		/// </see>
		/// <returns>
		/// Frame rate (in frames per second).
		/// </returns>
		public virtual float GetVideoTrackFrameRate(int TrackIndex, int FormatIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = TrackIndex;

				*(int*)(__InBuffer + 4) = FormatIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetVideoTrackFrameRate, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="TrackIndex">
		/// The index of the track, or INDEX_NONE for the selected one.
		/// </param>
		/// <param name="FormatIndex">
		/// Index of the track format, or INDEX_NONE for the selected one.
		/// </param>
		/// <see>
		/// GetVideoTrackAspectRatio, GetVideoTrackFrameRate, GetVideoTrackFrameRates, GetVideoTrackType
		/// </see>
		/// <returns>
		/// Video dimensions (in pixels).
		/// </returns>
		public virtual FIntPoint GetVideoTrackDimensions(int TrackIndex, int FormatIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = TrackIndex;

				*(int*)(__InBuffer + 4) = FormatIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVideoTrackDimensions, __InBuffer, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		/// <param name="TrackIndex">
		/// Index of the video track, or INDEX_NONE for the selected one.
		/// </param>
		/// <param name="FormatIndex">
		/// Index of the track format, or INDEX_NONE for the selected one.
		/// </param>
		/// <see>
		/// GetVideoTrackDimensions, GetVideoTrackFrameRate, GetVideoTrackFrameRates, GetVideoTrackType
		/// </see>
		/// <returns>
		/// Aspect ratio.
		/// </returns>
		public virtual float GetVideoTrackAspectRatio(int TrackIndex, int FormatIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = TrackIndex;

				*(int*)(__InBuffer + 4) = FormatIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetVideoTrackAspectRatio, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <see>
		/// GetHorizontalFieldOfView, GetViewRotation, SetVerticalFieldOfView
		/// </see>
		/// <returns>
		/// Vertical field of view (in Euler degrees), or 0.0 if not available.
		/// </returns>
		public virtual float GetVerticalFieldOfView()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetVerticalFieldOfView, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <see>
		/// OpenUrl
		/// </see>
		/// <returns>
		/// Media URL, or empty string if no media was loaded.
		/// </returns>
		public virtual FString GetUrl()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetUrl, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="TrackType">
		/// The type of track.
		/// </param>
		/// <param name="TrackIndex">
		/// The index of the track, or INDEX_NONE for the selected one.
		/// </param>
		/// <see>
		/// GetNumTracks, GetTrackDisplayName
		/// </see>
		/// <returns>
		/// Language tag, i.e. "en-US" for English, or "und" for undefined.
		/// </returns>
		public virtual FString GetTrackLanguage(EMediaPlayerTrack TrackType, int TrackIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(byte*)(__InBuffer) = (byte)TrackType;

				*(int*)(__InBuffer + 1) = TrackIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTrackLanguage, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="TrackType">
		/// The type of track.
		/// </param>
		/// <param name="TrackIndex">
		/// The index of the track, or INDEX_NONE for the selected one.
		/// </param>
		/// <see>
		/// GetNumTrackFormats, GetSelectedTrack, SetTrackFormat
		/// </see>
		/// <returns>
		/// The index of the selected format.
		/// </returns>
		public virtual int GetTrackFormat(EMediaPlayerTrack TrackType, int TrackIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(byte*)(__InBuffer) = (byte)TrackType;

				*(int*)(__InBuffer + 1) = TrackIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetTrackFormat, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="TrackType">
		/// The type of track.
		/// </param>
		/// <param name="TrackIndex">
		/// The index of the track, or INDEX_NONE for the selected one.
		/// </param>
		/// <see>
		/// GetNumTracks, GetTrackLanguage
		/// </see>
		/// <returns>
		/// Display name.
		/// </returns>
		public virtual FText GetTrackDisplayName(EMediaPlayerTrack TrackType, int TrackIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(byte*)(__InBuffer) = (byte)TrackType;

				*(int*)(__InBuffer + 1) = TrackIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTrackDisplayName, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		/// <see>
		/// GetDuration, Seek
		/// </see>
		/// <returns>
		/// Playback timestamp.
		/// </returns>
		public virtual UMediaTimeStampInfo GetTimeStamp()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTimeStamp, __ReturnBuffer);

				return *(UMediaTimeStampInfo*)__ReturnBuffer;
			}
		}

		/// <see>
		/// SetTimeDelay
		/// </see>
		/// <returns>
		/// Delay added to the player's time used to manually sync multiple sources.
		/// </returns>
		public virtual FTimespan GetTimeDelay()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTimeDelay, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		/// <see>
		/// GetDuration, Seek
		/// </see>
		/// <returns>
		/// Playback time.
		/// </returns>
		public virtual FTimespan GetTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTime, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		/// <param name="Unthinned">
		/// Whether the rates are for unthinned playback.
		/// </param>
		/// <param name="Will">
		/// contain the the ranges of supported rates.
		/// </param>
		/// <see>
		/// SetRate, SupportsRate
		/// </see>
		public virtual void GetSupportedRates(ref TArray<FFloatRange> OutRates, bool Unthinned)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = OutRates?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = Unthinned;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetSupportedRates, __InBuffer, __OutBuffer);

				OutRates = *(TArray<FFloatRange>*)(__OutBuffer);

			}
		}

		/// <param name="TrackType">
		/// The type of track to get.
		/// </param>
		/// <see>
		/// GetNumTracks, GetTrackFormat, SelectTrack
		/// </see>
		/// <returns>
		/// The index of the selected track, or INDEX_NONE if no track is active.
		/// </returns>
		public virtual int GetSelectedTrack(EMediaPlayerTrack TrackType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)TrackType;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetSelectedTrack, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <see>
		/// SetRate, SupportsRate
		/// </see>
		/// <returns>
		/// The playback rate.
		/// </returns>
		public virtual float GetRate()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetRate, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <see>
		/// GetPlaylist
		/// </see>
		/// <returns>
		/// Play list index.
		/// </returns>
		public virtual int GetPlaylistIndex()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPlaylistIndex, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <see>
		/// GetPlaylistIndex, GetPlaylistRef
		/// </see>
		/// <returns>
		/// The play list.
		/// </returns>
		public virtual UMediaPlaylist GetPlaylist()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPlaylist, __ReturnBuffer);

				return *(UMediaPlaylist*)__ReturnBuffer;
			}
		}

		/// <see>
		/// GetMediaName
		/// </see>
		/// <returns>
		/// Player name, or NAME_None if not available.
		/// </returns>
		public virtual FName GetPlayerName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPlayerName, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		/// <param name="TrackType">
		/// The type of media tracks.
		/// </param>
		/// <see>
		/// GetNumTrackFormats, GetSelectedTrack, SelectTrack
		/// </see>
		/// <returns>
		/// Number of tracks.
		/// </returns>
		public virtual int GetNumTracks(EMediaPlayerTrack TrackType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)TrackType;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumTracks, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="TrackType">
		/// The type of media tracks.
		/// </param>
		/// <param name="TrackIndex">
		/// The index of the track.
		/// </param>
		/// <see>
		/// GetNumTracks, GetSelectedTrack, SelectTrack
		/// </see>
		/// <returns>
		/// Number of formats.
		/// </returns>
		public virtual int GetNumTrackFormats(EMediaPlayerTrack TrackType, int TrackIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(byte*)(__InBuffer) = (byte)TrackType;

				*(int*)(__InBuffer + 1) = TrackIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumTrackFormats, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <see>
		/// GetPlayerName, GetUrl
		/// </see>
		/// <returns>
		/// Media source name, or empty text if no media is opened
		/// </returns>
		public virtual FText GetMediaName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMediaName, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Listen to EMediaEvent::MetadataChanged to catch updates to this data
		/// </note>
		/// <returns>
		/// Map with arrays of FMediaMetaDataItem entries describing any metadata found in the current stream
		/// </returns>
		public virtual TMap<FString, FMediaMetadataItemsBPT> GetMediaMetadataItems()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMediaMetadataItems, __ReturnBuffer);

				return *(TMap<FString, FMediaMetadataItemsBPT>*)__ReturnBuffer;
			}
		}

		/// <see>
		/// GetVerticalFieldOfView, GetViewRotation, SetHorizontalFieldOfView
		/// </see>
		/// <returns>
		/// Horizontal field of view (in Euler degrees).
		/// </returns>
		public virtual float GetHorizontalFieldOfView()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetHorizontalFieldOfView, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <see>
		/// GetTime, Seek
		/// </see>
		/// <returns>
		/// A time span representing the duration.
		/// </returns>
		public virtual FTimespan GetDuration()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDuration, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		/// <see>
		/// GetDuration, Seek
		/// </see>
		/// <returns>
		/// Playback timestamp.
		/// </returns>
		public virtual UMediaTimeStampInfo GetDisplayTimeStamp()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDisplayTimeStamp, __ReturnBuffer);

				return *(UMediaTimeStampInfo*)__ReturnBuffer;
			}
		}

		/// <see>
		/// GetDuration, Seek
		/// </see>
		/// <returns>
		/// Playback time.
		/// </returns>
		public virtual FTimespan GetDisplayTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDisplayTime, __ReturnBuffer);

				return *(FTimespan*)__ReturnBuffer;
			}
		}

		/// <see>
		/// SetDesiredPlayerName
		/// </see>
		/// <returns>
		/// The name of the desired player, or NAME_None if not set.
		/// </returns>
		public virtual FName GetDesiredPlayerName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDesiredPlayerName, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		/// <param name="TrackIndex">
		/// The index of the track, or INDEX_NONE for the selected one.
		/// </param>
		/// <param name="FormatIndex">
		/// Index of the track format, or INDEX_NONE for the selected one.
		/// </param>
		/// <see>
		/// GetAudioTrackSampleRate, GetAudioTrackSampleRate
		/// </see>
		/// <returns>
		/// Audio format type string.
		/// </returns>
		public virtual FString GetAudioTrackType(int TrackIndex, int FormatIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = TrackIndex;

				*(int*)(__InBuffer + 4) = FormatIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetAudioTrackType, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="TrackIndex">
		/// Index of the audio track, or INDEX_NONE for the selected one.
		/// </param>
		/// <param name="FormatIndex">
		/// Index of the track format, or INDEX_NONE for the selected one.
		/// </param>
		/// <see>
		/// GetAudioTrackChannels, GetAudioTrackType
		/// </see>
		/// <returns>
		/// Samples per second.
		/// </returns>
		public virtual int GetAudioTrackSampleRate(int TrackIndex, int FormatIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = TrackIndex;

				*(int*)(__InBuffer + 4) = FormatIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetAudioTrackSampleRate, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="TrackIndex">
		/// Index of the audio track, or INDEX_NONE for the selected one.
		/// </param>
		/// <param name="FormatIndex">
		/// Index of the track format, or INDEX_NONE for the selected one.
		/// </param>
		/// <see>
		/// GetAudioTrackSampleRate, GetAudioTrackType
		/// </see>
		/// <returns>
		/// Number of channels.
		/// </returns>
		public virtual int GetAudioTrackChannels(int TrackIndex, int FormatIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = TrackIndex;

				*(int*)(__InBuffer + 4) = FormatIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetAudioTrackChannels, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <see>
		/// OnMediaClosed, OpenPlaylist, OpenPlaylistIndex, OpenSource, OpenUrl, Pause, Play
		/// </see>
		public virtual void Close()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Close);
			}
		}

		/// <param name="Url">
		/// The URL to check.
		/// </param>
		/// <see>
		/// CanPlaySource, SetDesiredPlayerName
		/// </see>
		public virtual bool CanPlayUrl(FString Url)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Url?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CanPlayUrl, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="MediaSource">
		/// The media source to check.
		/// </param>
		/// <see>
		/// CanPlayUrl, SetDesiredPlayerName
		/// </see>
		/// <returns>
		/// true if the media source can be opened, false otherwise.
		/// </returns>
		public virtual bool CanPlaySource(UMediaSource MediaSource)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MediaSource?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CanPlaySource, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// CanPlay, Pause
		/// </see>
		/// <returns>
		/// true if pausing playback can be paused, false otherwise.
		/// </returns>
		public virtual bool CanPause()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __CanPause, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __OnEndReached = 0;

		private static uint __OnMediaClosed = 0;

		private static uint __OnMediaOpened = 0;

		private static uint __OnMediaOpenFailed = 0;

		private static uint __OnPlaybackResumed = 0;

		private static uint __OnPlaybackSuspended = 0;

		private static uint __OnSeekCompleted = 0;

		private static uint __OnTracksChanged = 0;

		private static uint __OnMetadataChanged = 0;

		private static uint __CacheAhead = 0;

		private static uint __CacheBehind = 0;

		private static uint __CacheBehindGame = 0;

		private static uint __NativeAudioOut = 0;

		private static uint __PlayOnOpen = 0;

		private static uint __Shuffle = 0;

		private static uint __Loop = 0;

		private static uint __Playlist = 0;

		private static uint __PlaylistIndex = 0;

		private static uint __TimeDelay = 0;

		private static uint __HorizontalFieldOfView = 0;

		private static uint __VerticalFieldOfView = 0;

		private static uint __ViewRotation = 0;

		private static uint __PlayerGuid = 0;

		private static uint __AffectedByPIEHandling = 0;

		private static uint __SupportsSeeking = 0;

		private static uint __SupportsScrubbing = 0;

		private static uint __SupportsRate = 0;

		private static uint __SetViewRotation = 0;

		private static uint __SetViewField = 0;

		private static uint __SetVideoTrackFrameRate = 0;

		private static uint __SetTrackFormat = 0;

		private static uint __SetTimeDelay = 0;

		private static uint __SetRate = 0;

		private static uint __SetNativeVolume = 0;

		private static uint __SetMediaOptions = 0;

		private static uint __SetLooping = 0;

		private static uint __SetDesiredPlayerName = 0;

		private static uint __SetBlockOnTime = 0;

		private static uint __SelectTrack = 0;

		private static uint __Seek = 0;

		private static uint __Rewind = 0;

		private static uint __Reopen = 0;

		private static uint __Previous = 0;

		private static uint __PlayAndSeek = 0;

		private static uint __Play = 0;

		private static uint __Pause = 0;

		private static uint __OpenUrl = 0;

		private static uint __OpenSourceWithOptions = 0;

		private static uint __OpenSourceLatent = 0;

		private static uint __OpenSource = 0;

		private static uint __OpenPlaylistIndex = 0;

		private static uint __OpenPlaylist = 0;

		private static uint __OpenFile = 0;

		private static uint __Next = 0;

		private static uint __IsReady = 0;

		private static uint __IsPreparing = 0;

		private static uint __IsPlaying = 0;

		private static uint __IsPaused = 0;

		private static uint __IsLooping = 0;

		private static uint __IsConnecting = 0;

		private static uint __IsClosed = 0;

		private static uint __IsBuffering = 0;

		private static uint __HasError = 0;

		private static uint __GetViewRotation = 0;

		private static uint __GetVideoTrackType = 0;

		private static uint __GetVideoTrackFrameRates = 0;

		private static uint __GetVideoTrackFrameRate = 0;

		private static uint __GetVideoTrackDimensions = 0;

		private static uint __GetVideoTrackAspectRatio = 0;

		private static uint __GetVerticalFieldOfView = 0;

		private static uint __GetUrl = 0;

		private static uint __GetTrackLanguage = 0;

		private static uint __GetTrackFormat = 0;

		private static uint __GetTrackDisplayName = 0;

		private static uint __GetTimeStamp = 0;

		private static uint __GetTimeDelay = 0;

		private static uint __GetTime = 0;

		private static uint __GetSupportedRates = 0;

		private static uint __GetSelectedTrack = 0;

		private static uint __GetRate = 0;

		private static uint __GetPlaylistIndex = 0;

		private static uint __GetPlaylist = 0;

		private static uint __GetPlayerName = 0;

		private static uint __GetNumTracks = 0;

		private static uint __GetNumTrackFormats = 0;

		private static uint __GetMediaName = 0;

		private static uint __GetMediaMetadataItems = 0;

		private static uint __GetHorizontalFieldOfView = 0;

		private static uint __GetDuration = 0;

		private static uint __GetDisplayTimeStamp = 0;

		private static uint __GetDisplayTime = 0;

		private static uint __GetDesiredPlayerName = 0;

		private static uint __GetAudioTrackType = 0;

		private static uint __GetAudioTrackSampleRate = 0;

		private static uint __GetAudioTrackChannels = 0;

		private static uint __Close = 0;

		private static uint __CanPlayUrl = 0;

		private static uint __CanPlaySource = 0;

		private static uint __CanPause = 0;
	}
}