using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;
using Script.TakeTrackRecorders;

namespace Script.TakeRecorder
{
	[PathName("/Script/TakeRecorder.TakeRecorderProjectParameters")]
	public partial class FTakeRecorderProjectParameters : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TakeRecorder.TakeRecorderProjectParameters");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTakeRecorderProjectParameters() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTakeRecorderProjectParameters() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTakeRecorderProjectParameters A, FTakeRecorderProjectParameters B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTakeRecorderProjectParameters A, FTakeRecorderProjectParameters B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTakeRecorderProjectParameters;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FDirectoryPath RootTakeSaveDir
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RootTakeSaveDir, __ReturnBuffer);

					return *(FDirectoryPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RootTakeSaveDir, __InBuffer);
				}
			}
		}

		public FString TakeSaveDir
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TakeSaveDir, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TakeSaveDir, __InBuffer);
				}
			}
		}

		public FString DefaultSlate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultSlate, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultSlate, __InBuffer);
				}
			}
		}

		public EUpdateClockSource RecordingClockSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RecordingClockSource, __ReturnBuffer);

					return *(EUpdateClockSource*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RecordingClockSource, __InBuffer);
				}
			}
		}

		public bool bStartAtCurrentTimecode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bStartAtCurrentTimecode, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bStartAtCurrentTimecode, __InBuffer);
				}
			}
		}

		public bool bRecordTimecode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bRecordTimecode, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bRecordTimecode, __InBuffer);
				}
			}
		}

		public bool bRecordSourcesIntoSubSequences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bRecordSourcesIntoSubSequences, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bRecordSourcesIntoSubSequences, __InBuffer);
				}
			}
		}

		public bool bRecordToPossessable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bRecordToPossessable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bRecordToPossessable, __InBuffer);
				}
			}
		}

		public TArray<FTakeRecorderTrackSettings> DefaultTracks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultTracks, __ReturnBuffer);

					return *(TArray<FTakeRecorderTrackSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultTracks, __InBuffer);
				}
			}
		}

		public bool bShowNotifications
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShowNotifications, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShowNotifications, __InBuffer);
				}
			}
		}

		private static uint __RootTakeSaveDir = 0;

		private static uint __TakeSaveDir = 0;

		private static uint __DefaultSlate = 0;

		private static uint __RecordingClockSource = 0;

		private static uint __bStartAtCurrentTimecode = 0;

		private static uint __bRecordTimecode = 0;

		private static uint __bRecordSourcesIntoSubSequences = 0;

		private static uint __bRecordToPossessable = 0;

		private static uint __DefaultTracks = 0;

		private static uint __bShowNotifications = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}