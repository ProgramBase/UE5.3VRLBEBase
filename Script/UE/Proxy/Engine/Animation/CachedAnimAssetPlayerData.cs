using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CachedAnimAssetPlayerData")]
	public partial class FCachedAnimAssetPlayerData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CachedAnimAssetPlayerData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCachedAnimAssetPlayerData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCachedAnimAssetPlayerData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCachedAnimAssetPlayerData A, FCachedAnimAssetPlayerData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCachedAnimAssetPlayerData A, FCachedAnimAssetPlayerData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCachedAnimAssetPlayerData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName StateMachineName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StateMachineName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StateMachineName, __InBuffer);
				}
			}
		}

		public FName StateName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StateName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StateName, __InBuffer);
				}
			}
		}

		private static uint __StateMachineName = 0;

		private static uint __StateName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}