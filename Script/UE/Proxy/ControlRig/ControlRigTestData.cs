using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigTestData")]
	public partial class UControlRigTestData : UObject, IStaticClass
	{
		public FSoftObjectPath ControlRigObjectPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ControlRigObjectPath, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ControlRigObjectPath, __InBuffer);
				}
			}
		}

		public FControlRigTestDataFrame Initial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Initial, __ReturnBuffer);

					return *(FControlRigTestDataFrame*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Initial, __InBuffer);
				}
			}
		}

		public TArray<FControlRigTestDataFrame> InputFrames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputFrames, __ReturnBuffer);

					return *(TArray<FControlRigTestDataFrame>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputFrames, __InBuffer);
				}
			}
		}

		public TArray<FControlRigTestDataFrame> OutputFrames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OutputFrames, __ReturnBuffer);

					return *(TArray<FControlRigTestDataFrame>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OutputFrames, __InBuffer);
				}
			}
		}

		public TArray<int> FramesToSkip
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FramesToSkip, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FramesToSkip, __InBuffer);
				}
			}
		}

		public double Tolerance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Tolerance, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Tolerance, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRig.ControlRigTestData");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetupReplay(UControlRig InControlRig, bool bGroundTruth = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bGroundTruth;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetupReplay, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void ReleaseReplay()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ReleaseReplay);
			}
		}

		public virtual bool Record(UControlRig InControlRig, double InRecordingDuration = 0.000000)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InControlRig?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = InRecordingDuration;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Record, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsReplaying()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsReplaying, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsRecording()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsRecording, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FVector2D GetTimeRange(bool bInput = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInput;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTimeRange, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public virtual EControlRigTestDataPlaybackMode GetPlaybackMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPlaybackMode, __ReturnBuffer);

				return *(EControlRigTestDataPlaybackMode*)__ReturnBuffer;
			}
		}

		public virtual int GetFrameIndexForTime(double InSeconds, bool bInput = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(double*)(__InBuffer) = InSeconds;

				*(bool*)(__InBuffer + 8) = bInput;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetFrameIndexForTime, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static UControlRigTestData CreateNewAsset(FString InDesiredPackagePath, FString InBlueprintPathName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InDesiredPackagePath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InBlueprintPathName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateNewAsset, __InBuffer, __ReturnBuffer);

				return *(UControlRigTestData*)__ReturnBuffer;
			}
		}

		private static uint __ControlRigObjectPath = 0;

		private static uint __Initial = 0;

		private static uint __InputFrames = 0;

		private static uint __OutputFrames = 0;

		private static uint __FramesToSkip = 0;

		private static uint __Tolerance = 0;

		private static uint __SetupReplay = 0;

		private static uint __ReleaseReplay = 0;

		private static uint __Record = 0;

		private static uint __IsReplaying = 0;

		private static uint __IsRecording = 0;

		private static uint __GetTimeRange = 0;

		private static uint __GetPlaybackMode = 0;

		private static uint __GetFrameIndexForTime = 0;

		private static uint __CreateNewAsset = 0;
	}
}