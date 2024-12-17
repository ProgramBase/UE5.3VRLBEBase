using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.LevelSequenceCameraSettings")]
	public partial class FLevelSequenceCameraSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LevelSequence.LevelSequenceCameraSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLevelSequenceCameraSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLevelSequenceCameraSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLevelSequenceCameraSettings A, FLevelSequenceCameraSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLevelSequenceCameraSettings A, FLevelSequenceCameraSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLevelSequenceCameraSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bOverrideAspectRatioAxisConstraint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideAspectRatioAxisConstraint, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideAspectRatioAxisConstraint, __InBuffer);
				}
			}
		}

		public EAspectRatioAxisConstraint AspectRatioAxisConstraint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AspectRatioAxisConstraint, __ReturnBuffer);

					return *(EAspectRatioAxisConstraint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AspectRatioAxisConstraint, __InBuffer);
				}
			}
		}

		private static uint __bOverrideAspectRatioAxisConstraint = 0;

		private static uint __AspectRatioAxisConstraint = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}