using Script.CoreUObject;
using Script.Library;

namespace Script.TakeRecorder
{
	[PathName("/Script/TakeRecorder.TakeRecorderParameters")]
	public partial class FTakeRecorderParameters : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TakeRecorder.TakeRecorderParameters");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTakeRecorderParameters() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTakeRecorderParameters() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTakeRecorderParameters A, FTakeRecorderParameters B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTakeRecorderParameters A, FTakeRecorderParameters B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTakeRecorderParameters;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FTakeRecorderUserParameters User
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __User, __ReturnBuffer);

					return *(FTakeRecorderUserParameters*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __User, __InBuffer);
				}
			}
		}

		public FTakeRecorderProjectParameters Project
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Project, __ReturnBuffer);

					return *(FTakeRecorderProjectParameters*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Project, __InBuffer);
				}
			}
		}

		public ETakeRecorderMode TakeRecorderMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TakeRecorderMode, __ReturnBuffer);

					return *(ETakeRecorderMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TakeRecorderMode, __InBuffer);
				}
			}
		}

		public FFrameNumber StartFrame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StartFrame, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StartFrame, __InBuffer);
				}
			}
		}

		public bool bDisableRecordingAndSave
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bDisableRecordingAndSave, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bDisableRecordingAndSave, __InBuffer);
				}
			}
		}

		private static uint __User = 0;

		private static uint __Project = 0;

		private static uint __TakeRecorderMode = 0;

		private static uint __StartFrame = 0;

		private static uint __bDisableRecordingAndSave = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}