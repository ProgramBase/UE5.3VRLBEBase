using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WalkableSlopeOverride")]
	public partial class FWalkableSlopeOverride : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.WalkableSlopeOverride");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWalkableSlopeOverride() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FWalkableSlopeOverride() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FWalkableSlopeOverride A, FWalkableSlopeOverride B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWalkableSlopeOverride A, FWalkableSlopeOverride B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWalkableSlopeOverride;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EWalkableSlopeBehavior WalkableSlopeBehavior
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WalkableSlopeBehavior, __ReturnBuffer);

					return *(EWalkableSlopeBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WalkableSlopeBehavior, __InBuffer);
				}
			}
		}

		public float WalkableSlopeAngle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WalkableSlopeAngle, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WalkableSlopeAngle, __InBuffer);
				}
			}
		}

		private static uint __WalkableSlopeBehavior = 0;

		private static uint __WalkableSlopeAngle = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}