using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StreamingLevelsToConsider")]
	public partial class FStreamingLevelsToConsider : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.StreamingLevelsToConsider");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStreamingLevelsToConsider() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStreamingLevelsToConsider() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStreamingLevelsToConsider A, FStreamingLevelsToConsider B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStreamingLevelsToConsider A, FStreamingLevelsToConsider B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStreamingLevelsToConsider;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<ULevelStreaming> StreamingLevels
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StreamingLevels, __ReturnBuffer);

					return *(TArray<ULevelStreaming>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StreamingLevels, __InBuffer);
				}
			}
		}

		private static uint __StreamingLevels = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}