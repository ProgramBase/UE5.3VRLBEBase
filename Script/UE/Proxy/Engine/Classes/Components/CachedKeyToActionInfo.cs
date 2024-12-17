using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CachedKeyToActionInfo")]
	public partial class FCachedKeyToActionInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CachedKeyToActionInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCachedKeyToActionInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCachedKeyToActionInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCachedKeyToActionInfo A, FCachedKeyToActionInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCachedKeyToActionInfo A, FCachedKeyToActionInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCachedKeyToActionInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TWeakObjectPtr<UPlayerInput> PlayerInput
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PlayerInput, __ReturnBuffer);

					return *(TWeakObjectPtr<UPlayerInput>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PlayerInput, __InBuffer);
				}
			}
		}

		private static uint __PlayerInput = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}