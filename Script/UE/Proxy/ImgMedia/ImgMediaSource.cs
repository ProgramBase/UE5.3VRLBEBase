using Script.CoreUObject;
using Script.MediaAssets;
using Script.Library;
using Script.Engine;

namespace Script.ImgMedia
{
	[PathName("/Script/ImgMedia.ImgMediaSource")]
	public partial class UImgMediaSource : UBaseMediaSource, IStaticClass
	{
		public FFrameRate FrameRateOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FrameRateOverride, __ReturnBuffer);

					return *(FFrameRate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FrameRateOverride, __InBuffer);
				}
			}
		}

		public FString ProxyOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ProxyOverride, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ProxyOverride, __InBuffer);
				}
			}
		}

		public bool bFillGapsInSequence
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bFillGapsInSequence, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bFillGapsInSequence, __InBuffer);
				}
			}
		}

		public FImgMediaSourceCustomizationSequenceProxy SequenceProxy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SequenceProxy, __ReturnBuffer);

					return *(FImgMediaSourceCustomizationSequenceProxy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SequenceProxy, __InBuffer);
				}
			}
		}

		public FDirectoryPath SequencePath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SequencePath, __ReturnBuffer);

					return *(FDirectoryPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SequencePath, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ImgMedia.ImgMediaSource");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Path">
		/// The path to the desired image sequence directory. May contain supported tokens.
		/// </param>
		/// <see>
		/// GetSequencePath
		/// </see>
		public virtual void SetTokenizedSequencePath(FString Path)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Path?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTokenizedSequencePath, __InBuffer);
			}
		}

		/// <param name="Path">
		/// The path to an image file in the desired directory.
		/// </param>
		/// <see>
		/// GetSequencePath
		/// </see>
		public virtual void SetSequencePath(FString Path)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Path?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSequencePath, __InBuffer);
			}
		}

		public virtual void SetMipLevelDistance(float Distance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Distance;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMipLevelDistance, __InBuffer);
			}
		}

		/// <param name="InActor">
		/// Object no longer using our img sequence.
		/// </param>
		public virtual void RemoveTargetObject(AActor InActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveTargetObject, __InBuffer);
			}
		}

		public virtual void RemoveGlobalCamera(AActor InActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveGlobalCamera, __InBuffer);
			}
		}

		/// <see>
		/// SetSequencePath
		/// </see>
		/// <returns>
		/// The file path.
		/// </returns>
		public virtual FString GetSequencePath()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSequencePath, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="OutProxies">
		/// Will contain the names of available proxy directories, if any.
		/// </param>
		/// <see>
		/// GetSequencePath
		/// </see>
		public virtual void GetProxies(ref TArray<FString> OutProxies)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutProxies?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetProxies, __InBuffer, __OutBuffer);

				OutProxies = *(TArray<FString>*)(__OutBuffer);

			}
		}

		/// <param name="InActor">
		/// Object using our img sequence.
		/// </param>
		public virtual void AddTargetObject(AActor InActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddTargetObject, __InBuffer);
			}
		}

		public virtual void AddGlobalCamera(AActor InActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddGlobalCamera, __InBuffer);
			}
		}

		private static uint __FrameRateOverride = 0;

		private static uint __ProxyOverride = 0;

		private static uint __bFillGapsInSequence = 0;

		private static uint __SequenceProxy = 0;

		private static uint __SequencePath = 0;

		private static uint __SetTokenizedSequencePath = 0;

		private static uint __SetSequencePath = 0;

		private static uint __SetMipLevelDistance = 0;

		private static uint __RemoveTargetObject = 0;

		private static uint __RemoveGlobalCamera = 0;

		private static uint __GetSequencePath = 0;

		private static uint __GetProxies = 0;

		private static uint __AddTargetObject = 0;

		private static uint __AddGlobalCamera = 0;
	}
}