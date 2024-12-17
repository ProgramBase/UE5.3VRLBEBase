using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;
using Script.Engine;

namespace Script.TakesCore
{
	[PathName("/Script/TakesCore.TakeMetaData")]
	public partial class UTakeMetaData : UObject, IStaticClass, IMovieSceneMetaDataInterface
	{
		public bool bIsLocked
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsLocked, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsLocked, __InBuffer);
				}
			}
		}

		public FString Slate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Slate, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Slate, __InBuffer);
				}
			}
		}

		public int TakeNumber
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TakeNumber, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TakeNumber, __InBuffer);
				}
			}
		}

		public FDateTime Timestamp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Timestamp, __ReturnBuffer);

					return *(FDateTime*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Timestamp, __InBuffer);
				}
			}
		}

		public FTimecode TimecodeIn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TimecodeIn, __ReturnBuffer);

					return *(FTimecode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TimecodeIn, __InBuffer);
				}
			}
		}

		public FTimecode TimecodeOut
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TimecodeOut, __ReturnBuffer);

					return *(FTimecode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TimecodeOut, __InBuffer);
				}
			}
		}

		public FFrameTime Duration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Duration, __ReturnBuffer);

					return *(FFrameTime*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Duration, __InBuffer);
				}
			}
		}

		public FFrameRate FrameRate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FrameRate, __ReturnBuffer);

					return *(FFrameRate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FrameRate, __InBuffer);
				}
			}
		}

		public FString Description
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Description, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Description, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UTakePreset> PresetOrigin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PresetOrigin, __ReturnBuffer);

					return *(TSoftObjectPtr<UTakePreset>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PresetOrigin, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<ULevel> LevelOrigin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LevelOrigin, __ReturnBuffer);

					return *(TSoftObjectPtr<ULevel>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LevelOrigin, __InBuffer);
				}
			}
		}

		public bool bFrameRateFromTimecode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bFrameRateFromTimecode, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bFrameRateFromTimecode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakesCore.TakeMetaData");
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

		public virtual void Unlock()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Unlock);
			}
		}

		/// <note>
		/// : Only valid for takes that have not been locked
		/// </note>
		public virtual void SetTimestamp(FDateTime InTimestamp)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTimestamp?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTimestamp, __InBuffer);
			}
		}

		/// <note>
		/// : Only valid for takes that have not been locked
		/// </note>
		public virtual void SetTimecodeOut(FTimecode InTimecodeOut)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTimecodeOut?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTimecodeOut, __InBuffer);
			}
		}

		/// <note>
		/// : Only valid for takes that have not been locked
		/// </note>
		public virtual void SetTimecodeIn(FTimecode InTimecodeIn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTimecodeIn?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTimecodeIn, __InBuffer);
			}
		}

		/// <param name="bEmitChanged">
		/// Whether or not to send a take number changed event
		/// </param>
		/// <note>
		/// : Only valid for takes that have not been locked
		/// </note>
		public virtual void SetTakeNumber(int InTakeNumber, bool bEmitChanged = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = InTakeNumber;

				*(bool*)(__InBuffer + 4) = bEmitChanged;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTakeNumber, __InBuffer);
			}
		}

		/// <param name="bEmitChanged">
		/// Whether or not to send a slate changed event
		/// </param>
		/// <note>
		/// : Only valid for takes that have not been locked
		/// </note>
		public virtual void SetSlate(FString InSlate, bool bEmitChanged = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InSlate?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bEmitChanged;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSlate, __InBuffer);
			}
		}

		/// <note>
		/// : Only valid for takes that have not been locked
		/// </note>
		public virtual void SetPresetOrigin(UTakePreset InPresetOrigin)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPresetOrigin?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPresetOrigin, __InBuffer);
			}
		}

		public virtual void SetLevelOrigin(ULevel InLevelOrigin)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InLevelOrigin?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLevelOrigin, __InBuffer);
			}
		}

		public virtual void SetFrameRateFromTimecode(bool InFromTimecode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InFromTimecode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFrameRateFromTimecode, __InBuffer);
			}
		}

		/// <note>
		/// : Only valid for takes that have not been locked
		/// </note>
		public virtual void SetFrameRate(FFrameRate InFrameRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFrameRate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFrameRate, __InBuffer);
			}
		}

		/// <note>
		/// : Only valid for takes that have not been locked
		/// </note>
		public virtual void SetDuration(FFrameTime InDuration)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDuration?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDuration, __InBuffer);
			}
		}

		/// <note>
		/// : Only valid for takes that have not been locked
		/// </note>
		public virtual void SetDescription(FString InDescription)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDescription?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDescription, __InBuffer);
			}
		}

		public virtual bool Recorded()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __Recorded, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void Lock()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Lock);
			}
		}

		public virtual bool IsLocked()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsLocked, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The timestamp for this take
		/// </returns>
		public virtual FDateTime GetTimestamp()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTimestamp, __ReturnBuffer);

				return *(FDateTime*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The timecode out for this take
		/// </returns>
		public virtual FTimecode GetTimecodeOut()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTimecodeOut, __ReturnBuffer);

				return *(FTimecode*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The timecode in for this take
		/// </returns>
		public virtual FTimecode GetTimecodeIn()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTimecodeIn, __ReturnBuffer);

				return *(FTimecode*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The take number for this take
		/// </returns>
		public virtual int GetTakeNumber()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTakeNumber, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The slate for this take
		/// </returns>
		public virtual FString GetSlate()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSlate, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The preset on which the take was originally based
		/// </returns>
		public virtual UTakePreset GetPresetOrigin()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPresetOrigin, __ReturnBuffer);

				return *(UTakePreset*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The AssetPath of the Level used to create a Recorded Level Sequence
		/// </returns>
		public virtual FString GetLevelPath()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLevelPath, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The Map used to create this recording
		/// </returns>
		public virtual ULevel GetLevelOrigin()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLevelOrigin, __ReturnBuffer);

				return *(ULevel*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Get if we get frame rate from time code
		/// </returns>
		public virtual bool GetFrameRateFromTimecode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetFrameRateFromTimecode, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The frame-rate for this take
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

		/// <returns>
		/// The duration for this take
		/// </returns>
		public virtual FFrameTime GetDuration()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDuration, __ReturnBuffer);

				return *(FFrameTime*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The user-provided description for this take
		/// </returns>
		public virtual FString GetDescription()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDescription, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual FString GenerateAssetPath(FString PathFormatString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PathFormatString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GenerateAssetPath, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __bIsLocked = 0;

		private static uint __Slate = 0;

		private static uint __TakeNumber = 0;

		private static uint __Timestamp = 0;

		private static uint __TimecodeIn = 0;

		private static uint __TimecodeOut = 0;

		private static uint __Duration = 0;

		private static uint __FrameRate = 0;

		private static uint __Description = 0;

		private static uint __PresetOrigin = 0;

		private static uint __LevelOrigin = 0;

		private static uint __bFrameRateFromTimecode = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __Unlock = 0;

		private static uint __SetTimestamp = 0;

		private static uint __SetTimecodeOut = 0;

		private static uint __SetTimecodeIn = 0;

		private static uint __SetTakeNumber = 0;

		private static uint __SetSlate = 0;

		private static uint __SetPresetOrigin = 0;

		private static uint __SetLevelOrigin = 0;

		private static uint __SetFrameRateFromTimecode = 0;

		private static uint __SetFrameRate = 0;

		private static uint __SetDuration = 0;

		private static uint __SetDescription = 0;

		private static uint __Recorded = 0;

		private static uint __Lock = 0;

		private static uint __IsLocked = 0;

		private static uint __GetTimestamp = 0;

		private static uint __GetTimecodeOut = 0;

		private static uint __GetTimecodeIn = 0;

		private static uint __GetTakeNumber = 0;

		private static uint __GetSlate = 0;

		private static uint __GetPresetOrigin = 0;

		private static uint __GetLevelPath = 0;

		private static uint __GetLevelOrigin = 0;

		private static uint __GetFrameRateFromTimecode = 0;

		private static uint __GetFrameRate = 0;

		private static uint __GetDuration = 0;

		private static uint __GetDescription = 0;

		private static uint __GenerateAssetPath = 0;
	}
}