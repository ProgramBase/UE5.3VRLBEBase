using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.A2CSPose")]
	public partial class FA2CSPose : FA2Pose, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.A2CSPose");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FA2CSPose()
		{
		}

		public static bool operator ==(FA2CSPose A, FA2CSPose B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FA2CSPose A, FA2CSPose B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FA2CSPose;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<byte> ComponentSpaceFlags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ComponentSpaceFlags, __ReturnBuffer);

					return *(TArray<byte>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ComponentSpaceFlags, __InBuffer);
				}
			}
		}

		private static uint __ComponentSpaceFlags = 0;

	}
}